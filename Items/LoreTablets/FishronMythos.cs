using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class FishronMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Aquatic Baron");
            Tooltip.SetDefault("A fish? The Hero would waste time with a FISH?!"
                + "\nCthulhu draws closer already. Do they not know?"
                + "\nSednon knows."
                + "\n...But then why does he not speak of it?"
                + "\nI know not, but the Fish was nothing of importance. Perhaps the Hero is distracting me.");
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