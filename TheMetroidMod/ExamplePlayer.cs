using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;
namespace TheMetroidMod
{
	public class ExamplePlayer : ModPlayer
	{
		private const int saveVersion = 0;
		public bool BabyMetroid = false;

		public override void ResetEffects()
		{
		BabyMetroid = false;
		}
	}
}