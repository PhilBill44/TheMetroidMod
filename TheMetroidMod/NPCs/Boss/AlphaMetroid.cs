using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMetroidMod.NPCs.Boss
{
	[AutoloadBossHead]
	public class AlphaMetroid : ModNPC
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Alpha Metroid");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 14;
			npc.width = 65;
			npc.height = 57;
			npc.damage = 15;
			npc.defense = 12;
			npc.lifeMax = 1400;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.knockBackResist = 0f;
			npc.noTileCollide = false;
			npc.noGravity = true;
			npc.boss = true;
			music = mod.GetSoundSlot(Terraria.ModLoader.SoundType.Music, "Sounds/Music/Alpha");
			npc.buffImmune[24] = true;
			npc.buffImmune[67] = true;
			npc.lavaImmune = true;
		}

		#region Settings AI
		const int ShootType = 467;
		const int ShootDamage = 40;
		const float ShootKnockback = 0.8554f;
		const int ShootCount = 5;
		const int ShootSpeed = 3;
		const int ShootDirection = 7;
		const float Speed = 100f;
		const float Acceleration = 1.1f;
		int Timer;
		#endregion

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("MissileLauncher"));
		}

		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.15f;
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int Frame = (int)npc.frameCounter;
			npc.frame.Y = Frame * frameHeight;
		}

		public override void AI()
		{
			npc.TargetClosest(true);
			npc.spriteDirection = npc.direction;
			Player player = Main.player[npc.target];
			if (player.dead || !player.active)
			{
				npc.TargetClosest(false);
				npc.active = false;
			}

			if (Main.netMode != 1 && Main.rand.Next(125) == 0)
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType<InfantMetroid>());
		}
	}
}