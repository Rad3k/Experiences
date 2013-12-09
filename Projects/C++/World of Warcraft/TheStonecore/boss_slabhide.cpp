#include "ScriptPCH.h"
#include "the_stonecore.h"

enum Spells
{
    SPELL_BERSERK              = 47008,
    SPELL_CRYSTAL_STORM        = 92301,
    SPELL_SAND_BLAST           = 80807,
    SPELL_LAVA_FISSURE         = 80803,
    SPELL_LAVA_FISSURE_DUMMY   = 80798,
    SPELL_LAVA_FISSURE_AURA    = 90391,
    SPELL_LAVA_FISSURE_DMG     = 92658,
    SPELL_STALACTITE_PERIODIC  = 80656,
    SPELL_STALACTITE_SUMMON    = 80650,
    SPELL_STALACTITE_TRIGGER   = 80643,
    SPELL_STALACTITE_DAMAGE    = 80647,
};

enum Events
{
    EVENT_BERSERK              = 1,
    EVENT_SAND_BLAST           = 2,
    EVENT_LAVA_FISSURE         = 3,
    EVENT_LAVA_FISSURE_KILL    = 4,
    EVENT_STALACTITE           = 5,
    EVENT_CRYSTAL_STORM        = 6,
    EVENT_FLY_POSTITION        = 7,
    EVENT_GROUND_POSITION      = 8,
    EVENT_LAVA_FISSURE_AURA    = 9,
};

Position const SlabhidePosition[3][21] =
{
    {
        // Slabhide Ground and Fly position
        {1288.722534f, 1229.743896f, 264.512573f, 4.553025f},
        {1297.907104f, 1224.518188f, 247.034775f, 4.341455f},
    },
    { 
        // Up Side
        {1270.23f, 1241.79f, 287.162f, 5.26953f},
        {1273.64f, 1236.33f, 287.398f, 5.26953f},
        {1277.04f, 1230.86f, 287.139f, 5.26953f},
        {1270.02f, 1225.81f, 287.126f, 3.83853f},
        {1265.1f, 1221.7f, 287.14f, 3.83853f},
        {1260.19f, 1217.59f, 287.595f, 3.83853f},
        {1262.49f, 1212.22f, 287.274f, 5.11653f},
        {1268.71f, 1210.55f, 287.176f, 6.02103f},
        {1271.95f, 1204.34f, 287.358f, 5.19303f},
        {1278.17f, 1202.67f, 287.804f, 6.02103f},
        {1283.84f, 1196.01f, 287.457f, 5.41803f},
        {1291.35f, 1201.58f, 287.259f, 0.637841f},
        {1294.00f, 1209.32f, 287.027f, 1.24084f},
        {1301.7f, 1212.02f, 287.067f, 0.336341f},
        {1304.39f, 1219.75f, 286.768f, 1.23634f},
        {1298.79f, 1227.24f, 287.005f, 2.21284f},
        {1291.1f, 1237.52f, 287.024f, 2.58634f},
        {1277.13f, 1241.61f, 287.139f, 3.37272f},
        {1284.1f, 1220.44f, 287.338f, 5.24809f},
        {1286.7f, 1205.3f, 287.248f, 3.39072f},
        {1261.78f, 1211.04f, 287.229f, 2.65497f},
    },
    { 
        // Down Side
        {1270.23f, 1241.79f, 247.162f, 5.26953f},
        {1273.64f, 1236.33f, 247.398f, 5.26953f},
        {1277.04f, 1230.86f, 247.139f, 5.26953f},
        {1270.02f, 1225.81f, 247.126f, 3.83853f},
        {1265.1f, 1221.7f, 247.14f, 3.83853f},
        {1260.19f, 1217.59f, 247.595f, 3.83853f},
        {1262.49f, 1212.22f, 247.274f, 5.11653f},
        {1268.71f, 1210.55f, 247.176f, 6.02103f},
        {1271.95f, 1204.34f, 247.358f, 5.19303f},
        {1278.17f, 1202.67f, 247.804f, 6.02103f},
        {1283.84f, 1196.01f, 247.457f, 5.41803f},
        {1291.35f, 1201.58f, 247.259f, 0.637841f},
        {1294.00f, 1209.32f, 247.027f, 1.24084f},
        {1301.7f, 1212.02f, 247.067f, 0.336341f},
        {1304.39f, 1219.75f, 246.768f, 1.23634f},
        {1298.79f, 1227.24f, 247.005f, 2.21284f},
        {1291.1f, 1237.52f, 247.024f, 2.58634f},
        {1277.13f, 1241.61f, 247.139f, 3.37272f},
        {1284.1f, 1220.44f, 247.338f, 5.24809f},
        {1286.7f, 1205.3f, 247.248f, 3.39072f},
        {1261.78f, 1211.04f, 247.229f, 2.65497f},
    }
};

