#include "ScriptedGossip.h"
#include "ScriptMgr.h"
#include "InstanceScript.h"
#include "the_stonecore.h"
#include "Spell.h"

#define GOSSIP_SENDER_STONECORE_PORT 725

class the_stonecore_teleport : public GameObjectScript
{
    public:
        the_stonecore_teleport() : GameObjectScript("the_stonecore_teleport") { }

        bool OnGossipHello(Player* player, GameObject* go)
        {
            player->ADD_GOSSIP_ITEM(GOSSIP_ICON_CHAT, "Teleport to Corborus channel.", GOSSIP_SENDER_STONECORE_PORT, CORBORUS_TELEPORT);
            if (InstanceScript* instance = go->GetInstanceScript())
            {
                if (instance->GetBossState(DATA_CORBORUS) == DONE)
                    player->ADD_GOSSIP_ITEM(GOSSIP_ICON_CHAT, "Teleport to the Corborus room.", GOSSIP_SENDER_STONECORE_PORT, CORBORUS_TELEPORT);
                if (instance->GetBossState(DATA_SLABHIDE) == DONE)
                    player->ADD_GOSSIP_ITEM(GOSSIP_ICON_CHAT, "Teleport to the Slabhide room.", GOSSIP_SENDER_STONECORE_PORT, SLABHIDE_TELEPORT);
                if (instance->GetBossState(DATA_OZRUK) == DONE)
                    player->ADD_GOSSIP_ITEM(GOSSIP_ICON_CHAT, "Teleport to the Ozruk room.", GOSSIP_SENDER_STONECORE_PORT, OZRUK_TELEPORT);
                if (instance->GetBossState(DATA_HIGH_PRIESTESS_AZIL) == DONE)
                    player->ADD_GOSSIP_ITEM(GOSSIP_ICON_CHAT, "Teleport to the High Priestess Azil room.", GOSSIP_SENDER_STONECORE_PORT, HIGHT_PRIESTESS_AZIL_TELEPORT);
            }

            player->SEND_GOSSIP_MENU(player->GetGossipTextId(go), go->GetGUID());
            return true;
        }

        bool OnGossipSelect(Player* player, GameObject* /*go*/, uint32 sender, uint32 action)
        {
            player->PlayerTalkClass->ClearMenus();
            player->CLOSE_GOSSIP_MENU();
            SpellInfo const* spell = sSpellMgr->GetSpellInfo(action);
            if (!spell)
                return false;

            if (player->isInCombat())
            {
                Spell::SendCastResult(player, spell, 0, SPELL_FAILED_AFFECTING_COMBAT);
                return true;
            }

            if (sender == GOSSIP_SENDER_STONECORE_PORT)
                player->CastSpell(player, spell, true);

            return true;
        }
};

void AddSC_the_stonecore_teleport()
{
    new the_stonecore_teleport();
}
