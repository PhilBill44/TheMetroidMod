using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.FusionSuit
{
	[AutoloadEquip(EquipType.Head)]
	public class FusionSuitHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("X Parasite infected suit");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("SamusBreastplate") && legs.type == mod.ItemType("SamusBoots");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CoreX"), 5);
			recipe.AddIngredient(mod.ItemType("SamusHelmet"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}