class boss_slabhide: public CreatureScript
{
public:
    boss_slabhide() : CreatureScript("boss_slabhide") { }

    struct boss_slabhideAI: public BossAI
    {
        boss_slabhideAI(Creature* creature) : BossAI(creature, DATA_SLABHIDE)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        EventMap events;
        uint32 stalactite;
        bool check_in;

        void Reset()
        {
            events.Reset();
            if (instance && (instance->GetData(DATA_SLABHIDE_EVENT) != DONE &&  !check_in))
                instance->SetData(DATA_SLABHIDE_EVENT, NOT_STARTED);

            stalactite = 0;
            me->RemoveAurasDueToSpell(SPELL_BERSERK);
            check_in = false;
        }

        void EnterCombat(Unit* /*Ent*/)
        {
            DoZoneInCombat();

            events.ScheduleEvent(EVENT_BERSERK, 300 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_CRYSTAL_STORM, 30 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_FLY_POSTITION, 11 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_STALACTITE, 15 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_GROUND_POSITION, 20 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_LAVA_FISSURE, 10 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_SAND_BLAST, 8 *IN_MILLISECONDS);

            if (instance)
                instance->SetData(DATA_SLABHIDE_EVENT, IN_PROGRESS);
        }

        void JustDied(Unit* /*killer*/)
        {
            if (instance)
                instance->SetData(DATA_SLABHIDE_EVENT, DONE);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_FLY_POSTITION:
                    me->SetCanFly(true);
                    me->GetMotionMaster()->MovePoint(1, SlabhidePosition[0][0]);
                    events.RescheduleEvent(EVENT_FLY_POSTITION, 30 *IN_MILLISECONDS);
                    break;
                case EVENT_GROUND_POSITION:
                    me->SetCanFly(false);
                    me->GetMotionMaster()->MovePoint(2, SlabhidePosition[0][1]);
                    events.RescheduleEvent(EVENT_GROUND_POSITION, 30 *IN_MILLISECONDS);
                    break;
                case EVENT_SAND_BLAST:
                    if (Unit *target = SelectTarget(SELECT_TARGET_RANDOM, 0))
                        DoCast(target, SPELL_SAND_BLAST);
                    events.RescheduleEvent(EVENT_SAND_BLAST, 15 *IN_MILLISECONDS);
                    break;
                case EVENT_CRYSTAL_STORM:
                    DoCastAOE(SPELL_CRYSTAL_STORM);
                    events.RescheduleEvent(EVENT_CRYSTAL_STORM, 30 *IN_MILLISECONDS);
                    break;
                case EVENT_STALACTITE:
                    for (uint8 i = 0; i < 21; ++i)
                        me->SummonCreature(NPC_STALACTITE_TRIGGER, SlabhidePosition[1][i].GetPositionX(), SlabhidePosition[1][i].GetPositionY(), SlabhidePosition[1][i].GetPositionZ(), 0.0f, TEMPSUMMON_CORPSE_DESPAWN);
                    events.RescheduleEvent(EVENT_STALACTITE, 30 *IN_MILLISECONDS);
                    break;
                case EVENT_LAVA_FISSURE:
                    if (Unit *target = SelectTarget(SELECT_TARGET_RANDOM, 0, MAX_VISIBILITY_DISTANCE, true))
                        DoCast(target, SPELL_LAVA_FISSURE);
                    events.RescheduleEvent(EVENT_LAVA_FISSURE, 15 *IN_MILLISECONDS);
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
        return new boss_slabhideAI(creature);
    }
};

class npc_lava_fissure: public CreatureScript
{
public:
    npc_lava_fissure() : CreatureScript("npc_lava_fissure") { }

