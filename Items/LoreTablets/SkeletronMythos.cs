using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class SkeletronMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Dungeon Lord");
            Tooltip.SetDefault("I ran into this being on my ventures to find Sednon's old sword."
                + "\nAs with the Queen, I thought this controlled the dungeon. When it was killed...I knew I was right this time."
                + "\nI did find the sword, though. Muramasa by itself is weak however, so I left it. I will retrieve it later.");
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