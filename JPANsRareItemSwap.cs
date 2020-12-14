using System;
using System.Collections.Generic;
using System.IO;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Common.Globals;
using ARareItemSwapJPANs.Common.UI;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Recipes;
using ARareItemSwapJPANs.Recipes.ModLoader;
using ARareItemSwapJPANs.Recipes.Thorium;
using ARareItemSwapJPANs.Recipes.Vanilla;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.UI;
using Terraria.Enums;
using Terraria.GameContent.UI;
using System.Reflection;
using ARareItemSwapJPANs.Recipes.CalamityModMusic;
using ARareItemSwapJPANs.Recipes.Calamity;

namespace ARareItemSwapJPANs
{
	public class ARareItemSwapJPANs : Mod
	{
        public static List<string> tokenList = new List<string>();

        public Config mainConfig = ModContent.GetInstance<Config>();

        public UserInterface purchaseUI;

        public PartExchangeUI ui;

        public static bool TEST_MODE = false;

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

        public static int getItemTypeFromTag(string tag)
        {
            int type = 0;
            if (!Int32.TryParse(tag, out type))
            {
                Mod m = ModLoader.GetMod(tag.Split(':')[0]);
                if (m != null)
                    type = m.ItemType(tag.Split(':')[1]);
            }
            if(type == 0 && tag != "0")
            {
                ModLoader.GetMod("ARareItemSwapJPANs").Logger.Warn("Item " + tag + " does not exist.");
            }
            return type;
        }

        public static int getNPCTypeFromTag(string tag)
        {
            int type = 0;
            if (!Int32.TryParse(tag, out type))
            {
                Mod m = ModLoader.GetMod(tag.Split(':')[0]);
                if (m != null)
                    type = m.NPCType(tag.Split(':')[1]);
            }
            return type;
        }

        public override void AddRecipes()
        {
            PartsGlobalNPC.modpacks.Add(new VanillaModPartRepository());

            if(ModLoader.GetMod("ModLoader") != null) //Should always be the case, as tMod is needed to run this
            {
                PartsGlobalNPC.modpacks.Add(new ModLoaderPartRepository());
            }

            if (ModLoader.GetMod("ThoriumMod") != null) 
            {
                PartsGlobalNPC.modpacks.Add(new ThoriumModPartRepository());
            }
            if (ModLoader.GetMod("CalamityMod") != null)
            {
                PartsGlobalNPC.modpacks.Add(new CalamityModPartRepository()); 
            }
            if (ModLoader.GetMod("CalamityModMusic") != null)
            {
                PartsGlobalNPC.modpacks.Add(new CalamityModMusicPartRepository()); ;
            }
            

            foreach (ModPartRepository mpr in PartsGlobalNPC.modpacks)
            {
                mpr.AddRecipes();
            }

        }

