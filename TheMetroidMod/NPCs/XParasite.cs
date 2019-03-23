using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.NPCs
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/blushiemagic/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class XParasite : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("XParasite");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 2;
			aiType = NPCID.Harpy;
			animationType = NPCID.DemonEye;
			banner = Item.NPCtoBanner(NPCID.Harpy);
			bannerItem = Item.BannerToItem(banner);
		}

		
		public override void NPCLoot()
		{
		if (Main.rand.NextFloat() < .70f) // chance
			Item.NewItem(npc.getRect(), mod.ItemType("CoreX"),1);
		}

		  public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss1 == true)
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0.4f;
            }
            else return 0f;
        }
	}
}