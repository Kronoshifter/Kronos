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
            // Mutant Spore
            if (type == TileID.JunglePlants && Main.rand.NextBool(25))
            {
                Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("MutantSpore"));
            }

            return true;
        }
    }
}