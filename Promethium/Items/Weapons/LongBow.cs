﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Promethium.Items.Weapons
{
    public class LongBow : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Long Bow";
            item.width = 20;
            item.height = 58;
            item.damage = 32;
            item.knockBack = 3;
            item.channel = true;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;
            item.useTime = 10;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.value = Item.buyPrice(0, 2);
            item.rare = 5;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.toolTip = "";
            item.shoot = mod.ProjectileType<Projectiles.Items.LongBow>();
            item.shootSpeed = 7;
        }

        public override bool ConsumeAmmo(Player player) { return false; }

        public override bool Shoot(Player plr, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = item.shoot;
            return base.Shoot(plr, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}

