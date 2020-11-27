using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.player[Main.myPlayer].ZoneRockLayerHeight || Main.player[Main.myPlayer].ZoneDirtLayerHeight)
            {
                if (Main.rand.Next(2000) == 0)
                {
                    if (npc.type <= 1000)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, this.mod.ItemType("AncientSword"), 1);
                    }
                }
                if (Main.rand.Next(2000) == 0)
                {
                    if (npc.type <= 1000)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, this.mod.ItemType("RustySpoon"), 1);
                    }
                }
            }
        }
    }
}