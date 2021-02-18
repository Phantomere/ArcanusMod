using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.LoreTablets
{
    public class RetinazerMythos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Red Twin");
            Tooltip.SetDefault("I assumed the upgraded Eye would be more powerful."
                + "\nI spent many hours poring over the plans of the Cultists, improving them."
                + "\nI clearly failed."
                + "\nThe Cultists are frantic after the Eye's plans and corpse were stolen.");
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