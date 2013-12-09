#include "ScriptPCH.h"
#include "the_stonecore.h"
#include "Group.h"

enum Spells
{
    SPELL_BERSERK                           = 47008,
    SPELL_ELEMENTIUM_BULWARK                = 78939,
    SPELL_ELEMENTIUM_SPIKE_SHIELD           = 78835,
    SPELL_ENRAGE                            = 80467,
    SPELL_GROUND_SLAM                       = 78903,
    SPELL_RUPTURE_DAMAGE                    = 92381,
    SPELL_RUPTURE_SUMMON                    = 92383,
    SPELL_PARALYZE                          = 92426,
    SPELL_SHATTER                           = 78807,
};

enum Events
{
    EVENT_BERSERK                           = 1,
    EVENT_GROUND_SLAM                       = 2,
    EVENT_FROST_FEVER                       = 3,
    EVENT_PARALYZE                          = 4,
    EVENT_SHATTER                           = 5,
    EVENT_SLOW                              = 6,
    EVENT_ELEMENTIUM_BULWARK                = 7,
    EVENT_ELEMENTIUM_SPIKE_SHIELD           = 8,
    EVENT_AGAIN_SHIELD                      = 9,
};

enum Phases
{
    PHASE_SHIELDS,
};

class boss_ozruk: public CreatureScript
{
public:
    boss_ozruk() : CreatureScript("boss_ozruk") { }

    struct boss_ozrukAI: public BossAI
    {
        boss_ozrukAI(Creature* creature) : BossAI(creature, DATA_OZRUK)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        EventMap events;
        uint8 phase;
        bool check_in;
        bool phaseInitiated;
        bool shield;
        uint32 enrage;

        void Reset()
        {
            events.Reset();
            if (instance && (instance->GetData(DATA_OZRUK_EVENT) != DONE &&  !check_in))
                instance->SetData(DATA_OZRUK_EVENT, NOT_STARTED);

            me->RemoveAurasDueToSpell(SPELL_BERSERK);
            events.ScheduleEvent(EVENT_BERSERK, 300 *IN_MILLISECONDS);
            check_in = false;
            phaseInitiated = false;
            shield = true;
            phase = PHASE_SHIELDS;
            enrage = 0;
        }

        void EnterCombat(Unit* /*Ent*/)
        {
            DoZoneInCombat();

            events.ScheduleEvent(EVENT_GROUND_SLAM, 32 *IN_MILLISECONDS);

            if (instance)
                instance->SetData(DATA_OZRUK_EVENT, IN_PROGRESS);
        }

        void JustDied(Unit* /*killer*/)
        {
            if (instance)
                instance->SetData(DATA_OZRUK_EVENT, DONE);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (phase == PHASE_SHIELDS && !phaseInitiated)
            {
                events.ScheduleEvent(EVENT_ELEMENTIUM_BULWARK, 11 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_ELEMENTIUM_SPIKE_SHIELD, 22 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_AGAIN_SHIELD, 70 *IN_MILLISECONDS);
                phaseInitiated = true;
                shield = false;
            }

            if (me->GetHealthPct() < 20 && enrage == 0)
            {
                DoCast(me, SPELL_ENRAGE);
                enrage = 1;
            }

            if (me->HasAura(SPELL_ELEMENTIUM_SPIKE_SHIELD) && !shield)
            {
                events.ScheduleEvent(EVENT_PARALYZE, 12 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_SHATTER, 13 *IN_MILLISECONDS);
                shield = true;
            }

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_AGAIN_SHIELD:
                    phase = PHASE_SHIELDS;
                    phaseInitiated = false;
                    break;
                case EVENT_ELEMENTIUM_BULWARK:
                    DoCast(SPELL_ELEMENTIUM_BULWARK);
                    break;
                case EVENT_ELEMENTIUM_SPIKE_SHIELD:
                    DoCast(SPELL_ELEMENTIUM_SPIKE_SHIELD);
                    break;
                case EVENT_PARALYZE:
                    DoCast(SPELL_PARALYZE);
                    break;
                case EVENT_GROUND_SLAM:
                    if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        DoCast(target, SPELL_GROUND_SLAM);
                    events.RescheduleEvent(EVENT_GROUND_SLAM, 26 *IN_MILLISECONDS);
                    break;
                case EVENT_SHATTER:
                    DoCast(SPELL_SHATTER);
                    break;
                case EVENT_BERSERK:
                    DoCast(me, SPELL_BERSERK);
                    break;
                }
            }

            DoMeleeAttackIfReady();
        }
     };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new boss_ozrukAI(creature);
    }
};

class npc_rupture_controller: public CreatureScript
{
public:
    npc_rupture_controller() : CreatureScript("npc_rupture_controller") { }

    struct npc_rupture_controllerAI: public BossAI
    {
        npc_rupture_controllerAI(Creature* creature) : BossAI(creature, DATA_OZRUK)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        void Reset()
        {
            DoCast(SPELL_RUPTURE_SUMMON);
        }
     };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_rupture_controllerAI(creature);
    }
};

class npc_rupture_dmg: public CreatureScript
{
public:
    npc_rupture_dmg() : CreatureScript("npc_rupture_dmg") { }

    struct npc_rupture_dmgAI: public BossAI
    {
        npc_rupture_dmgAI(Creature* creature) : BossAI(creature, DATA_OZRUK)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
            me->setFaction(16);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (me->IsWithinMeleeRange(me->getVictim()))
            {
                DoCast(me->getVictim(), SPELL_RUPTURE_DAMAGE);
                //me->DespawnOrUnsummon();
            }
        }
     };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_rupture_dmgAI(creature);
    }
};

void AddSC_boss_ozruk()
{
    new boss_ozruk();
    new npc_rupture_controller();
    new npc_rupture_dmg();
}