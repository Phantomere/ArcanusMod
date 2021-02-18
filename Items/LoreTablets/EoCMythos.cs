using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class EoCMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Everwatcher");
            Tooltip.SetDefault("Hmm...so weak compared to the others, yet, it posseses some talent over optics."
                + "\nDefeating it is no large challenge however. It was merely flesh. This does not impress me."
                + "\nI shall attempt to strengthen it.");
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