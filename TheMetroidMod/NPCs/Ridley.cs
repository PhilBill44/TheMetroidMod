using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace TheMetroidMod.NPCs
{
	public class Ridley : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ridley");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 200;
			npc.damage = 20;
			npc.defense = 14;
			npc.knockBackResist = 0.3f;
			npc.width = 66;
			npc.height = 58;
			animationType = 62;
			npc.aiStyle = 14;
			npc.npcSlots = 15f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 2, 50);
		}

		public override void NPCLoot()
		{
		if (Main.rand.NextFloat() < .75f) // 13.23% chance
			Item.NewItem(npc.getRect(), mod.ItemType("Phazon"), 4);
		}

			  public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode == true)
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0.4f;
            }
            else return 0f;
        }
	}
}