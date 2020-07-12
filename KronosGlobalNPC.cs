using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos
{
    public class KronosGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.CursedSkull && Main.rand.NextBool(25))
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,
                    mod.ItemType("CursedSkullFragment"));
            }
        }
    }
}