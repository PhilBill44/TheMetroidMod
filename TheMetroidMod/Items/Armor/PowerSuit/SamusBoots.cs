using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.PowerSuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class SamusBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Power Suit Boots");
            Tooltip.SetDefault("Armor from the bounty hunter Samus Aran");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
    		recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}﻿