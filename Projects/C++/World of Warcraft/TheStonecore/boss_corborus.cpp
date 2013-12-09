#include "ScriptPCH.h"
#include "the_stonecore.h"

enum Spells
{
    SPELL_BERSERK                    = 47008,     // Bersekr
    SPELL_CRYSTAL_BARRAGE            = 86881,     // Crystal Barrage normal
    SPELL_CRYSTAL_BARRAGE_SUMMON     = 92012, 
    SPELL_DAMPENING_WAVE             = 82415,     // Dampening Wave normal
    SPELL_BURROW_STEALTH             = 26381,     // Burrow - STEALTH
    SPELL_BORROW_CHANGE_MODEL        = 50981,
    SPELL_ROCK_BORE                  = 80028,
    SPELL_CRYSTAL_SHARDS             = 92122,
    SPELL_TRASHING_CHARGE            = 81828,
    SPELL_TRASHING_CHARGE_SUMMON     = 81816,
    SPELL_TRASHING_CHARGE_DUMMY      = 81801,
};

enum Events
{
    EVENT_CRYSTAL_BARRAGE            = 1,     // Crystal Barrage normal
    EVENT_DAMPENING_WAVE             = 2,     // Dampening Wave normal
    EVENT_BURROW                     = 3,     // Burrow
    EVENT_SUMMON_ROCK_BOBER          = 4,
    EVENT_ROCK_BORE                  = 5,
    EVENT_CRYSTAL_SHARDS_SUMMON      = 6,
    EVENT_BERSERK                    = 7,
    EVENT_PHASE_NORMAL               = 8,
    EVENT_PHASE_GROUND               = 9,
    EVENT_JUMP_VISIBILITY            = 10,
    EVENT_START_VISIBILITY           = 11,
    EVENT_TRASHING_CHARGE            = 12,
};

enum Phases
{
    PHASE_NORMAL,
    PHASE_GROUND,
    PHASE_CRYSTAL,
};

bool despawn;
bool crystal;

class boss_corborus : public CreatureScript
{
public:
    boss_corborus() : CreatureScript("boss_corborus") {}

    CreatureAI* GetAI(Creature* creature) const
    {
        return new boss_corborusAI (creature);
    }

    struct boss_corborusAI : public BossAI
    {
        boss_corborusAI(Creature* creature) : BossAI(creature, DATA_CORBORUS)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        uint8 phase;
        EventMap events;
        uint32 jump;
        uint32 summon;
        uint64 trashingGUID;
        bool check_in;
        bool phaseInitiated;

        void Reset()
        {
            events.Reset();

            if (instance && (instance->GetData(DATA_CORBORUS_EVENT) != DONE &&  !check_in))
                instance->SetData(DATA_CORBORUS_EVENT, NOT_STARTED);

            me->SetVisible(true);
            me->SetDisplayId(33477);
            me->RemoveFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_NOT_SELECTABLE);
            me->RemoveAurasDueToSpell(SPELL_BERSERK);
            events.ScheduleEvent(EVENT_BERSERK, 300 *IN_MILLISECONDS);
            jump = 0;
            summon = 0;
            trashingGUID = 0;
            check_in = false;
            phaseInitiated = false;
            despawn = false;
            crystal = false;
            phase = PHASE_NORMAL;
            summons.DespawnAll();
        }

        void JustDied(Unit* /*killer*/)
        {
            if (instance)
                instance->SetData(DATA_CORBORUS_EVENT, DONE);

            despawn = false;
            summons.DespawnAll();
        }

        void EnterCombat(Unit* /*killer*/)
        {
            if (instance)
                instance->SetData(DATA_CORBORUS_EVENT, IN_PROGRESS);

            despawn = true;
            DoZoneInCombat();
        }

