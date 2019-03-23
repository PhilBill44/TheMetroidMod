﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.FusionSuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class FusionSuitBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fusion Suit Boots");
            Tooltip.SetDefault("X Parasite infected suit");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
    		recipe.AddIngredient(mod.ItemType("CoreX"), 5);
			recipe.AddIngredient(mod.ItemType("SamusBoots"), 1);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}﻿