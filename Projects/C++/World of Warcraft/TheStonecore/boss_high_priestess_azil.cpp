#include "ScriptPCH.h"
#include "the_stonecore.h"

enum Spells
{
    SPELL_BERSERK               = 47008,
    SPELL_CURSE_OF_BLOOD        = 79345,
    SPELL_ENERGY_SHIELD         = 79050,
    SPELL_FORCE_GRIP            = 79351,
    SPELL_FORCE_GRIP_VEHICLE    = 79354,
    SPELL_FORCE_GRIP_DAMAGE     = 79358,
    SPELL_SEISMIC_SHARD_DUMMY   = 79002,
    SPELL_SEISMIC_SHARD_DAMAGE  = 79021,
    SPELL_SEISMIC_SHARD_SUMMON  = 86856,
    SPELL_SEISMIC_SHARD_VEHICLE = 86863,
    SPELL_SEISMIC_SHARD_AURA    = 79009,
    SPELL_GRAVITY_WELL_SUMMON   = 79340,
    SPELL_GRAVITY_WELL_DAMAGE   = 83578,
    SPELL_GRAVITY_WELL_VISUAL   = 79249,
    SPELL_GRAVITY_WELL_PERIODIC = 79333,
    SPELL_GRAVITY_WELL_DUMMY    = 79245,
    SPELL_GRAVITY_WELL_AURA     = 79244,
};

enum Events
{
    EVENT_BERSERK               = 1,
    EVENT_CURSE_OF_BLOOD        = 2,
    EVENT_FORCE_GRIP            = 3,
    EVENT_SEISMIC_SHARD         = 4,
    EVENT_GRAVITY_WELL          = 5,
    EVENT_SUMMON_GUARDS         = 6,
    EVENT_PHASE_MOVE            = 7,
    EVENT_PHASE_SHIELD          = 8,
    EVENT_START_METEOR          = 9,
    EVENT_SEND_NEXT_METEOR      = 10,
    EVENT_ENERGY_SHIELD         = 11,
    EVENT_GRAVITY_WELL_AURA     = 12,
};

enum Phases
{
    PHASE_SHIELDS,
    PHASE_MOVE,
};

Position const MeteorPosition[6] =
{
    // Meteor Position
    {1359.721558f, 967.184692f, 226.913452f, 1.855960f},
    {1337.809692f, 963.853699f, 233.350693f, 1.730296f},
    {1317.360840f, 958.692078f, 225.109161f, 1.871670f},

    // Azil Position
    {1337.535889f, 964.863403f, 214.183197f, 2.093150f},

    // Summon guards left or right side
    {1282.581421f, 990.2060550f, 207.484970f, 0.379104f},
    {1362.659668f, 1005.729614f, 208.800522f, 3.324347f},
};

bool creature;
float speed;

class boss_high_priestess_azil: public CreatureScript
{
public:
    boss_high_priestess_azil() : CreatureScript("boss_high_priestess_azil") { }

    struct boss_high_priestess_azilAI: public BossAI
    {
        boss_high_priestess_azilAI(Creature* creature) : BossAI(creature, DATA_HIGH_PRIESTESS_AZIL)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        EventMap events;
        bool check_in;
        bool phaseInitiated;
        uint32 gravity;
        uint32 phase;
        uint32 summon;
        uint64 triggerGUID;
        uint64 meteorGUID;
        std::vector<Unit*> meteors;

        void Reset()
        {
            events.Reset();
            if (instance && (instance->GetData(DATA_HIGH_PRIESTESS_AZIL_EVENT) != DONE &&  !check_in))
                instance->SetData(DATA_HIGH_PRIESTESS_AZIL_EVENT, NOT_STARTED);

            me->RemoveAurasDueToSpell(SPELL_BERSERK);
            events.ScheduleEvent(EVENT_BERSERK, 300 *IN_MILLISECONDS);
            phase = PHASE_MOVE;
            gravity = 0;
            summon = 0;
            triggerGUID = 0;
            meteorGUID = 0;
            check_in = false;
            creature = true;
            phaseInitiated = false;
            summons.DespawnAll();
        }

