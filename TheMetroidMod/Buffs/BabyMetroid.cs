using Terraria;
using Terraria.ModLoader;

namespace TheMetroidMod.Buffs
{
	public class BabyMetroid : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Baby Metroid");
			Description.SetDefault("A Baby Metroid follows you");
			// DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
			// DisplayName.SetDefault("Paper Airplane");
			// Description.SetDefault("\"Let this pet be an example to you!\"");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<ExamplePlayer>().BabyMetroid = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("BabyMetroid")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("BabyMetroid"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}