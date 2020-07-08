using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos.Items.Accessories
{
    public class NecromancerSkull : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Necromancer Skull");
            Tooltip.SetDefault("Increases your max number of attack, defense, and utility minions by 1\n" +
                               "It's neither demonic, nor does it talk");
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
            player.GetModPlayer<KronosPlayer>().maxAttackMinions += 1;
            player.GetModPlayer<KronosPlayer>().maxDefenseMinions += 1;
            player.GetModPlayer<KronosPlayer>().maxUtilityMinions += 1;
        }
    }
}