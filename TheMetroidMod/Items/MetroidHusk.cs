using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items
{
	//imported from my tAPI mod because I'm lazy
	public class MetroidHusk : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons an Alpha Metroid");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 9;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player) {
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return !NPC.AnyNPCs(mod.NPCType("AlphaMetroid"));
		}

		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("AlphaMetroid"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}