using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos.Items.Accessories
{
    public class MutantSpore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mutant Spore");
            Tooltip.SetDefault("Increases your max number of minions by 1\n" +
                               "Composed of matter, antimatter, and it doesn't matter");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.value = 100;
            item.rare = ItemRarityID.Orange;
            item.accessory = true;
            item.scale = 0.85f;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
        }
    }
}