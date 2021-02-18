using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class EoWMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Ceaseless Hunger");
            Tooltip.SetDefault("This one was...dissapointing. I attempted to create a worm capable of destroying Sednon."
                + "\nIt clearly didn't work. If that wretched so-called hero can kill it, the worm is worthless."
                + "\nPerhaps it can be upgraded...");
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