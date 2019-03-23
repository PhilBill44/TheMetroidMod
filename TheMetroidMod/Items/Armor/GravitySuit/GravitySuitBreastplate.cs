using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.GravitySuit
{
    [AutoloadEquip(EquipType.Body)]
    public class GravitySuitBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gravity Suit Breastplate");
            Tooltip.SetDefault("Suit that increases mobility");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MetroidTooth"), 5);
			recipe.AddIngredient(mod.ItemType("SamusBreastplate"), 1);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}﻿