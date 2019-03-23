using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/blushiemagic/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class InfantMetroid : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Infant Metroid");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults() {
			npc.width = 28;
			npc.height = 28;
			npc.damage = 10;
			npc.defense = 0;
			npc.lifeMax = 5;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 44;
			aiType = NPCID.Harpy;
			animationType = NPCID.DemonEye;
		}
	}
}