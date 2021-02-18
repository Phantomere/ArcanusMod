using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.Tools
{
    public class LumberjacksAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lumberjack's Axe");
            Tooltip.SetDefault("It smells faintly of fresh grass"
                + "\nHe loved it so...");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 32;
            item.height = 26;
            item.useTime = 25;
            item.useAnimation = 25;
            item.axe = 40;   //axe power
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
        }
    }
}