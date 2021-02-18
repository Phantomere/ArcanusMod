using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.Accessories
{
    public class LuckyRabbitFoot : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lucky Rabbit's Foot");
            Tooltip.SetDefault("You absolute monster.");
        }
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 10;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            
            player.noFallDmg = true; 
            player.canRocket = true;
            player.rocketTime = 1200;
            player.rocketBoots = 1;
            player.rocketTimeMax = 1200;
            player.aggro += 300;
            player.meleeCrit += 17;
            player.meleeDamage += 0.22f;
            player.meleeSpeed += 0.15f;
            player.moveSpeed += 2.15f;
            player.rangedCrit += 7;
            player.rangedDamage += 0.16f;
            player.maxMinions++;
            player.minionDamage += 0.22f;
            player.statManaMax2 += 60;
            player.manaCost -= 0.15f;
            player.magicCrit += 7;
            player.magicDamage += 1.07f;
        }
    }
}