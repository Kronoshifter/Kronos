using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos
{
    public class KronosGlobalTile : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            var modPlayer = Main.LocalPlayer.GetModPlayer<KronosPlayer>();
            
            switch (type)
            {
                // Mutant Spore
                case TileID.JunglePlants when Main.rand.NextBool(25):
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("MutantSpore"));
                    break;
                // Shadow Ring & Crimson Amulet
                case TileID.ShadowOrbs:
                    // spawn chance, should preserve normal drops
                    if (Main.rand.NextBool(1, 6))
                    {
                        int itemToSpawn = mod.ItemType(WorldGen.crimson ? "CrimsonAmulet" : "ShadowRing");
                        Item.NewItem(i * 16, j * 16, 16, 16, itemToSpawn);
                        return false;
                    }
                    
                    break;
            }

            return true;
        }
    }
}