using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items
{
	public class CoreX : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The core of the X Parasites");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}
	}
}