using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class WoFMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Guardian");
            Tooltip.SetDefault("Perhaps the Hero does not know what they have done."
                + "\nThe Great Flesh was our Guardian. It balanced and contained the light and the dark."
                + "\nNow it is dead."
                + "\nThis is wonderful news to me, however, as I wondered what secrets were hidden within this world."
                + "\nThank you, Hero. You did something I never could.");
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