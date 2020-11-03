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
            mouseTooltip = "";
            isSearching = true;
            Item mouse = Main.HoverItem;
            Main.HoverItem = item;
            Main.instance.MouseText("");
            Main.HoverItem = mouse;
            isSearching = false;
            return mouseTooltip;
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
