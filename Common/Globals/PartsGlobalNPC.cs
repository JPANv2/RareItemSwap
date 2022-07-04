using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Recipes;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Common.Globals
{
    public class PartsGlobalNPC: GlobalNPC
    {
        public static Dictionary<int, List<Item>> npcParts = new Dictionary<int, List<Item>>();
        public static List<ModPartRepository> modpacks = new List<ModPartRepository>();

        public static void Clear()
        {
            npcParts.Clear();
            modpacks.Clear();
        }
        public override void NPCLoot(Terraria.NPC npc)
        {
            base.NPCLoot(npc);
            dropBossParts(npc);
            if (npc.value > 1)
            {
                dropSeasonalParts(npc);
                dropWeatherParts(npc);
                dropEventParts(npc);
                dropBiomeParts(npc);
                dropStageParts(npc);
                dropShopParts(npc);
            }
        }

        private void dropShopParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            Player p = ARareItemSwapJPANs.findNearestPlayer(npc.Center);
            if (Main.rand.NextDouble() < c.shopPartDropChance)
            {
                if(npc.value < 500)
                {
                    int parts = Main.rand.Next(1, (int)(npc.value / 5)+1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<MinorShopPart>(), parts, false, 0, false, false);
                }else if (npc.value < 50000)
                {
                    int parts = Main.rand.Next(1, (int)(npc.value / 500) + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ShopPart>(), parts, false, 0, false, false);
                }
                else if (npc.value >= 50000)
                {
                    int parts = Main.rand.Next(1, (int)(npc.value / 50000) + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<MajorShopPart>(), parts, false, 0, false, false);
                }
            }
        }

        private void dropSeasonalParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            if (Main.halloween && Main.rand.NextDouble() < c.partDropChance)
            {
                int parts = c.minParts + Main.rand.Next(c.randParts + 1);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GoodieBagPart>() , parts, false, 0, false, false);
            }
            if (Main.xMas && Main.rand.NextDouble() < c.partDropChance)
            {
                int parts = c.minParts + Main.rand.Next(c.randParts + 1);
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PresentPart>(), parts, false, 0, false, false);
            }
        }

        private void dropBiomeParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            Player p = ARareItemSwapJPANs.findNearestPlayer(npc.Center);
            List<int> parts = new List<int>();
            foreach (ModPartRepository mpr in modpacks)
            {
                foreach(int i in mpr.getBiomePartsDrops(npc,p, parts))
                {
                    if (!parts.Contains(i))
                        parts.Add(i);
                }
            }
            if (Main.rand.NextDouble() < c.partDropChance)
            {
                for (int i = 0; i < c.maxDifferentParts && parts.Count > 0; i++)
                {
                    int idx = Main.rand.Next(parts.Count);
                    int prts = c.minParts + Main.rand.Next(c.randParts + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, parts[idx], prts, false, 0, false, false);
                    parts.RemoveAt(idx);
                }
            }
        }

        private void dropEventParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            Player p = ARareItemSwapJPANs.findNearestPlayer(npc.Center);
            List<int> parts = new List<int>();
            foreach (ModPartRepository mpr in modpacks)
            {
                foreach (int i in mpr.getEventPartsDrops(npc, p, parts))
                {
                    if (!parts.Contains(i))
                        parts.Add(i);
                }
            }
            if (Main.rand.NextDouble() < c.partDropChance)
            {
                for (int i = 0; i < c.maxDifferentParts && parts.Count > 0; i++)
                {
                    int idx = Main.rand.Next(parts.Count);
                    int prts = c.minParts + Main.rand.Next(c.randParts + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, parts[idx], prts, false, 0, false, false);
                    parts.RemoveAt(idx);
                }
            }
        }

        private void dropWeatherParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            Player p = ARareItemSwapJPANs.findNearestPlayer(npc.Center);
            List<int> parts = new List<int>();
            foreach (ModPartRepository mpr in modpacks)
            {
                foreach (int i in mpr.getWeatherPartsDrops(npc, p, parts))
                {
                    if (!parts.Contains(i))
                        parts.Add(i);
                }
            }
            if (Main.rand.NextDouble() < c.partDropChance)
            {
                for (int i = 0; i < c.maxDifferentParts && parts.Count > 0; i++)
                {
                    int idx = Main.rand.Next(parts.Count);
                    int prts = c.minParts + Main.rand.Next(c.randParts + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, parts[idx], prts, false, 0, false, false);
                    parts.RemoveAt(idx);
                }
            }
        }

        private void dropStageParts(Terraria.NPC npc)
        {
            Config c = ModContent.GetInstance<Config>();
            Player p = ARareItemSwapJPANs.findNearestPlayer(npc.Center);
            List<int> parts = new List<int>();
            foreach (ModPartRepository mpr in modpacks)
            {
                foreach (int i in mpr.getStagePartsDrops(npc, p, parts))
                {
                    if (!parts.Contains(i))
                        parts.Add(i);
                }
            }
            if (Main.rand.NextDouble() < c.partDropChance)
            {
                for (int i = 0; i < c.maxDifferentParts && parts.Count > 0; i++)
                {
                    int idx = Main.rand.Next(parts.Count);
                    int prts = c.minParts + Main.rand.Next(c.randParts + 1);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, parts[idx], prts, false, 0, false, false);
                    parts.RemoveAt(idx);
                }
            }
        }

        private void dropBossParts(Terraria.NPC npc)
        {
            if (npcParts.ContainsKey(npc.type))
            {
                foreach(Item part in npcParts[npc.type]) {
                    if (npc.boss ||
                      (npc.type != 13 && npc.type != 14 && npc.type != 15))
                    {
                        Config c = ModContent.GetInstance<Config>();
                        int parts = c.minNumOfBossParts + Main.rand.Next(c.randNumOfBossParts + 1);
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, part.type, parts, false, 0, false, false);
                    }
                }
            }
        }

        public static void addPartToNPC(int npcType, Item part)
        {
            if (!npcParts.ContainsKey(npcType))
                npcParts[npcType] = new List<Item>();
            npcParts[npcType].Add(part);
        }

        public static void addPartToNPC(int npcType, ItemPart part)
        {
            addPartToNPC(npcType, part.item);
        }
    }
}
