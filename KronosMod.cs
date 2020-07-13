using Kronos.Items.Materials;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kronos
{
    public class KronosMod : Mod
    {
        public override void AddRecipes()
        {
            // Slime Staff
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.GetInstance<RoyalSlime>(), 15);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeStaff);
            recipe.AddRecipe();
        }
    }
}