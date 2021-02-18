using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class NebulaMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Energy");
            Tooltip.SetDefault("I enjoyed my experiments with the Nebula."
                + "\nIt's effects on the mind are...interesting."
                + "\nOne of my test subjects ate one of my Fragments and now glows a shade of pink.");
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