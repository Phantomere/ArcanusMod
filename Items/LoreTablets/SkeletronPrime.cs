using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class SkeletronPrimeMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Mechanical Lord");
            Tooltip.SetDefault("The Hero needs to be stopped."
                + "\nKilling the other machines was simple. This however..."
                + "\nThis was a show of higher strength than I could have imagined."
                + "\nI hope the warrior has not discovered me or my plans yet."
                + "\nI believe they will not properly...appreciate them."
                + "\nI will begin hiding my true research now. In case this falls into the wrong hands.");
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