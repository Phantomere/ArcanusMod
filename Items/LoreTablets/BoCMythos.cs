using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class BoCMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Brain");
            Tooltip.SetDefault("The simple fact that Cthulhu has survived after his brain was removed is quite remarkable."
                + "\nPerhaps it is due to his godly nature, or just because of his power."
                + "\nThe brain was not so impressing either. It was unable to defend itself very well."
                + "\nI assume the Cultists will be enraged however...the brain was easier to rebuild while it was alive.");
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