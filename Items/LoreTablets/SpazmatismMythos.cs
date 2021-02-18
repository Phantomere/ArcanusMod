using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class SpazmatismMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Green Twin");
            Tooltip.SetDefault("I was sure the cursed flames would have worked."
                + "\nClearly not. I cloned the eye and used one as a ranged menace, and the other as a flaming behemoth."
                + "\nThe Hero has bested me once again."
                + "\nI think however, that Cthulhu will perhaps return. I have felt the rumblings."
                + "\nThe Cultists think he needs rebuilding...but I believe he is already healing...");
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