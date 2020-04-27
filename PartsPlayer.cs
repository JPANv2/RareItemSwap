
using System;
using System.Collections.Generic;
using System.IO;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Common.UI;
using ARareItemSwapJPANs.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace ARareItemSwapJPANs
{
    public class PartsPlayer : ModPlayer
    {
        public TagCompound parts = new TagCompound();
        public Item destroyingItem = new Item();

        public bool autoDestroy = false;

        public int[] wallCount;

        public bool ZoneRealMarble = false;
        public bool ZoneFakeMarble = false;
        public bool ZoneMarble { 
            get {return ZoneRealMarble ||
                        (ModContent.GetInstance<Config>().useFakeBiomes && ZoneFakeMarble);
                }
        }
        public bool ZoneRealGranite = false;
        public bool ZoneFakeGranite = false;
        public bool ZoneGranite
        {
            get
            {
                return ZoneRealGranite ||
                       (ModContent.GetInstance<Config>().useFakeBiomes && ZoneFakeGranite);
            }
        }

        public bool ZoneRealSpiderCave = false;
        public bool ZoneFakeSpiderCave = false;
        public bool ZoneSpiderCave
        {
            get
            {
                return ZoneRealSpiderCave ||
                      (ModContent.GetInstance<Config>().useFakeBiomes && ZoneFakeSpiderCave);
            }
        }

        public override void ResetEffects()
        {
            base.ResetEffects();
            autoDestroy = false;
        }

        public override void UpdateBiomes()
        {
            base.UpdateBiomes();
            if (Main.netMode != NetmodeID.Server && player.whoAmI == Main.myPlayer) {
                ZoneFakeSpiderCave = Main.screenTileCounts[TileID.Cobweb] > 75;
                ZoneFakeMarble = Main.screenTileCounts[TileID.Marble] > 75;
                ZoneFakeGranite = Main.screenTileCounts[TileID.Granite] > 75;

                updateWallCount();
                ZoneRealSpiderCave = wallCount[WallID.SpiderUnsafe] > 40;
                ZoneRealMarble = wallCount[WallID.MarbleUnsafe] > 40;
                ZoneRealGranite = wallCount[WallID.GraniteUnsafe] > 40;

                if (Main.netMode == NetmodeID.MultiplayerClient)
                {
                    ModPacket pk = mod.GetPacket();
                    pk.Write((byte)1);
                    pk.Write((byte)player.whoAmI);
                    int info = 0;
                    info |= ZoneFakeGranite ? 1 : 0;
                    info |= ZoneRealGranite ? 2 : 0;
                    info |= ZoneFakeMarble ? 4 : 0;
                    info |= ZoneRealMarble ? 8 : 0;
                    info |= ZoneFakeSpiderCave ? 0x10 : 0;
                    info |= ZoneRealSpiderCave ? 0x20 : 0;
                    pk.Write((int)info);
                    pk.Send();
                }
            }
            

        }

        public void updateWallCount()
        {
            wallCount = new int[WallLoader.WallCount];
            int firstTileX = (int)Math.Floor((double)(Main.screenPosition.X / 16f)) - 1;
            int lastTileX = (int)Math.Floor((double)((Main.screenPosition.X + (float)Main.screenWidth) / 16f)) + 2;
            int firstTileY = (int)Math.Floor((double)(Main.screenPosition.Y / 16f)) - 1;
            int lastTileY = (int)Math.Floor((double)((Main.screenPosition.Y + (float)Main.screenHeight) / 16f)) + 2;
            int startX = Utils.Clamp<int>(firstTileX, 5, Main.maxTilesX - 1);
            int endX = Utils.Clamp<int>(lastTileX, 5, Main.maxTilesX - 1);
            int startY = Utils.Clamp<int>(firstTileY, 5, Main.maxTilesY - 1);
            int endY = Utils.Clamp<int>(lastTileY, 5, Main.maxTilesY - 1);
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    wallCount[Main.tile[x, y].wall]++;
                }
            }
        }

        public bool addPart(Item itm)
        {
            string tag = ARareItemSwapJPANs.ItemToTag(itm);
            if (ARareItemSwapJPANs.tokenList.Contains(tag))
            {
                if (!parts.ContainsKey(tag))
                    parts[tag] = (long)(itm.stack);
                else
                    parts[tag] = (long)(parts[tag]) + itm.stack;
                itm.stack = 0;
                if ((long)(parts[tag]) < 0)
                    parts[tag] = Int64.MaxValue;
                return true;
            }
            return false;
        }

        public long getPartAmount(string partTag)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(partTag))
            {
                if (!parts.ContainsKey(partTag))
                    return 0;
                return (long)parts[partTag];
            }
            return -1;
        }

        public long decreasePart(string partTag, long amount = 1, bool exaust = false)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(partTag))
            {
                if (!parts.ContainsKey(partTag))
                    return -amount;
                long total = (long)parts[partTag] - amount;
                if(total >= 0)
                {
                    parts[partTag] = total;
                    return total;
                }
                else
                {
                    if (exaust)
                    {
                        parts[partTag] = 0;
                    }
                    return total;
                }
            }
            return -amount;
        }

        public long increasePart(string partTag, long amount = 1, bool exaust = false)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(partTag))
            {
                if (!parts.ContainsKey(partTag))
                    return -amount;
                long total = (long)parts[partTag] + amount;
                if (total >= 0)
                {
                    parts[partTag] = total;
                    return total;
                }
                else
                {
                    if (exaust)
                    {
                        parts[partTag] = Int64.MaxValue;
                        return Int64.MaxValue;
                    }
                    return -amount;
                }
            }
            return -amount;
        }

        public bool CraftPartRecipe(PartRecipe toCraft)
        {
            bool hasAll = true;
            foreach (Item itm in toCraft.parts)
            {
                if (!parts.ContainsKey(ARareItemSwapJPANs.ItemToTag(itm)))
                {
                    return false;
                }
                if ((long)parts[ARareItemSwapJPANs.ItemToTag(itm)] < itm.stack)
                    hasAll = false;
            }
            if (hasAll)
            {
                foreach (Item itm in toCraft.parts)
                {
                    decreasePart(ARareItemSwapJPANs.ItemToTag(itm), itm.stack);
                }
                return true;
            }
            return false;
        }

        public override bool ShiftClickSlot(Item[] inventory, int context, int slot)
        {
            if (PartExchangeUI.visible && inventory != null && inventory[slot] != null && !inventory[slot].IsAir)
            {
                if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(inventory[slot])))
                {
                    this.addPart(inventory[slot]);
                    inventory[slot].TurnToAir();
                    return true;
                }
                if (PartRecipes.ContainsAsResult(inventory[slot]))
                {
                    List<PartRecipe> target = PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(inventory[slot])];
                    for (int i = 0; i < target.Count; i++)
                    {
                        if (target[i].irreversible || !target[i].isAvailable() || target[i].result.stack > inventory[slot].stack)
                        {
                            target.RemoveAt(i);
                            i--;
                        }
                    }
                    if (target.Count > 0)
                    {
                        PartRecipe pr = target[0];
                        int min = pr.result.stack;
                        for (int i = 1; i < target.Count; i++)
                        {
                            if (min > target[i].result.stack)
                            {
                                min = target[i].result.stack;
                                pr = target[i];
                            }
                        }

                        int stack;
                        int cnt = 0;
                        do
                        {
                            stack = inventory[slot].stack;
                            pr.refund(this, ref inventory[slot]);
                            cnt++;
                        }
                        while (inventory[slot].stack > 0 && stack != inventory[slot].stack);
                    }
                    if (inventory[slot].stack <= 0)
                    {
                        inventory[slot].TurnToAir();
                    }
                }
                return true;
            }
            return false;

        }

        #region save_load_update
        public override TagCompound Save()
        {

            TagCompound s = new TagCompound();
            if (parts == null || parts.Count <= 0)
                return s;
            for (int i = 0; i < ARareItemSwapJPANs.tokenList.Count; i++)
            {
                if (parts.ContainsKey(ARareItemSwapJPANs.tokenList[i]))
                {
                    s[ARareItemSwapJPANs.tokenList[i]] = parts[ARareItemSwapJPANs.tokenList[i]];
                }
            }
            return s;

        }

        public override void Load(TagCompound tag)
        {
            parts = tag;
            if (parts == null)
                parts = new TagCompound();
        }
        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)0);
            packet.Write((byte)player.whoAmI);
            TagIO.Write(parts, packet);
            packet.Send(toWho, fromWho);
        }
        #endregion
    }
}
