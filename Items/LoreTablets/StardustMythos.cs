using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class StardustMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Light");
            Tooltip.SetDefault("Hm. Interesting. "
                + "\nStardust...I have studied this material before."
                + "\nIt is the essence of the stars. The essence of light.");
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