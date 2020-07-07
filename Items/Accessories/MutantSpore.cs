using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos.Items.Accessories
{
    public class MutantSpore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Composed of matter, anti-matter, and it doesn't matter");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = ItemRarityID.Orange;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
            
        }
    }
}