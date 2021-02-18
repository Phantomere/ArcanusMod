using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class QueenBeeMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Hive Monarch");
            Tooltip.SetDefault("Sednon's betrayal has led me to an old enemy. The...insect... is large and powerful."
                + "\nI believed that by controlling her, I could control the Jungle. I was wrong."
                + "\nSomething darker lurks beneath the surface...I feel it's wrath, and it's anger."
                + "\nAnd now I know...IT controls the Jungle.");
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