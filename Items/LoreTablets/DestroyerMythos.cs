using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class DestroyerMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Worldbreaker");
            Tooltip.SetDefault("I was unable to steal the plans for this machine unfortunately."
                + "\nWhy the Cultists wanted to make this baffles me however. Cthulhu does not require a worm to regrow."
                + "\nMaybe this was for another purpose. I believe the Cultists have found something...unnatural."
                + "\nThe worm is there to harvest it."
                + "\nP.S: I wondered why the brain hadn't been mechanized, but I realized the Hero destroyed it. Brains are hard to recreate.");
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