        void JustSummoned(Creature* summoned)
        {
            summoned->SetInCombatWithZone();

            if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0))
                summoned->AI()->AttackStart(target);
            summons.Summon(summoned);
        }

        void SummonedCreatureDespawn(Creature* summon)
        {
            summons.Despawn(summon);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (phase == PHASE_NORMAL && !phaseInitiated)
            {
                me->RemoveFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_NOT_SELECTABLE);
                events.CancelEvent(EVENT_BURROW);
                events.CancelEvent(EVENT_SUMMON_ROCK_BOBER);
                me->SetVisible(true);
                events.ScheduleEvent(EVENT_CRYSTAL_BARRAGE, 15 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_DAMPENING_WAVE, 4 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_PHASE_GROUND, 35 *IN_MILLISECONDS);
                phaseInitiated = true;     
            }

            if (phase == PHASE_GROUND && !phaseInitiated)
            {
                me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_NOT_SELECTABLE);
                me->SetVisible(false);
                events.CancelEvent(EVENT_CRYSTAL_BARRAGE);
                events.CancelEvent(EVENT_DAMPENING_WAVE);
                events.CancelEvent(EVENT_SUMMON_ROCK_BOBER);
                jump = 0;
                summon = 0;
                events.ScheduleEvent(EVENT_BURROW, 10 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_SUMMON_ROCK_BOBER, 2 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_PHASE_NORMAL, 35 *IN_MILLISECONDS);
                phaseInitiated = true;
            }

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_PHASE_NORMAL:
                    phase = PHASE_NORMAL;
                    me->SetVisible(true);
                    phaseInitiated = false;
                    break;
                case EVENT_PHASE_GROUND:
                    phase = PHASE_GROUND;
                    phaseInitiated = false;
                    break;
                case EVENT_START_VISIBILITY:
                    me->SetDisplayId(33477);
                    break;
                case EVENT_JUMP_VISIBILITY:
                    me->SetVisible(false);
                    break;
                case EVENT_CRYSTAL_SHARDS_SUMMON:
                    if (Unit * crystal_summon = Unit::GetCreature(*me, trashingGUID))
                    {
                        for (uint8 i = 0; i < 6; ++i)
                            crystal_summon->CastSpell(me, SPELL_CRYSTAL_BARRAGE_SUMMON, true);
                        if (IsHeroic())
                            for (uint8 i = 0; i < 4; ++i)
                                crystal_summon->CastSpell(me, SPELL_CRYSTAL_BARRAGE_SUMMON, true);
                    }
                    crystal = true;
                    break;
                case EVENT_CRYSTAL_BARRAGE:
                    if (phase == PHASE_NORMAL)
                    {
                        if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        {
                            DoCast(target, SPELL_CRYSTAL_BARRAGE);
                            if (Unit* crystal = me->SummonCreature(NPC_TRASHING_CHARGE, target->GetPositionX(), target->GetPositionY(), target->GetPositionZ(), 0.0f, TEMPSUMMON_CORPSE_DESPAWN))
                            {
                                crystal->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_IMMUNE_TO_PC | UNIT_FLAG_NOT_SELECTABLE);
                                trashingGUID = crystal->GetGUID();
                            }
                        }
                        events.ScheduleEvent(EVENT_CRYSTAL_SHARDS_SUMMON, 5 *IN_MILLISECONDS);
                        events.ScheduleEvent(EVENT_CRYSTAL_BARRAGE, 15 *IN_MILLISECONDS);
                    }
                    break;
                case EVENT_DAMPENING_WAVE:
                    if (phase == PHASE_NORMAL)
                    {
                        DoCast(me, SPELL_DAMPENING_WAVE);
                        events.ScheduleEvent(EVENT_DAMPENING_WAVE, 10 *IN_MILLISECONDS);
                    }
                    break;
                case EVENT_BURROW:
                    if (phase == PHASE_GROUND)
                    {
                        me->SetDisplayId(11686);
                        me->SetVisible(true);
                        if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        {
                            if (Unit* charge = me->SummonCreature(NPC_TRASHING_CHARGE, target->GetPositionX(), target->GetPositionY(), target->GetPositionZ(), 0.0f, TEMPSUMMON_CORPSE_DESPAWN))
                            {
                                charge->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_IMMUNE_TO_PC | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_NOT_SELECTABLE);
                                charge->CastSpell(me, SPELL_TRASHING_CHARGE_DUMMY, true);
                            }
                            DoCast(target, SPELL_TRASHING_CHARGE_DUMMY);
                            events.ScheduleEvent(EVENT_START_VISIBILITY, 2.5 *IN_MILLISECONDS);
                            events.ScheduleEvent(EVENT_JUMP_VISIBILITY, 4 *IN_MILLISECONDS);
                        }

                        if (++jump <= 4)
                            events.ScheduleEvent(EVENT_BURROW, 10 *IN_MILLISECONDS);
                    }
                    break;
                case EVENT_SUMMON_ROCK_BOBER:
                    if (phase == PHASE_GROUND)
                    {
                        if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                            me->SummonCreature(NPC_ROCK_BORER, target->GetPositionX(), target->GetPositionY(), target->GetPositionZ(), 0.0f, TEMPSUMMON_CORPSE_DESPAWN);

                        if (!IsHeroic())
                        {
                            if (++summon <= 2)
                                events.ScheduleEvent(EVENT_SUMMON_ROCK_BOBER, 4 *IN_MILLISECONDS);
                        }
                        if (IsHeroic())
                            if (++summon <= 4)
                                events.ScheduleEvent(EVENT_SUMMON_ROCK_BOBER, 2 *IN_MILLISECONDS);
                    }
                    break;
                case EVENT_BERSERK:
                    DoCast(me, SPELL_BERSERK);
                    break;
                }
            }
            DoMeleeAttackIfReady();
        }
    };
};

