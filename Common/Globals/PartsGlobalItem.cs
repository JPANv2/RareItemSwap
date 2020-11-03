using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Common.Globals
{
    public class APartsGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity
        {
            get
            {
                return false;
            }
        }

        public override bool CloneNewInstances
        {
            get
            {
                return false;
            }
        }

        public override bool ItemSpace(Item item, Player player)
        {
            PartsPlayer p = player.GetModPlayer<PartsPlayer>();
            if (p.autoDestroy)
            {
                if (!ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(item)) && PartRecipes.ContainsAsResult(item))
                {
                    foreach (PartRecipe pr in PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)])
                    {
                        if (pr.isAvailable() && !pr.irreversible && item.stack > pr.result.stack)
                        {
                            return true;
                        }
                    }
                }
            }
            return base.ItemSpace(item, player);
        }
        public override bool OnPickup(Item item, Player player)
        {
            PartsPlayer p = player.GetModPlayer<PartsPlayer>();
            PartRecipe pr;
            if (p.autoDestroy && item.active)
            {
                if (!ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(item)) && PartRecipes.ContainsAsResult(item))
                {
                    
                    List<PartRecipe> smallest = new List<PartRecipe>();
                    int j = 0;
                    for (j = 0; j < PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)].Count; j++)
                    {
                        pr = PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][j];
                        if (pr.isAvailable() && !pr.irreversible && item.stack >= pr.result.stack)
                        {
                            smallest.Add(pr);
                            break;
                        }
                    }
                    if (smallest.Count <= 0)
                    {
                        return base.OnPickup(item, player);
                    }
                    for (int i = j; i < PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)].Count; i++)
                    {
                        if (PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i].isAvailable() && !PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i].irreversible)
                        {
                            if (PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i].result.stack < smallest[0].result.stack)
                            {
                                smallest.Clear();
                                smallest.Add(PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i]);
                            }
                            else if (PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i].result.stack == smallest[0].result.stack)
                            {
                                smallest.Add(PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(item)][i]);
                            }
                        }
                    }
                  
                    pr = smallest[Main.rand.Next(smallest.Count)];
                    int stack;
                    int cnt = 0;
                    do
                    {
                        stack = item.stack;
                        pr.refund(p, ref item);
                       // Main.NewText(stack + " = " + item.stack);
                        cnt++;
                    }
                    while (item.stack > 0 && stack != item.stack);
                    if (cnt > 0)
                    {
                        int i = 1;
                        foreach (Item prt in pr.parts)
                        {
                            Item cln = prt.Clone();
                            cln.position = new Microsoft.Xna.Framework.Vector2(item.position.X, item.position.Y + 30*i);
                            cln.stack = (int)prt.stack * cnt;
                            Main.PlaySound(SoundID.Grab, player.position);
                            ItemText.NewText(cln, (int)prt.stack * cnt);
                            i++;
                        }
                    }
                    if (item.stack <= 0)
                    {
                        item.TurnToAir();
                        /*
                        for (j = 0; j < 400; j++)
                        {
                            if (Main.item[j] == item)
                            {
                               
                                Main.item[j] = new Item();
                                if (Main.netMode == 1)
                                {
                                    Main.NewText("Updated Item " + j);
                                    NetMessage.SendData(21, -1, -1, null, item.whoAmI, 0f, 0f, 0f, 0, 0, 0);
                                }
                            }
                        }*/
                        return false;
                    }
                }
            }
            return base.OnPickup(item, player);
        }

        public override bool PreDrawTooltip(Item item, ReadOnlyCollection<TooltipLine> lines, ref int x, ref int y)
        {
            if (((ARareItemSwapJPANs)mod).ui.recipes.tooltipSearch && ((ARareItemSwapJPANs)mod).ui.recipes.isSearching)
            {
                ((ARareItemSwapJPANs)mod).ui.recipes.mouseTooltip = "";
                foreach (TooltipLine line in lines)
                {
                    ((ARareItemSwapJPANs)mod).ui.recipes.mouseTooltip += line.text + "\n";
                }
                return false;
            }
            return base.PreDrawTooltip(item, lines, ref x, ref y);
        }
    }
}