        void EnterCombat(Unit* /*Ent*/)
        {
            DoZoneInCombat();

            if (instance)
                instance->SetData(DATA_HIGH_PRIESTESS_AZIL_EVENT, IN_PROGRESS);
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

        void JustDied(Unit* /*killer*/)
        {
            if (instance)
                instance->SetData(DATA_HIGH_PRIESTESS_AZIL_EVENT, DONE);

            summons.DespawnAll();
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (phase == PHASE_MOVE && !phaseInitiated)
            {
                me->RemoveFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_NOT_SELECTABLE);
                me->RemoveAurasDueToSpell(SPELL_ENERGY_SHIELD);
                if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                    me->GetMotionMaster()->MoveFollow(target, 3, 2);
                gravity = 0;
                summon = 0;
                creature = false;
                events.CancelEvent(EVENT_SEISMIC_SHARD);
                events.CancelEvent(EVENT_ENERGY_SHIELD);
                events.ScheduleEvent(EVENT_CURSE_OF_BLOOD, 1 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_GRAVITY_WELL, 2 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_PHASE_SHIELD, 35 *IN_MILLISECONDS);
                phaseInitiated = true;
            }

            if (phase == PHASE_SHIELDS && !phaseInitiated)
            {
                me->GetMotionMaster()->MovePoint(1, MeteorPosition[3]);
                me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_NOT_SELECTABLE);
                DoCast(me, SPELL_ENERGY_SHIELD);
                DoCast(me, SPELL_SEISMIC_SHARD_DUMMY);
                events.CancelEvent(EVENT_CURSE_OF_BLOOD);
                events.CancelEvent(EVENT_GRAVITY_WELL);
                events.ScheduleEvent(EVENT_SUMMON_GUARDS, 1 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_SEISMIC_SHARD, 2 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_START_METEOR, 12 *IN_MILLISECONDS);
                events.ScheduleEvent(EVENT_PHASE_MOVE, 35 *IN_MILLISECONDS);
                phaseInitiated = true;
                creature = true;
            }

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_PHASE_SHIELD:
                    phase = PHASE_SHIELDS;
                    phaseInitiated = false;
                    break;
                case EVENT_PHASE_MOVE:
                    phase = PHASE_MOVE;
                    phaseInitiated = false;
                    break;
                case EVENT_CURSE_OF_BLOOD:
                    if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        DoCast(target, SPELL_CURSE_OF_BLOOD);
                    events.RescheduleEvent(EVENT_CURSE_OF_BLOOD, 15 *IN_MILLISECONDS);
                    break;
                case EVENT_GRAVITY_WELL:
                    if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        DoCast(target, SPELL_GRAVITY_WELL_SUMMON);
                    
