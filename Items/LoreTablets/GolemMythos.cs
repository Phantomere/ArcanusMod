using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class GolemMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Ancient Machine");
            Tooltip.SetDefault("No. No, no, no!"
                + "\nThe Hero draws closer..."
                + "\nThey will kill me."
                + "\nI did find Sednon however, he is aiding the Hero."
                + "\nThis was only a small surprise."
                + "\nI will continue study of 'it' and hopefully find its useful applications.");
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