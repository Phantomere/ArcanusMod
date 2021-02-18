using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class LunaticCultistMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Servant");
            Tooltip.SetDefault("The Hero is tempting fate."
                + "\nDo they know who the Madman serves?"
                + "\nCthulhu himself. A god. A powerful one."
                + "\nI wish them the best of luck in what happens next."
                + "\nFor Cthulhu is not merciful.");
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