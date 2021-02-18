using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class SolarMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heat");
            Tooltip.SetDefault("Congratulations."
                + "\nYou no longer have to face those infernal Crawltipedes."
                + "\nYou still have to face Him though.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 26;
            item.useTime = 25;
            item.useAnimation = 25;
            item.value = 10000;
            item.rare = 2;
        }
    }
}