class npc_rock_borer : public CreatureScript
{
public:
    npc_rock_borer() : CreatureScript("npc_rock_borer") {}

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_rock_borerAI (creature);
    }

    struct npc_rock_borerAI : public BossAI
    {
        npc_rock_borerAI(Creature* creature) : BossAI(creature, DATA_ROCK_BORER)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        void Reset()
        {
            events.Reset();
        }

        void EnterCombat(Unit* /*killer*/)
        {
            DoZoneInCombat();
            events.ScheduleEvent(EVENT_ROCK_BORE, 1 *IN_MILLISECONDS);
        }

        void UpdateAI(const uint32 diff)
        {
            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_ROCK_BORE:
                    if (me->IsWithinMeleeRange(me->getVictim()))
                        DoCast(me->getVictim(), SPELL_ROCK_BORE);

                    events.ScheduleEvent(EVENT_ROCK_BORE, 3 *IN_MILLISECONDS);
                    break;
                }
            }
            DoMeleeAttackIfReady();
        }
    };
};

class npc_crystal_shards : public CreatureScript
{
public:
    npc_crystal_shards() : CreatureScript("npc_crystal_shards") {}

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_crystal_shardsAI (creature);
    }

    struct npc_crystal_shardsAI : public BossAI
    {
        npc_crystal_shardsAI(Creature* creature) : BossAI(creature, DATA_CRYSTAL_SHARDS)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        uint8 phase;

        void Reset()
        {
            events.Reset();
            phase = PHASE_CRYSTAL;

            if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0))
                me->AI()->AttackStart(target);
        }

        void EnterCombat(Unit* /*killer*/)
        {
            DoZoneInCombat();
        }

        void UpdateAI(const uint32 diff)
        {
            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (crystal == true)
            {
                if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0))
                    me->AI()->AttackStart(target);
                crystal = false;
            }

            if (despawn == false)
                me->DespawnOrUnsummon();

            if (Unit* corborus = Unit::GetCreature(*me, instance->GetData64(BOSS_CORBORUS)))
            {
                if (corborus->isDead())
                    me->DespawnOrUnsummon();
            }
            
            if (me->IsWithinMeleeRange(me->getVictim()))
            {
                DoCast(me->getVictim(), SPELL_CRYSTAL_SHARDS);
                me->DespawnOrUnsummon();
            }
        }
    };
};

void AddSC_boss_corborus()
{
    new boss_corborus();
    new npc_rock_borer();
    new npc_crystal_shards();
}