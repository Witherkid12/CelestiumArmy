using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Items
{
	public class ModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(5) == 0)
			{
				if (npc.type == NPCID.Harpy)
{
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulOfHeight"));
}
				}
		if (Main.rand.Next(3) == 0)
		{
if (npc.type == NPCID.DungeonGuardian)
{
Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SupremeTeam"));
}	
		}
	}
}}