                    if (++gravity <= 6)
                        events.RescheduleEvent(EVENT_GRAVITY_WELL, 5 *IN_MILLISECONDS);
                    break;
                case EVENT_SUMMON_GUARDS:
                    for (uint8 i = 0; i < 10; ++i)                                  //summon 10 Guards
                        me->SummonCreature(NPC_DEVOUT_FOLLOWER, MeteorPosition[4], TEMPSUMMON_CORPSE_DESPAWN);
                    for (uint8 i = 0; i < 10; ++i)                                  //summon 10 Guards
                        me->SummonCreature(NPC_DEVOUT_FOLLOWER, MeteorPosition[5], TEMPSUMMON_CORPSE_DESPAWN);
                    break;
                case EVENT_SEISMIC_SHARD:
                    meteors.push_back(me->SummonCreature(NPC_SEISMIC_SHARD, MeteorPosition[0], TEMPSUMMON_CORPSE_DESPAWN));
                    meteors.push_back(me->SummonCreature(NPC_SEISMIC_SHARD, MeteorPosition[1], TEMPSUMMON_CORPSE_DESPAWN));
                    meteors.push_back(me->SummonCreature(NPC_SEISMIC_SHARD, MeteorPosition[2], TEMPSUMMON_CORPSE_DESPAWN));
                    break;
                case EVENT_START_METEOR:
                    if (meteors.size())
                    {
                        if (Unit* target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        {
                            uint8 i = urand(0, meteors.size()-1);
                            if (Unit* trigger = me->SummonCreature(NPC_SEISMIC_SHARD_TRIGGER, target->GetPositionX(), target->GetPositionY(), target->GetPositionZ(), 0.0f, TEMPSUMMON_CORPSE_DESPAWN))
                            {
                                meteors[i]->SetSpeed(MOVE_RUN, speed*3.0f, true);
                                meteors[i]->SetSpeed(MOVE_WALK, speed*3.0f, true);
                                meteors[i]->SetSpeed(MOVE_FLIGHT, speed*3.0f, true);
                                meteors[i]->GetMotionMaster()->MovePoint(1, trigger->GetPositionX(), trigger->GetPositionY(), trigger->GetPositionZ());
                                trigger->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_IMMUNE_TO_NPC | UNIT_FLAG_NOT_SELECTABLE);
                                triggerGUID = trigger->GetGUID();
                                meteorGUID = meteors[i]->GetGUID();
                            }
                            meteors.erase(meteors.begin() + i);

                            if (++summon <= 3)
                                events.ScheduleEvent(EVENT_SEND_NEXT_METEOR, 1 *IN_MILLISECONDS);

                            if (meteors.size())
                                events.RescheduleEvent(EVENT_START_METEOR, 10 *IN_MILLISECONDS);
                        }
                    }
                    break;
                case EVENT_SEND_NEXT_METEOR:
                    if (Unit * cast = Unit::GetCreature(*me, triggerGUID))
                    {
                        cast->setFaction(16);
                        cast->CastSpell(me, SPELL_SEISMIC_SHARD_DAMAGE, true);
                    }
                    if (Unit * despawn = Unit::GetCreature(*me, meteorGUID))
                        despawn->SetVisible(false);
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
        return new boss_high_priestess_azilAI(creature);
    }
};

class npc_gravity_well: public CreatureScript
{
public:
    npc_gravity_well() : CreatureScript("npc_gravity_well") { }

    struct npc_gravity_wellAI: public BossAI
    {
        npc_gravity_wellAI(Creature* creature) : BossAI(creature, DATA_GRAVITY_WELL)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        void Reset()
        {
            me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_IMMUNE_TO_NPC | UNIT_FLAG_NOT_SELECTABLE);
            events.ScheduleEvent(EVENT_GRAVITY_WELL_AURA, 3 *IN_MILLISECONDS);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;
            
            if (creature == true)
                me->DespawnOrUnsummon();

            if (me->HasAura(SPELL_GRAVITY_WELL_AURA))
            {
                if (me->IsWithinMeleeRange(me->getVictim()))
                {
                    DoCast(me->getVictim(), SPELL_GRAVITY_WELL_VISUAL);
                    DoCast(me->getVictim(), SPELL_GRAVITY_WELL_DAMAGE);
                }
            }

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_GRAVITY_WELL_AURA:
                    me->RemoveAura(SPELL_GRAVITY_WELL_DUMMY);
                    DoCast(me, SPELL_GRAVITY_WELL_AURA);
                    break;
                }
            }
        }
    };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_gravity_wellAI(creature);
    }
};

class npc_seismic_shards: public CreatureScript
{
public:
    npc_seismic_shards() : CreatureScript("npc_seismic_shards") { }

    struct npc_seismic_shardsAI: public BossAI
    {
        npc_seismic_shardsAI(Creature* creature) : BossAI(creature, DATA_SEISMIC_SHARD)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
            speed = creature->GetSpeedRate(MOVE_RUN);
        }

        void Reset()
        {
            me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_NOT_SELECTABLE);
            me->AddAura(SPELL_SEISMIC_SHARD_AURA, me);
            me->GetMotionMaster()->MoveTargetedHome();
        }
     };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_seismic_shardsAI(creature);
    }
};

void AddSC_boss_high_priestess_azil()
{
    new boss_high_priestess_azil();
    new npc_gravity_well();
    new npc_seismic_shards();
}