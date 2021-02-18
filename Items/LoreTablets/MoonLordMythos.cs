using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class MoonLordMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Master");
            Tooltip.SetDefault("..."
                + "\nI am speechless."
                + "\nPrehistoric Machines, The Jungle Itself, and the Guardian are one thing..."
                + "\nA god though?"
                + "\nWhat has happened to Sednon? Surely, he must have tried to stop this.");
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