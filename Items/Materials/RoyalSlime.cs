using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos.Items.Materials
{
    public class RoyalSlime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Royal Slime");
            Tooltip.SetDefault("Slimy, yet satisfying.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(silver: 1);
            item.rare = ItemRarityID.Green;
            item.material = true;
        }
    }
}