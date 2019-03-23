using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.Items
{
	public class MetroidTooth : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A tooth dropped from a Metroid Larva");
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