    struct npc_lava_fissureAI: public BossAI
    {
        npc_lava_fissureAI(Creature* creature) : BossAI(creature, DATA_LAVA_FISSURE)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        void Reset()
        {
            me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_IMMUNE_TO_NPC | UNIT_FLAG_NOT_SELECTABLE);
            DoCast(me, SPELL_LAVA_FISSURE_DUMMY);
        }

        void EnterCombat(Unit* /*Ent*/)
        {
            DoZoneInCombat();
            events.ScheduleEvent(EVENT_LAVA_FISSURE_AURA, 3 *IN_MILLISECONDS);
            events.ScheduleEvent(EVENT_LAVA_FISSURE_KILL, 20 *IN_MILLISECONDS);
        }

        void UpdateAI(const uint32 diff)
        {
            if (!UpdateVictim())
                return;

            events.Update(diff);

            if (me->HasUnitState(UNIT_STATE_CASTING))
                return;

            if (me->HasAura(SPELL_LAVA_FISSURE_AURA))
                if (me->IsWithinMeleeRange(me->getVictim()))
                    DoCast(me->getVictim(), SPELL_LAVA_FISSURE_DMG);

            while (uint32 eventId = events.ExecuteEvent())
            {
                switch (eventId)
                {
                case EVENT_LAVA_FISSURE_AURA:
                    me->RemoveAura(SPELL_LAVA_FISSURE_DUMMY);
                    DoCast(me, SPELL_LAVA_FISSURE_AURA);
                    break;
                case EVENT_LAVA_FISSURE_KILL:
                    me->DespawnOrUnsummon();
                    break;
                }
            }
        }
    };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_lava_fissureAI(creature);
    }
};

class npc_stalactite: public CreatureScript
{
public:
    npc_stalactite() : CreatureScript("npc_stalactite") { }

    struct npc_stalactiteAI: public BossAI
    {
        npc_stalactiteAI(Creature* creature) : BossAI(creature, DATA_STALACTITE)
        {
            me->ApplySpellImmune(0, IMMUNITY_EFFECT, SPELL_EFFECT_KNOCK_BACK, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_GRIP, true);
            me->ApplySpellImmune(0, IMMUNITY_MECHANIC, MECHANIC_DISORIENTED, true);
            me->ApplySpellImmune(0, IMMUNITY_ID, 88625, true);
        }

        void Reset()
        {
            me->SetFlag(UNIT_FIELD_FLAGS, UNIT_FLAG_NON_ATTACKABLE | UNIT_FLAG_DISABLE_MOVE | UNIT_FLAG_IMMUNE_TO_NPC | UNIT_FLAG_NOT_SELECTABLE);
            for (uint8 i = 0; i < 21; ++i)
                me->GetMotionMaster()->MovePoint(1, SlabhidePosition[2][i]);
            DoCast(SPELL_STALACTITE_TRIGGER);
        }
    };

    CreatureAI* GetAI(Creature* creature) const
    {
        return new npc_stalactiteAI(creature);
    }
};

class go_stalactite : public GameObjectScript
{
public:
    go_stalactite() : GameObjectScript("go_stalactite") { }

    bool OnGossipHello(Player* player, GameObject* go)
    {
        player->CastSpell(go, 68398, false);

        if (Creature* beam = go->FindNearestCreature(40183, 14.0f, true))
            beam->Kill(beam);

        return true;
    }
};

void AddSC_boss_slabhide()
{
    new boss_slabhide();
    new npc_lava_fissure();
    new npc_stalactite();
    new go_stalactite();
}