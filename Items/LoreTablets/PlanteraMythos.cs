using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class PlanteraMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Jungle Incarnate");
            Tooltip.SetDefault("I will repeat. The Hero is growing too powerful."
                + "\nThe machines are trivial, compared to the death of a planetary Force."
                + "\nAlthough...know I may be able to control the Jungle."
                + "\nThe Golem should prove a useful asset."
                + "\nIf the Hero doesn't kill that too."
                + "\nSednon would have stopped them already. I do wonder where he has gone.");
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