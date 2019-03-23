using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.GravitySuit
{
	[AutoloadEquip(EquipType.Head)]
	public class GravitySuitHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Suit that increases mobility");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("GravitySuitBreastplate") && legs.type == mod.ItemType("GravitySuitBoots");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MetroidTooth"), 5);
			recipe.AddIngredient(mod.ItemType("SamusHelmet"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}