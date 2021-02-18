using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class KingSlimeMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Blob");
            Tooltip.SetDefault("Nothing more than a failed expiriment. Although, it did steal Sednon's armor."
                + "\nProbably ruined the armor, if it didn't just dissolve it."
                + "\nSome of the natural habitants of the land have been drawn to it. Small gel blobs, drawn to a larger one. Fascinating..."
                + "\nMaybe I will study this thing more.");
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