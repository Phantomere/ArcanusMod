using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class VortexMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void");
            Tooltip.SetDefault("The Void takes away."
                + "\nI have dubbed this vortex energy as Void. This is because of the way it acts as a small singularity."
                + "\nThe Fragments draw in light and energy from around them. I believe that Cthulhu uses this energy more than the others.");
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