using Terraria.ModLoader;

namespace Kronos
{
    public class KronosPlayer : ModPlayer
    {
        public int maxAttackMinions;
        public int maxDefenseMinions;
        public int maxUtilityMinions;

        public override void ResetEffects()
        {
            maxAttackMinions = 0;
            maxDefenseMinions = 0;
            maxUtilityMinions = 0;
        }
    }
}