using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AetherMod.Items.Weapons.Magic
{
    public class IceBolt : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Bolt");
            Tooltip.SetDefault("Is it just me, or is it getting cold...");
        }
        public override void SetDefaults() {
			item.damage = 40;
			item.magic = true;
			item.mana = 14;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.knockBack = 8;
			item.value = Item.sellPrice(silver : 50);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item9;
			item.shoot = ProjectileID.IceBolt;
			item.shootSpeed = 10f;
            item.autoReuse = true;
		}

    }
}
