using System;
using System.Collections.Generic;
using System.IO;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Common.Globals;
using ARareItemSwapJPANs.Common.UI;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Recipes;
using ARareItemSwapJPANs.Recipes.Vanilla;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.UI;

namespace ARareItemSwapJPANs
{
	public class ARareItemSwapJPANs : Mod
	{
        public static List<string> tokenList = new List<string>();

        public Config mainConfig = ModContent.GetInstance<Config>();

        public UserInterface purchaseUI;

        public PartExchangeUI ui;

		public ARareItemSwapJPANs()
		{

        }

        public override void Load()
        {
            base.Load();
            if (!Main.dedServ)
            {
                purchaseUI = new UserInterface();
                ui = new PartExchangeUI();
                ui.Activate();
                purchaseUI.SetState(ui);
            }
        }

        public override void UpdateUI(GameTime gameTime)
        {
            base.UpdateUI(gameTime);
            if(purchaseUI?.CurrentState != null)
            {
                if (PartExchangeUI.visible)
                {
                    purchaseUI.Update(gameTime);
                }
            }
        }


        public void ActivatePurchaseUI(int player)
        {
            if (player == Main.myPlayer && Main.netMode != NetmodeID.Server)
            {
                ui?.setVisible(true);
                Main.playerInventory = true;
                Main.recBigList = false;
                tokenList.Sort();
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int index = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
            if (index != -1)
            {
                layers.Insert(index, new LegacyGameInterfaceLayer(
                    "ARareItemSwapJPANs: PurchaseUI",
                    delegate
                    {
                        if (!Main.playerInventory)
                            PartExchangeUI.visible = false;

                        if (PartExchangeUI.visible){
                          //  purchaseUI.Update(Main._drawInterfaceGameTime);
                            ui.Draw(Main.spriteBatch);
                        }
                        return true;
                    },
                       InterfaceScaleType.UI));
            }
        }

        internal static Player findNearestPlayer(Vector2 center)
        {
            Player res = null;
            for(int i = 0; i< Main.player.Length; i++)
            {
                if (Main.player[i] != null && Main.player[i].active && !Main.player[i].dead)
                {
                    if (res == null)
                        res = Main.player[i];
                    else
                    {
                        if (Vector2.DistanceSquared(Main.player[i].Center, center) < Vector2.DistanceSquared(res.Center, center))
                        {
                            res = Main.player[i];
                        }
                    }
                }
            }
            return res;
        }

        public static int getTypeFromTag(string tag)
        {
            int type = 0;
            if (!Int32.TryParse(tag, out type))
            {
                Mod m = ModLoader.GetMod(tag.Split(':')[0]);
                if (m != null)
                    type = m.ItemType(tag.Split(':')[1]);
            }
            return type;
        }

        public override void AddRecipes()
        {
            PartsGlobalNPC.modpacks.Add(new VanillaModPartRepository());

            foreach (ModPartRepository mpr in PartsGlobalNPC.modpacks)
            {
                mpr.AddRecipes();
            }

        }

        public override void PostAddRecipes()
        {
            addParts();
        }

        public static Item getItemFromTag(string tag, bool noMatCheck = false)
        {
            Item ret = new Item();
            int type = getTypeFromTag(tag);
            if (type != 0)
                ret.SetDefaults(type, noMatCheck);
            return ret;
        }

        public static string ItemToTag(Item itm)
        {
            String type = "" + itm.type;
            if (itm.modItem != null)
            {
                type = itm.modItem.mod.Name + ":" + itm.modItem.Name;
            }

            return type;
        }
        public static string ItemIDToTag(int id)
        {
            Item itm = new Item();
            itm.SetDefaults(id, true);
            return ItemToTag(itm);
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            int messageID = reader.ReadByte();
            if(messageID == 0)
            {
                int player = reader.ReadByte();
                if(Main.netMode == NetmodeID.Server || player != Main.myPlayer)
                {
                    Main.player[player].GetModPlayer<PartsPlayer>().parts = TagIO.Read(reader);
                    return;
                }
            }
            if (messageID == 1)
            {
                int player = reader.ReadByte();
                int info = reader.ReadInt32();
                if (Main.netMode == NetmodeID.Server || player != Main.myPlayer)
                {
                    PartsPlayer pl = Main.player[player].GetModPlayer<PartsPlayer>();
                    pl.ZoneFakeGranite = ((info & 0x1) != 0);
                    pl.ZoneRealGranite = ((info & 0x2) != 0);
                    pl.ZoneFakeMarble = ((info & 0x4) != 0);
                    pl.ZoneRealMarble = ((info & 0x8) != 0);
                    pl.ZoneFakeSpiderCave = ((info & 0x10) != 0);
                    pl.ZoneRealSpiderCave = ((info & 0x20) != 0);
                }
            }
        }

        public void addParts()
        {
        }
        public void ExchangeUISelectRecipe(PartRecipe recipe)
        {
            if(ui != null && PartExchangeUI.visible)
            {
                ui.setSelectedRecipe(recipe);
            }
        }


        public bool DestroyPlayerItemForParts(Item itm)
        {
            PartsPlayer p = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>();
            if (tokenList.Contains(ItemToTag(itm)))
            {
                p.addPart(itm);
                p.destroyingItem = ui.destroySlot.item = new Item();
                return true;
            }
            else if(ui.selectedRecipe != null)
            {
                ui.selectedRecipe.refund(p, ref p.destroyingItem);
                if(p.destroyingItem.stack <= 0)
                    p.destroyingItem = ui.destroySlot.item = new Item();
                return true;
            }
            return false;
        }
    }
}