        public override void PostAddRecipes()
        {
            addParts();
            if (TEST_MODE)
            {
                makeItemTables();
                makeNPCTables();
            }
        }

        
        public override object Call(params object[] args)
        {
            if (args.Length == 0 || !(args[0] is string) || (((args[0]) as string) == null))
            {
                Logger.Info("Mod call was Empty. This will display, in log, what functions are currently available. All function calls are case-insensitive, but arguments are not.");
                Logger.Info("Player arguments accept the Player object or the Player.whoAmI (position in the Main.player array)");
                Logger.Info("Item arguments take Item objects, ModItem object, the int Type of that item or the Item Tag of the item)");
                Logger.Info("Int values accept int or its string representation");

                Logger.Info("Functions available");
                Logger.Info(" - GetPartList() ");
                Logger.Info("Returns a list of ItemTags of the parts that exist.");
                Logger.Info(" - GetMaxPurchasesAvailable (string... parts) ");
                Logger.Info("Returns a list of items with the stack as the purchase of one of them for all parts whose tags match the given strings, regardless of amount required.");
               /* Logger.Info(" - GetPurchasesWithParts (Item... parts) ");
                Logger.Info("Returns a list of items that can be purchased with the ItemParts you give, with stack being the amount you are willing to spend. Do note this item has to be an Terraria.Item, with the type of the part and stack of what you are willing to spend.");
                Logger.Info(" - PurchasesWithPlayerParts (Player, Item requested,Item... parts) ");
                Logger.Info("Obtains one copy of the requested item by spending from the requested parts. Returns the item asked for or null if there isn't enough parts.");
                Logger.Info(" - PurchasesWithTheseParts (Player, Item requested,Item... parts) ");
                Logger.Info("Obtains one copy of the requested item by subtracting from the given parts items. Returns the item asked for or null if there isn't enough parts.");
                Logger.Info(" - HowManyParts (Player, Item part) ");
                Logger.Info("Returns how many of the requested part does Player have.");
                Logger.Info(" - AddPart (Player, Item part, int amount) ");
                Logger.Info("Adds the given amount of part to given Player.");*/
                return null;
            }

            string function = args[0] as string;

            if (function.ToLower().Equals("getpartlist"))
            {
                List<string> parts = new List<string>();
                parts.AddRange(ARareItemSwapJPANs.tokenList);
                return parts;
            }
            if (function.ToLower().Equals("GetMaxPurchasesAvailable".ToLower()))
            {
                if(args.Length == 1)
                {
                    Logger.Error("Error in ModCall GetMaxPurchasesAvailable Invalid parameter number (string...)");
                    return null;
                }
                List<string> parts = getListOfStringFromObjects(args, 1);
                if(parts.Count == 0)
                {
                    Logger.Error("Error in ModCall GetMaxPurchasesAvailable Invalid parameter number (string...)");
                    return null;
                }
                List<Item> targets = new List<Item>();
                foreach(PartRecipe pr in PartRecipes.allRecipes)
                {
                    bool allParts = true;
                    foreach(Item itm in pr.parts)
                    {
                        allParts = allParts && parts.Contains(ItemToTag(itm));
                    }
                    if (allParts)
                    {
                        targets.Add(pr.result.Clone());
                    }
                }
                return targets;
            }
            if (function.ToLower().Equals("GetMaxPurchasesAvailable".ToLower()))
            {
                if (args.Length == 1)
                {
                    Logger.Error("Error in ModCall GetMaxPurchasesAvailable Invalid parameter number (string...)");
                    return null;
                }
                List<string> parts = getListOfStringFromObjects(args, 1);
                if (parts.Count == 0)
                {
                    Logger.Error("Error in ModCall GetMaxPurchasesAvailable Invalid parameter number (string...)");
                    return null;
                }
                List<Item> targets = new List<Item>();
                foreach (PartRecipe pr in PartRecipes.allRecipes)
                {
                    bool allParts = true;
                    foreach (Item itm in pr.parts)
                    {
                        allParts = allParts && parts.Contains(ItemToTag(itm));
                    }
                    if (allParts)
                    {
                        targets.Add(pr.result.Clone());
                    }
                }
                return targets;
            }
            Logger.Error("Error in ModCall: function \"" + function + "\" does not exist.");
            return null;
        }

        private List<string> getListOfStringFromObjects(object[] args, int v)
        {
            List<string> ans = new List<string>();
            for (int i = v; i < args.Length; i++)
            {
                if (args[i] is List<string>)
                {
                    ans.AddRange((args[i]) as List<string>);
                    continue;
                }
                else if (args[i] is string[])
                {
                    ans.AddRange((args[i]) as string[]);
                    continue;
                }
                else if (args[i] is string)
                {
                    ans.Add((args[i]) as string);
                    continue;
                }
                else
                {

                }
            }
            return ans;
        }

        private int? getIntFromObject(object o)
        {
            if (o == null)
                return null;
            if (o as int? != null)
                return o as int?;
            if (o as string != null)
            {
                int res;
                if (Int32.TryParse(o as string, out res))
                    return res;
            }
            return null;
        }

