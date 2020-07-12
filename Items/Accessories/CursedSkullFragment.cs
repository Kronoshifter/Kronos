using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos.Items.Accessories
{
    public class CursedSkullFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Skull Fragment\n" +
                                   "You should know better than to pick up cursed things in a dungeon!");
            Tooltip.SetDefault("Increases your max number of utility minions by 1");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(gold: 1);
            item.rare = ItemRarityID.Orange;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<KronosPlayer>().maxUtilityMinions += 1;
        }
    }
}