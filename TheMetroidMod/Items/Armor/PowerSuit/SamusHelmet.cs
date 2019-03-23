using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items.Armor.PowerSuit
{
	[AutoloadEquip(EquipType.Head)]
	public class SamusHelmet : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Power Suit Helmet");
            Tooltip.SetDefault("Armor from the bounty hunter Samus Aran");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("SamusBreastplate") && legs.type == mod.ItemType("SamusBoots");
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Bounty Hunter Increased ranged damage";
			player.rangedDamage *= 1.3f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
    		recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}