        private int? getItemTypeFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is string)
                return getItemTypeFromTag(o as string);
            else if (o is Item)
                return (o as Item).type;
            else if (o is ModItem)
                return (o as ModItem).item.type;
            else if (o is int)
                return (int)o;
            return null;
        }

        private Player getPlayerFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is int && ((int)o < 256))
                return Main.player[(int)o];
            if (o is Player)
                return o as Player;
            return null;
        }
    


        public static Item getItemFromTag(string tag, bool noMatCheck = false)
        {
            Item ret = new Item();
            int type = getItemTypeFromTag(tag);
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

        private void makeNPCTables()
        {
            string filename = "NPCs.txt";
            string filename2 = "NPCs Full Info.txt";
            string folder = Path.Combine(Main.SavePath, "Logs");
            string path = Path.Combine(folder, filename);
            string path2 = Path.Combine(folder, filename2);
            FileStream f = File.OpenWrite(path);
            FileStream fAll = File.OpenWrite(path2);

            string modName = "Terraria";
            string totalTablePart = modName + "\n";
            string onlyModTagsPart = modName + "\n";
            f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
            fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
            for (int i = 1; i < NPCLoader.NPCCount; i++)
            {
                NPC npc = new NPC();
                try
                {
                    npc.SetDefaults(i);
                    if (npc.modNPC != null && modName != npc.modNPC.mod.Name)
                    {
                        modName = npc.modNPC.mod.Name;
                        totalTablePart = "\n\n" + modName + "\n\n";
                        onlyModTagsPart = "\n\n" + modName + "\n\n";
                        f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
                        fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
                    }
                    onlyModTagsPart = "\"" + printNPCTag(npc) + "\",\n";
                    totalTablePart = printNPCInfo(npc) + ",\n";
                    f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
                    fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
                }
                catch (Exception e) { }
            }
            Logger.Info("Done; Parsing " + NPCLoader.NPCCount + " npcs");

            f.Close();
            fAll.Close();
        }

        private void makeItemTables()
        {
            string filename = "Items.txt";
            string filename2 = "Items Full Info.txt";
            string folder = Path.Combine(Main.SavePath, "Logs");
            string path = Path.Combine(folder, filename);
            string path2 = Path.Combine(folder, filename2);
            FileStream f = File.OpenWrite(path);
            FileStream fAll = File.OpenWrite(path2);

            List<Item> allItems = new List<Item>();

            bool[] itemsCrafted = new bool[ItemLoader.ItemCount];

            Logger.Info("Parsing " + Main.recipe.Length + " recipes");
            foreach (Recipe r in Main.recipe)
            {
                if (r.createItem != null && r.createItem.type > 0)
                    itemsCrafted[r.createItem.type] = true;
            }
            Logger.Info("Done; Parsing " + ItemLoader.ItemCount + " items");

            foreach (PartRecipe pr in PartRecipes.allRecipes)
            {
                itemsCrafted[pr.result.type] = true;
            }

            for (int i = 1; i < ItemLoader.ItemCount; i++)
            {
                if (!itemsCrafted[i])
                {
                    Item itm = new Item();
                    try
                    {
                        itm.SetDefaults(i);
                        allItems.Add(itm);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            Logger.Info("Done; Parsing " + allItems.Count + " uncraftable items");
            string modName = "Terraria";
            string newTag = "";

            string totalTablePart = modName + "\n";
            string onlyModTagsPart = modName + "\n";
            f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
            fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
            foreach (Item itm in allItems)
            {
                newTag = printItemTag(itm);
                if (itm.modItem != null)
                {
                    if (modName != itm.modItem.mod.Name)
                    {
                        //totalTable += totalTablePart;
                        //onlyModTags += onlyModTagsPart;

                        modName = itm.modItem.mod.Name;
                        totalTablePart = "\n\n" + modName + "\n\n";
                        onlyModTagsPart = "\n\n" + modName + "\n\n";
                        f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
                        fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
                    }
                }
                onlyModTagsPart = "\"" + printItemTag(itm) + "\",\n";
                totalTablePart = printItemInfo(itm) + ",\n";
                f.Write(onlyModTagsPart.ToByteArray(), 0, onlyModTagsPart.ToByteArray().Length);
                fAll.Write(totalTablePart.ToByteArray(), 0, totalTablePart.ToByteArray().Length);
            }

            f.Close();
            fAll.Close();
        }

        private string printItemTag(Item itm)
        {
            if (itm.modItem == null)
                return "" + itm.type;
            return itm.modItem.mod.Name + ":" + itm.modItem.Name;
        }

        private string printItemInfo(Item itm)
        {
            string ans = printItemTag(itm) + "\t";
            ans += "Name: " + itm.Name + "\t";
            ans += "Estimate Category: " + placeCategory(itm) + "\t";
            return ans;
        }

        private string printNPCTag(NPC itm)
        {
            if (itm.modNPC == null)
                return "" + itm.type;
            return itm.modNPC.mod.Name + ":" + itm.modNPC.Name;
        }

        private string printNPCInfo(NPC itm)
        {
            string ans = printNPCTag(itm) + "\t";
            ans += "Name: " + itm.TypeName + "\t";
            ans += "IsBoss: " + itm.boss + "\t";
            return ans;
        }

        private string placeCategory(Item test)
        {
            if (test.maxStack == 1)
            {

                if (test.damage > 0)
                {
                    if (test.melee)
                    {
                        return "Weapons/Melee";
                    }
                    else if (test.ranged)
                    {
                        return "Weapons/Ranged";
                    }
                    else if (test.magic)
                    {
                        return "Weapons/Magic";
                    }
                    else if (test.thrown)
                    {
                        return "Weapons/Thrown";
                    }
                    else if (test.summon)
                    {
                        return "Weapons/Summoner";
                    }
                    else
                    {
                        return "Weapons/Other";
                    }
                }
                else if (test.vanity)
                {
                    if (test.accessory)
                    {
                        if (test.backSlot > 0 || test.wingSlot > 0)
                        {
                            return "Vanity/Accessories/Wings and Capes";
                        }
                        else
                        {
                            return "Vanity/Accessories";
                        }
                    }
                    else if (test.headSlot > 0)
                    {
                        return "Vanity/Armor/Head";
                    }
                    else if (test.bodySlot > 0)
                    {
                        return "Vanity/Armor/Body";

                    }
                    else if (test.legSlot > 0)
                    {
                        return "Vanity/Armor/Legs";

                    }
                    else if (test.mountType > 0)
                    {
                        return "Vanity/Mounts";
                    }
                    else
                    {
                        return "Vanity";
                    }
                }
                else if (test.accessory)
                {

                    if (test.backSlot > 0 || test.wingSlot > 0)
                    {
                        return "Accessories/Wings and Capes";
                    }
                    else
                    {
                        return "Accessories";
                    }

                }
                else if (test.headSlot > 0)
                {
                    return "Armor/Head";

                }
                else if (test.bodySlot > 0)
                {
                    return "Armor/Body";

                }
                else if (test.legSlot > 0)
                {
                    return "Armor/Legs";
                }
                else if (test.mountType > 0)
                {
                    if (MountID.Sets.Cart[test.mountType])
                    {
                        return "Minecarts";
                    }
                    else
                    {
                        return "Mounts";
                    }

                }
                else if (Main.projHook[test.shoot])
                {
                    return "Hooks";
                }
                else if (test.buffType > 0 && Main.vanityPet[test.buffType] && !Main.lightPet[test.buffType])
                {
                    return "Pets/Normal Pets";
                }
                else if (test.buffType > 0 && Main.lightPet[test.buffType])
                {
                    return "Pets/Light Pets";
                }
            }
            else if (test.rare == -11)
            {

                return "Quest Items";
            }
            else if ((test.type >= ItemID.CopperCoin && test.type <= ItemID.PlatinumCoin) || isCustomCurrency(test))
            {
                return "Currency";
            }
            else if (test.createWall >= 0)
            {
                return "Walls";
            }
            else if (test.createTile >= 0)
            {

                TileObjectData placer = TileObjectData.GetTileData(test.createTile, test.placeStyle, 0);
                if (placer != null && (placer.Width > 1 || placer.Height > 1))
                {
                    if (test.Name.EndsWith(" Crate"))
                    {
                        return "Crates";
                    }
                    else
                    {
                        return "Furniture";
                    }
                }
                else if (placer != null && placer.AnchorBottom != null && placer.AnchorBottom.type == AnchorType.Table)
                {
                    return "Furniture";
                }
                else if (TileID.Sets.Platforms[test.createTile])
                {
                    return "Platforms";
                }
                else
                {

                    return "Tiles";
                }
            }
            else
            {
                if (test.consumable)
                {
                    return "Consumable? ";
                }
                if (test.material)
                {
                    return "Materials?";
                }

            }
            return "N/A";
        }
        private static bool isCustomCurrency(Item test)
        {
            if (test.type == ItemID.DefenderMedal)
                return true;
            Type type = typeof(CustomCurrencyManager);
            FieldInfo info = type.GetField("_currencies", BindingFlags.NonPublic | BindingFlags.Static);
            object value = info.GetValue(null);
            Dictionary<int, CustomCurrencySystem> currencies = value as Dictionary<int, CustomCurrencySystem>;
            if (currencies != null)
            {
                foreach (CustomCurrencySystem ccs in currencies.Values)
                {
                    if (ccs.Accepts(test))
                        return true;
                }
            }
            return false;
        }
    }
}

