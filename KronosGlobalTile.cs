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
            switch (type)
            {
                // Mutant Spore
                case TileID.JunglePlants when Main.rand.NextBool(25):
                    Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("MutantSpore"));
                    break;
                // Shadow Ring
                case TileID.ShadowOrbs:
                    break;
            }

            return true;
        }
    }
}