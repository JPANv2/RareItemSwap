using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Components;
using ARareItemSwapJPANs.Common.UI.Elements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.UI.Elements;
using Terraria.UI;
using FixedUIScrollbar = Terraria.GameContent.UI.Elements.FixedUIScrollbar;

namespace ARareItemSwapJPANs.Common.UI
{

    public class RecipePanel : UIPanel
    {
        public UIGrid internalGrid;
        public UIScrollbar scrollbar;

        public PartExchangeUI parent;
        private PathTreePanel changer;
        public PathTree selected = null;
        public Item selectedItem = null;

        public int count = 0;
        public bool hasChanges = false;
        UIText loading = new UIText("Loading...");
        Task t = null;
        string search = "";
        public string mouseTooltip = "";
        public bool tooltipSearch = false;
        public bool isSearching = false;

        public bool invalidatedList = false;
        public bool changedToList = false;

        public static int orderByName(string x, string y) => ARareItemSwapJPANs.getItemFromTag(x).Name.CompareTo(ARareItemSwapJPANs.getItemFromTag(y).Name);
        
        
        public static int orderByID(string x, string y) => ARareItemSwapJPANs.getItemFromTag(x).type.CompareTo(ARareItemSwapJPANs.getItemFromTag(y).type);

        public RecipePanel(PartExchangeUI panel)
        {
            parent = panel;
            changer = panel.categories;
            selected = changer.selected;
            hasChanges = true;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            BackgroundColor = Color.Blue;
            BorderColor = Color.White;
            internalGrid = new UIGrid();
            internalGrid.OnScrollWheel += PartExchangeUI.onScrollWheel;
            //scrollbar = new UIScrollbar();
            scrollbar = new InvisibleScrollbar();
            Append(internalGrid);
            scrollbar.SetView(100f, 1000f);
            scrollbar.Height.Set(0, 1f);
            scrollbar.Width.Set(1, 0);
            scrollbar.Left.Set(-14, 1f);
            Append(scrollbar);
            internalGrid.SetScrollbar(scrollbar);
            
            //Append(internalGrid);
            hasChanges = true;
        }

        public override void Update(GameTime gameTime)
        {
            if (tooltipSearch != parent.tooltipSearch.doSearch)
            {
                tooltipSearch = parent.tooltipSearch.doSearch;
                invalidatedList = true;
                changedToList = true;
            }

            if (selected != changer.selected || selectedItem != parent.destroySlot.item || !parent.search.GetText().Equals(search) || invalidatedList)
            {
                if (t == null)
                {
                    selected = changer.selected;
                    selectedItem = parent.destroySlot.item;
                    search = parent.search.GetText();
                    RemoveChild(internalGrid);
                    loading.VAlign = 0.5f;
                    loading.HAlign = 0.45f;
                    Append(loading);
                    t = Task.Run(recreateList);
                }
                else
                {
                    selected = changer.selected;
                    search = parent.search.GetText();
                    changedToList = true;
                }
            }
            if (t != null)
            {
                if (t.IsCompleted)
                {
                    RemoveChild(loading);
                    Append(internalGrid);
                    hasChanges = true;
                    invalidatedList = false;
                    t.Dispose();
                    t = null;
                }
            }
            if (hasChanges)
            {
                if (t == null)
                {
                    internalGrid.Left.Set(0, 0);
                    internalGrid.Top.Set(0, 0);
                    internalGrid.Width.Set(this.Width.Pixels - 4, 0);
                    internalGrid.Height.Set(this.Height.Pixels - 4, 0);
                    internalGrid.Recalculate();
                }
                Recalculate();
                hasChanges = false;
            }
            else
            {
                Recalculate();
            }
            base.Update(gameTime);
        }

