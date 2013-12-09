#ifndef DEF_THE_STONECORE_H
#define DEF_THE_STONECORE_H

enum Data
{
    DATA_CORBORUS_EVENT,
    DATA_SLABHIDE_EVENT,
    DATA_OZRUK_EVENT,
    DATA_HIGH_PRIESTESS_AZIL_EVENT,
    DATA_TEAM_IN_INSTANCE,
};

enum Data64
{
    DATA_CORBORUS,
    DATA_SLABHIDE,
    DATA_OZRUK,
    DATA_HIGH_PRIESTESS_AZIL,
};

enum NpcData
{
    // Corborus
    DATA_ROCK_BORER,
    DATA_CRYSTAL_SHARDS,
    DATA_SEISMIC_SHARDS,
    DATA_GRAVITY_WELL,
    DATA_LAVA_FISSURE,
    DATA_STALACTITE,
    DATA_SEISMIC_SHARD,
    DATA_THRASHING_CHARGE,
};

enum TeleporterSpells
{
    CORBORUS_TELEPORT              = 70781,
    SLABHIDE_TELEPORT              = 70856,
    OZRUK_TELEPORT                 = 70857,
    HIGHT_PRIESTESS_AZIL_TELEPORT  = 70858,
};

enum CreatureIds
{
    // Dungeon Bosses

    BOSS_CORBORUS                  = 43438,
    BOSS_SLABHIDE                  = 43214,
    BOSS_OZRUK                     = 42188,
    BOSS_HIGH_PRIESTESS_AZIL       = 42333,

    // Trash mobs

    NPC_CRYSTALSPAWN_GIANT         = 42810,
    NPC_IMP                        = 43014,
    NPC_MILLHOUSE_MANASTORM        = 43391,
    NPC_ROCK_BORER                 = 43917,
    NPC_ROCK_BORER2                = 42845,
    NPC_CRYSTAL_SHARD              = 49267,
    NPC_STONECORE_BERSERKER        = 43430,
    NPC_STONECORE_BRUISER          = 42692,
    NPC_STONECORE_EARTHSHAPER      = 43537,
    NPC_STONECORE_FLAYER           = 42808,
    NPC_MAGMALORD                  = 42789,
    NPC_RIFT_CONJURER              = 42691,
    NPC_STONECORE_SENTRY           = 42695,
    NPC_STONECORE_WARBRINGER       = 42696,
    NPC_STALACTITE_TRIGGER         = 43159,
    NPC_STALACTITE_BOSS            = 43357,
    NPC_LAVA_FISSURE               = 43242,
    NPC_GRAVITY_WELL               = 42499,
    NPC_SEISMIC_SHARD              = 42355,
    NPC_SEISMIC_SHARD_TRIGGER      = 44824,
    NPC_DEVOUT_FOLLOWER            = 42428,

    // Various NPCs

    NPC_EARTHWARDEN_YRSA           = 50048,
    NPC_STONECORE_TELEPORTER1      = 51396,
    NPC_STONECORE_TELEPORTER2      = 51397,
    NPC_TRASHING_CHARGE            = 43743,
};

enum GameObjectIds
{
    GO_BROKEN_PILLAR               = 207407,
    GO_TWILIGHT_DOCUMENTS          = 207415,
};

#endif