        public void recreateList()
        {
            internalGrid.Left.Set(0, 0);
            internalGrid.Top.Set(0, 0);
            internalGrid.Width.Set(this.Width.Pixels - 4, 0);
            internalGrid.Height.Set(this.Height.Pixels - 4, 0);

            restart:
            changedToList = false;
            internalGrid.Clear();

            if (parent.destroySlot.item != null && parent.destroySlot.item.type != 0 && !ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(parent.destroySlot.item)) && PartRecipes.recipesByResult.ContainsKey(ARareItemSwapJPANs.ItemToTag(parent.destroySlot.item)))
            {
                foreach (PartRecipe pr in PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(parent.destroySlot.item)])
                {
                    if (pr.isAvailable())
                    {
                        PurchaseItemSlot pt = new PurchaseItemSlot(pr);
                        if (parent.selectedRecipe == null)
                            parent.selectedRecipe = pr;
                        if (pr.Equals(parent.selectedRecipe))
                        {
                            pt.select(true);
                        }
                        internalGrid.Add(pt);
                        if (changedToList)
                            goto restart;
                    }
                }
            }
            else if (selected.Equals(changer.availableTree))
            {
                List<PartRecipe> prtList = new List<PartRecipe>();

                prtList.AddRange(PartRecipes.allRecipes);
                prtList.Sort(PartRecipe.orderByResultName);
                for (int i = 0; i < prtList.Count; i++)
                {
                    if (!prtList[i].isAvailable())
                    {
                        prtList.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        if (!Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().CanCraftRecipe(prtList[i]))
                        {
                            prtList.RemoveAt(i);
                            i--;
                        }
                    }
                    if (changedToList)
                        goto restart;
                }

                foreach (PartRecipe pr in prtList)
                {
                    if (search == null || search.Trim().Length == 0 || pr.result.Name.ToLower().Contains(search.ToLower()) || (tooltipSearch && condensedTooltip(pr.result).ToLower().Contains(search.ToLower())))
                    {
                        PurchaseItemSlot pt = new PurchaseItemSlot(pr);
                        internalGrid.Add(pt);
                    }
                    if (changedToList)
                        goto restart;
                }

            }
            else if (selected.Equals(changer.allTree))
            {
                List<PartRecipe> prtList = new List<PartRecipe>();

                prtList.AddRange(PartRecipes.allRecipes);
                prtList.Sort(PartRecipe.orderByResultName);

                foreach (PartRecipe pr in prtList)
                {
                    if (pr.isAvailable())
                    {
                        if (search == null || search.Trim().Length == 0 || pr.result.Name.ToLower().Contains(search.ToLower()) || (tooltipSearch && condensedTooltip(pr.result).ToLower().Contains(search.ToLower())))
                        {
                            PurchaseItemSlot pt = new PurchaseItemSlot(pr);
                            internalGrid.Add(pt);
                        }
                        if (changedToList)
                            goto restart;
                    }
                }

            }
            else if (selected.Equals(changer.partsTree))
            {
                PartsPlayer prt = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>();
                foreach (string s in ARareItemSwapJPANs.tokenList)
                {
                    if (prt.parts.ContainsKey(s))
                    {
                        Item part = ARareItemSwapJPANs.getItemFromTag(s);
                        if (search == null || search.Trim().Length == 0 || part.Name.ToLower().Contains(search.ToLower()) || (tooltipSearch && condensedTooltip(part).ToLower().Contains(search.ToLower())))
                        {
                            PartItemSlot pt = new PartItemSlot(s, -1);
                            internalGrid.Add(pt);
                        }
                        if (changedToList)
                            goto restart;
                    }
                }
            }
            else
            {
                if (selected != null && PartRecipes.recipesByCategory.ContainsKey(selected.getFullPath()))
                {
                    List<PartRecipe> prtList = new List<PartRecipe>();
                    prtList.AddRange(PartRecipes.recipesByCategory[selected.getFullPath()]);
                    prtList.Sort(PartRecipe.orderByResultName);
                    foreach (PartRecipe pr in prtList)
                    {
                        if (pr.isAvailable())
                        {
                            if (search == null || search.Length == 0 || pr.result.Name.ToLower().Contains(search.ToLower()) || (tooltipSearch && condensedTooltip(pr.result).ToLower().Contains(search.ToLower())))
                            {
                                PurchaseItemSlot pt = new PurchaseItemSlot(pr);
                             
                                internalGrid.Add(pt);
                            }
                        }
                        if (changedToList)
                            goto restart;
                    }
                }
            }
        }
        private string condensedTooltip(Item item)
        {
            mouseTooltip = checkTooltip(item);
            return mouseTooltip;
        }

		public static string checkTooltip(Item item)
		{
			int num = -1;
			int rare = item.rare;
			float knockBack = item.knockBack;
			float num2 = 1f;
			if (item.melee && Main.player[Main.myPlayer].kbGlove)
			{
				num2 += 1f;
			}
			if (Main.player[Main.myPlayer].kbBuff)
			{
				num2 += 0.5f;
			}
			if (num2 != 1f)
			{
				item.knockBack *= num2;
			}
			if (item.ranged && Main.player[Main.myPlayer].shroomiteStealth)
			{
				item.knockBack *= 1f + (1f - Main.player[Main.myPlayer].stealth) * 0.5f;
			}
			ItemTooltip toolTip = item.ToolTip;
			int valueOrDefault = (20 + ((toolTip != null) ? new int?(toolTip.Lines) : null)).GetValueOrDefault();
			int num3 = 1;
			string[] array = new string[valueOrDefault];
			bool[] array2 = new bool[valueOrDefault];
			bool[] array3 = new bool[valueOrDefault];
			string[] array4 = new string[valueOrDefault];
			for (int n = 0; n < valueOrDefault; n++)
			{
				array2[n] = false;
				array3[n] = false;
			}
			array[0] = item.HoverName;
			array4[0] = "ItemName";
			if (item.favorited)
			{
				array[num3++] = Lang.tip[56].Value;
				array4[num3 - 1] = "Favorite";
				array[num3++] = Lang.tip[57].Value;
				array4[num3 - 1] = "FavoriteDesc";
			}
			if (item.social)
			{
				array[num3] = Lang.tip[0].Value;
				array4[num3] = "Social";
				num3++;
				array[num3] = Lang.tip[1].Value;
				array4[num3] = "SocialDesc";
				num3++;
			}
			else
			{
				if (item.damage > 0 && (!item.notAmmo || item.useStyle > 0) && (item.type < 71 || item.type > 74 || Main.player[Main.myPlayer].HasItem(905)))
				{
					LocalizedText localizedText;
					if (item.melee)
					{
						localizedText = Lang.tip[2];
					}
					else if (item.ranged)
					{
						localizedText = Lang.tip[3];
					}
					else if (item.magic)
					{
						localizedText = Lang.tip[4];
					}
					else if (item.thrown)
					{
						localizedText = Lang.tip[58];
					}
					else if (item.summon)
					{
						localizedText = Lang.tip[53];
					}
					else
					{
						localizedText = Lang.tip[55];
					}
					int num4 = Main.player[Main.myPlayer].GetWeaponDamage(item);
					if (item.type == 3829 || item.type == 3830 || item.type == 3831)
					{
						num4 *= 3;
					}
					array[num3] = num4 + localizedText.Value;
					array4[num3] = "Damage";
					num3++;
					if (!item.summon)
					{
						int num5;
						if (item.melee)
						{
							num5 = Main.player[Main.myPlayer].meleeCrit - Main.player[Main.myPlayer].inventory[Main.player[Main.myPlayer].selectedItem].crit + item.crit;
						}
						else if (item.ranged)
						{
							num5 = Main.player[Main.myPlayer].rangedCrit - Main.player[Main.myPlayer].inventory[Main.player[Main.myPlayer].selectedItem].crit + item.crit;
						}
						else if (item.magic)
						{
							num5 = Main.player[Main.myPlayer].magicCrit - Main.player[Main.myPlayer].inventory[Main.player[Main.myPlayer].selectedItem].crit + item.crit;
						}
						else if (item.thrown)
						{
							num5 = Main.player[Main.myPlayer].thrownCrit - Main.player[Main.myPlayer].inventory[Main.player[Main.myPlayer].selectedItem].crit + item.crit;
						}
						else
						{
							num5 = item.crit;
						}
						ItemLoader.GetWeaponCrit(item, Main.player[Main.myPlayer], ref num5);
						PlayerHooks.GetWeaponCrit(Main.player[Main.myPlayer], item, ref num5);
						array[num3] = num5.ToString() + Lang.tip[5].Value;
						array4[num3] = "CritChance";
						num3++;
					}
					if (item.useStyle > 0 && !item.summon)
					{
						if (item.useAnimation <= 8)
						{
							array[num3] = Lang.tip[6].Value;
						}
						else if (item.useAnimation <= 20)
						{
							array[num3] = Lang.tip[7].Value;
						}
						else if (item.useAnimation <= 25)
						{
							array[num3] = Lang.tip[8].Value;
						}
						else if (item.useAnimation <= 30)
						{
							array[num3] = Lang.tip[9].Value;
						}
						else if (item.useAnimation <= 35)
						{
							array[num3] = Lang.tip[10].Value;
						}
						else if (item.useAnimation <= 45)
						{
							array[num3] = Lang.tip[11].Value;
						}
						else if (item.useAnimation <= 55)
						{
							array[num3] = Lang.tip[12].Value;
						}
						else
						{
							array[num3] = Lang.tip[13].Value;
						}
						array4[num3] = "Speed";
						num3++;
					}
					float num6 = item.knockBack;
					if (item.summon)
					{
						num6 += Main.player[Main.myPlayer].minionKB;
					}
					if ((Main.player[Main.myPlayer].magicQuiver && item.useAmmo == AmmoID.Arrow) || item.useAmmo == AmmoID.Stake)
					{
						num6 = (float)((int)(num6 * 1.1f));
					}
					if (Main.player[Main.myPlayer].inventory[Main.player[Main.myPlayer].selectedItem].type == 3106 && item.type == 3106)
					{
						num6 += num6 * (1f - Main.player[Main.myPlayer].stealth);
					}
					ItemLoader.GetWeaponKnockback(item, Main.player[Main.myPlayer], ref num6);
					PlayerHooks.GetWeaponKnockback(Main.player[Main.myPlayer], item, ref num6);
					if (num6 == 0f)
					{
						array[num3] = Lang.tip[14].Value;
					}
					else if ((double)num6 <= 1.5)
					{
						array[num3] = Lang.tip[15].Value;
					}
					else if (num6 <= 3f)
					{
						array[num3] = Lang.tip[16].Value;
					}
					else if (num6 <= 4f)
					{
						array[num3] = Lang.tip[17].Value;
					}
					else if (num6 <= 6f)
					{
						array[num3] = Lang.tip[18].Value;
					}
					else if (num6 <= 7f)
					{
						array[num3] = Lang.tip[19].Value;
					}
					else if (num6 <= 9f)
					{
						array[num3] = Lang.tip[20].Value;
					}
					else if (num6 <= 11f)
					{
						array[num3] = Lang.tip[21].Value;
					}
					else
					{
						array[num3] = Lang.tip[22].Value;
					}
					array4[num3] = "Knockback";
					num3++;
				}
				if (item.fishingPole > 0)
				{
					array[num3] = Language.GetTextValue("GameUI.PrecentFishingPower", item.fishingPole);
					array4[num3] = "FishingPower";
					num3++;
					array[num3] = Language.GetTextValue("GameUI.BaitRequired");
					array4[num3] = "NeedsBait";
					num3++;
				}
				if (item.bait > 0)
				{
					array[num3] = Language.GetTextValue("GameUI.BaitPower", item.bait);
					array4[num3] = "BaitPower";
					num3++;
				}
				if (item.headSlot > 0 || item.bodySlot > 0 || item.legSlot > 0 || item.accessory || Main.projHook[item.shoot] || item.mountType != -1 || (item.buffType > 0 && (Main.lightPet[item.buffType] || Main.vanityPet[item.buffType])))
				{
					array[num3] = Lang.tip[23].Value;
					array4[num3] = "Equipable";
					num3++;
				}
				if (item.tileWand > 0)
				{
					array[num3] = Lang.tip[52].Value + Lang.GetItemNameValue(item.tileWand);
					array4[num3] = "WandConsumes";
					num3++;
				}
				if (item.questItem)
				{
					array[num3] = Lang.inter[65].Value;
					array4[num3] = "Quest";
					num3++;
				}
				if (item.vanity)
				{
					array[num3] = Lang.tip[24].Value;
					array4[num3] = "Vanity";
					num3++;
				}
				if (item.defense > 0)
				{
					array[num3] = item.defense.ToString() + Lang.tip[25].Value;
					array4[num3] = "Defense";
					num3++;
				}
				if (item.pick > 0)
				{
					array[num3] = item.pick.ToString() + Lang.tip[26].Value;
					array4[num3] = "PickPower";
					num3++;
				}
				if (item.axe > 0)
				{
					array[num3] = (item.axe * 5).ToString() + Lang.tip[27].Value;
					array4[num3] = "AxePower";
					num3++;
				}
				if (item.hammer > 0)
				{
					array[num3] = item.hammer.ToString() + Lang.tip[28].Value;
					array4[num3] = "HammerPower";
					num3++;
				}
				if (item.tileBoost != 0)
				{
					int tileBoost = item.tileBoost;
					if (tileBoost > 0)
					{
						array[num3] = "+" + tileBoost.ToString() + Lang.tip[54].Value;
					}
					else
					{
						array[num3] = tileBoost.ToString() + Lang.tip[54].Value;
					}
					array4[num3] = "TileBoost";
					num3++;
				}
				if (item.healLife > 0)
				{
					array[num3] = Language.GetTextValue("CommonItemTooltip.RestoresLife", Main.player[Main.myPlayer].GetHealLife(item, false));
					array4[num3] = "HealLife";
					num3++;
				}
				if (item.healMana > 0)
				{
					array[num3] = Language.GetTextValue("CommonItemTooltip.RestoresMana", Main.player[Main.myPlayer].GetHealMana(item, false));
					array4[num3] = "HealMana";
					num3++;
				}
				if (item.mana > 0 && (item.type != 127 || !Main.player[Main.myPlayer].spaceGun))
				{
					array[num3] = Language.GetTextValue("CommonItemTooltip.UsesMana", Main.player[Main.myPlayer].GetManaCost(item));
					array4[num3] = "UseMana";
					num3++;
				}
				if (item.createWall > 0 || item.createTile > -1)
				{
					if (item.type != 213 && item.tileWand < 1)
					{
						array[num3] = Lang.tip[33].Value;
						array4[num3] = "Placeable";
						num3++;
					}
				}
				else if (item.ammo > 0 && !item.notAmmo)
				{
					array[num3] = Lang.tip[34].Value;
					array4[num3] = "Ammo";
					num3++;
				}
				else if (item.consumable)
				{
					array[num3] = Lang.tip[35].Value;
					array4[num3] = "Consumable";
					num3++;
				}
				if (item.material)
				{
					array[num3] = Lang.tip[36].Value;
					array4[num3] = "Material";
					num3++;
				}
				if (item.ToolTip != null)
				{
					for (int j = 0; j < item.ToolTip.Lines; j++)
					{
						if (j == 0 && item.type >= 1533 && item.type <= 1537 && !NPC.downedPlantBoss)
						{
							array[num3] = Lang.tip[59].Value;
							array4[num3] = "Tooltip" + j.ToString();
							num3++;
						}
						else
						{
							array[num3] = item.ToolTip.GetLine(j);
							array4[num3] = "Tooltip" + j.ToString();
							num3++;
						}
					}
				}
				if ((item.type == 3818 || item.type == 3819 || item.type == 3820 || item.type == 3824 || item.type == 3825 || item.type == 3826 || item.type == 3829 || item.type == 3830 || item.type == 3831 || item.type == 3832 || item.type == 3833 || item.type == 3834) && !Main.player[Main.myPlayer].downedDD2EventAnyDifficulty)
				{
					array[num3] = Lang.misc[104].Value;
					array4[num3] = "EtherianManaWarning";
					num3++;
				}
				if (item.buffType == 26 && Main.expertMode)
				{
					array[num3] = Lang.misc[40].Value;
					array4[num3] = "WellFedExpert";
					num3++;
				}
				if (item.buffTime > 0)
				{
					array[num3] = ((item.buffTime / 60 < 60) ? Language.GetTextValue("CommonItemTooltip.SecondDuration", Math.Round((double)item.buffTime / 60.0)) : Language.GetTextValue("CommonItemTooltip.MinuteDuration", Math.Round((double)(item.buffTime / 60) / 60.0)));
					array4[num3] = "BuffTime";
					num3++;
				}
				if (item.type == 3262 || item.type == 3282 || item.type == 3283 || item.type == 3284 || item.type == 3285 || item.type == 3286 || item.type == 3316 || item.type == 3315 || item.type == 3317 || item.type == 3291 || item.type == 3389)
				{
					array[num3] = " ";
					num = num3;
					array4[num3] = "OneDropLogo";
					num3++;
				}
				if (item.prefix > 0)
				{
					if (Main.cpItem == null || Main.cpItem.netID != item.netID)
					{
						Main.cpItem = new Item();
						Main.cpItem.netDefaults(item.netID);
					}
					if (Main.cpItem.damage != item.damage)
					{
						double num7 = (double)((float)item.damage - (float)Main.cpItem.damage);
						num7 = num7 / (double)((float)Main.cpItem.damage) * 100.0;
						num7 = Math.Round(num7);
						if (num7 > 0.0)
						{
							array[num3] = "+" + num7.ToString() + Lang.tip[39].Value;
						}
						else
						{
							array[num3] = num7.ToString() + Lang.tip[39].Value;
						}
						if (num7 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixDamage";
						num3++;
					}
					if (Main.cpItem.useAnimation != item.useAnimation)
					{
						double num8 = (double)((float)item.useAnimation - (float)Main.cpItem.useAnimation);
						num8 = num8 / (double)((float)Main.cpItem.useAnimation) * 100.0;
						num8 = Math.Round(num8);
						num8 *= -1.0;
						if (num8 > 0.0)
						{
							array[num3] = "+" + num8.ToString() + Lang.tip[40].Value;
						}
						else
						{
							array[num3] = num8.ToString() + Lang.tip[40].Value;
						}
						if (num8 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixSpeed";
						num3++;
					}
					if (Main.cpItem.crit != item.crit)
					{
						double num9 = (double)((float)item.crit - (float)Main.cpItem.crit);
						if (num9 > 0.0)
						{
							array[num3] = "+" + num9.ToString() + Lang.tip[41].Value;
						}
						else
						{
							array[num3] = num9.ToString() + Lang.tip[41].Value;
						}
						if (num9 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixCritChance";
						num3++;
					}
					if (Main.cpItem.mana != item.mana)
					{
						double num10 = (double)((float)item.mana - (float)Main.cpItem.mana);
						num10 = num10 / (double)((float)Main.cpItem.mana) * 100.0;
						num10 = Math.Round(num10);
						if (num10 > 0.0)
						{
							array[num3] = "+" + num10.ToString() + Lang.tip[42].Value;
						}
						else
						{
							array[num3] = num10.ToString() + Lang.tip[42].Value;
						}
						if (num10 > 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixUseMana";
						num3++;
					}
					if (Main.cpItem.scale != item.scale)
					{
						double num11 = (double)(item.scale - Main.cpItem.scale);
						num11 = num11 / (double)Main.cpItem.scale * 100.0;
						num11 = Math.Round(num11);
						if (num11 > 0.0)
						{
							array[num3] = "+" + num11.ToString() + Lang.tip[43].Value;
						}
						else
						{
							array[num3] = num11.ToString() + Lang.tip[43].Value;
						}
						if (num11 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixSize";
						num3++;
					}
					if (Main.cpItem.shootSpeed != item.shootSpeed)
					{
						double num12 = (double)(item.shootSpeed - Main.cpItem.shootSpeed);
						num12 = num12 / (double)Main.cpItem.shootSpeed * 100.0;
						num12 = Math.Round(num12);
						if (num12 > 0.0)
						{
							array[num3] = "+" + num12.ToString() + Lang.tip[44].Value;
						}
						else
						{
							array[num3] = num12.ToString() + Lang.tip[44].Value;
						}
						if (num12 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixShootSpeed";
						num3++;
					}
					if (Main.cpItem.knockBack != knockBack)
					{
						double num13 = (double)(knockBack - Main.cpItem.knockBack);
						num13 = num13 / (double)Main.cpItem.knockBack * 100.0;
						num13 = Math.Round(num13);
						if (num13 > 0.0)
						{
							array[num3] = "+" + num13.ToString() + Lang.tip[45].Value;
						}
						else
						{
							array[num3] = num13.ToString() + Lang.tip[45].Value;
						}
						if (num13 < 0.0)
						{
							array3[num3] = true;
						}
						array2[num3] = true;
						array4[num3] = "PrefixKnockback";
						num3++;
					}
					if (item.prefix == 62)
					{
						array[num3] = "+1" + Lang.tip[25].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDefense";
						num3++;
					}
					if (item.prefix == 63)
					{
						array[num3] = "+2" + Lang.tip[25].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDefense";
						num3++;
					}
					if (item.prefix == 64)
					{
						array[num3] = "+3" + Lang.tip[25].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDefense";
						num3++;
					}
					if (item.prefix == 65)
					{
						array[num3] = "+4" + Lang.tip[25].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDefense";
						num3++;
					}
					if (item.prefix == 66)
					{
						array[num3] = "+20 " + Lang.tip[31].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMaxMana";
						num3++;
					}
					if (item.prefix == 67)
					{
						array[num3] = "+2" + Lang.tip[5].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccCritChance";
						num3++;
					}
					if (item.prefix == 68)
					{
						array[num3] = "+4" + Lang.tip[5].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccCritChance";
						num3++;
					}
					if (item.prefix == 69)
					{
						array[num3] = "+1" + Lang.tip[39].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDamage";
						num3++;
					}
					if (item.prefix == 70)
					{
						array[num3] = "+2" + Lang.tip[39].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDamage";
						num3++;
					}
					if (item.prefix == 71)
					{
						array[num3] = "+3" + Lang.tip[39].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDamage";
						num3++;
					}
					if (item.prefix == 72)
					{
						array[num3] = "+4" + Lang.tip[39].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccDamage";
						num3++;
					}
					if (item.prefix == 73)
					{
						array[num3] = "+1" + Lang.tip[46].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMoveSpeed";
						num3++;
					}
					if (item.prefix == 74)
					{
						array[num3] = "+2" + Lang.tip[46].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMoveSpeed";
						num3++;
					}
					if (item.prefix == 75)
					{
						array[num3] = "+3" + Lang.tip[46].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMoveSpeed";
						num3++;
					}
					if (item.prefix == 76)
					{
						array[num3] = "+4" + Lang.tip[46].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMoveSpeed";
						num3++;
					}
					if (item.prefix == 77)
					{
						array[num3] = "+1" + Lang.tip[47].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMeleeSpeed";
						num3++;
					}
					if (item.prefix == 78)
					{
						array[num3] = "+2" + Lang.tip[47].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMeleeSpeed";
						num3++;
					}
					if (item.prefix == 79)
					{
						array[num3] = "+3" + Lang.tip[47].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMeleeSpeed";
						num3++;
					}
					if (item.prefix == 80)
					{
						array[num3] = "+4" + Lang.tip[47].Value;
						array2[num3] = true;
						array4[num3] = "PrefixAccMeleeSpeed";
						num3++;
					}
				}
				if (item.wornArmor && Main.player[Main.myPlayer].setBonus != "")
				{
					array[num3] = Lang.tip[48].Value + " " + Main.player[Main.myPlayer].setBonus;
					array4[num3] = "SetBonus";
					num3++;
				}
			}
			if (item.expert)
			{
				array[num3] = Language.GetTextValue("GameUI.Expert");
				array4[num3] = "Expert";
				num3++;
			}
			float num14 = (float)Main.mouseTextColor / 255f;
			int alpha = (int)Main.mouseTextColor;

			Vector2 zero = Vector2.Zero;
			Color?[] array5;
			List<TooltipLine> list = ItemLoader.ModifyTooltips(item, ref num3, array4, ref array, ref array2, ref array3, ref num, out array5);
			//List<DrawableTooltipLine> list2 = list.Select((TooltipLine x, int i) => new DrawableTooltipLine(x, i, 0, 0, Color.White)).ToList<DrawableTooltipLine>();

			string ans = "";
			foreach (TooltipLine tt in list)
			{
				ans += tt.text + " \n";
			}

			return ans;
		}

	}

    public class TokenPanel : UIPanel
    {
        public UIGrid internalGrid;

        public PartExchangeUI parent;
        public PartRecipe selected;

        public bool hasChanges = false;
        //private TokenPanel tokens;

        public TokenPanel(PartExchangeUI panel)
        {
            parent = panel;
            hasChanges = true;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            BackgroundColor = Color.Gray;
            BorderColor = Color.White;
            internalGrid = new UIGrid();
            Append(internalGrid);
            hasChanges = true;
        }

        public override void Update(GameTime gameTime)
        {
            if (hasChanges || selected != parent.selectedRecipe || selected == null || !selected.Equals(parent.selectedRecipe))
            {
                selected = parent.selectedRecipe;

                internalGrid.Left.Set(0, 0);
                internalGrid.Top.Set(0, 0);
                internalGrid.Width.Set(this.Width.Pixels - 4, 0);
                internalGrid.Height.Set(this.Height.Pixels - 4, 0);
                internalGrid.Clear();

                float startX = 0;
                float startY = 0;
                if (selected != null) {
                    PartsPlayer prt = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>();
                    foreach (Item part in selected.parts)
                    {
                        PartItemSlot pt = new PartItemSlot(ARareItemSwapJPANs.ItemToTag(part), part.stack);
                        //pt.Left.Set(startX, 0);
                       // pt.Top.Set(startY, 0);
                        /*startX += pt.Width.Pixels + 2;
                        if (startX + pt.Width.Pixels + 2 > this.Height.Pixels - 4)
                        {
                            startX = 0;
                            startY += pt.Height.Pixels + 2;
                        }*/
                        internalGrid.Add(pt);
                    }
                }
                //  internalGrid.Height.Set(Math.Max(this.Height.Pixels, startY + parent.destroySlot.Height.Pixels + 2), 0);
                internalGrid.Recalculate();
                Recalculate();
                hasChanges = false;
            }
            base.Update(gameTime);
        }
        
    }


}
