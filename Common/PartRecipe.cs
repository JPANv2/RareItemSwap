using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Common
{
    public class PartRecipe
    {
        public static List<string> ignoreCategory = new List<String>()
        {
            "By Mod",
            "By Biome",
            "By Event",
            "By Shop",
            "By Parts",
            "By Damage Type",
            "By Weapon Type",
            "By Ammo Type",
            "By Boss",
            "By Part Cost"
        };

        public List<Item> parts;
        public Item result;

        public bool irreversible = false;

        public List<string> categories = new List<string>();

        public Func<bool> available = () => true;

        public bool cloneReward = false;

        public PartRecipe(List<Item> parts, Item result, bool irr = false)
        {
            this.parts = new List<Item>();
            this.parts.AddRange(parts);
            this.result = result;
            this.irreversible = irr;
        }

        public PartRecipe()
        {
            this.parts = new List<Item>();
        }

        public static PartRecipe SimplePartRecipe(int partID, int partAmount, string resultID, int resultAmount = 1) {

            return SimplePartRecipe(partID, partAmount, ARareItemSwapJPANs.getItemTypeFromTag(resultID), resultAmount);
        }

        public static PartRecipe SimplePartRecipe(int partID, int partAmount, int resultID, int resultAmount = 1)
        {
            PartRecipe ans = new PartRecipe();
            Item part = new Item();
            part.SetDefaults(partID,true);
            part.stack = partAmount;
            ans.parts.Add(part);
            ans.result = new Item();
            ans.result.SetDefaults(resultID, true);
            ans.result.stack = resultAmount;
            return ans;
        }

        public static PartRecipe SimpleTwoPartRecipe(int partID, int partAmount, int part2ID, int part2Amount, int resultID, int resultAmount = 1)
        {
            PartRecipe ans = SimplePartRecipe(partID,partAmount, resultID, resultAmount);
            ans.addPart(part2ID, part2Amount);
            return ans;
        }

        public void addPart(int partID, int partAmount = 1)
        {
            if (parts == null)
                parts = new List<Item>();
            Item part = new Item();
            part.SetDefaults(partID, true);
            part.stack = partAmount;
            parts.Add(part);
        }

        public void setResult(int resultID, int resultAmount = 1)
        {
            result = new Item();
            result.SetDefaults(resultID, true);
            result.stack = resultAmount;
        }

        public PartRecipe addCategory(ICollection<string> categories)
        {
            foreach (string k in categories)
            {
                addCategory(k);
            }
            return this;
        }

        public PartRecipe addCategory(string category)
        {
            if (!this.categories.Contains(category))
            {
                this.categories.Add(category);
                this.categories.Sort();
            }
            return this;
        }

        public PartRecipe addCategoryAndSubcategories(ICollection<string> categories, bool ignores = true)
        {
            foreach(string k in categories)
            {
                addCategoryAndSubcategories(k, ignores);
            }
            return this;
        }

        public PartRecipe addCategoryAndSubcategories(string category, bool ignores = true)
        {
            string[] separate = category.Split('/');
            string soFar = "";
            bool added = false;
            for (int i = 0; i<separate.Length; i++)
            {
                    if (separate[i].Length != 0)
                    {
                        soFar += separate[i];
                        if (!ignores || !ignoreCategory.Contains(separate[i]))
                        {
                            if (!separate[i].EndsWith("\\") || separate[i].EndsWith("\\\\"))
                            {
                                if (!this.categories.Contains(soFar))
                                {
                                    this.categories.Add(soFar);
                                    added = true;
                                }
                            }
                        }
                        soFar += '/';
                    }
                
            }
            if (added)
            {
                this.categories.Sort();
            }

            return this;
        }

        public override int GetHashCode()
        {
            int hash = this.result.type + (this.result.stack << 0x10);
            return hash;
        }

        public override bool Equals(object obj)
        {
            PartRecipe eq = obj as PartRecipe;
            if (eq == null)
                return false;
            if (this.result.type != eq.result.type)
               return false;
            if (this.result.stack != eq.result.stack)
                return false;
            if (this.parts.Count != eq.parts.Count)
                return false;

            int matches = 0;
            for (int i = 0; i < this.parts.Count; i++)
            {
                for (int k = i; k < this.parts.Count; k++)
                {
                    if(this.parts[i].type == eq.parts[k].type)
                    {
                        if (this.parts[i].stack == eq.parts[k].stack)
                        {
                            matches++;
                        }
                    }
                }
            }
            return matches >= this.parts.Count;
        }

        public virtual bool EqualsIgnoreStack(object obj)
        {
            PartRecipe eq = obj as PartRecipe;
            if (eq == null)
                return false;
            if (this.result.type != eq.result.type)
                return false;
            if (this.parts.Count != eq.parts.Count)
                return false;

            int matches = 0;
            for (int i = 0; i < this.parts.Count; i++)
            {
                for (int k = i; k < this.parts.Count; k++)
                {
                    if (this.parts[i].type == eq.parts[k].type)
                    {
                        matches++;                        
                    }
                }
            }
            return matches >= this.parts.Count;
        }

        public void setAvailableFunction(Func<bool> func)
        {
            available = func;
        }

        public bool isAvailable()
        {
            if (available == null)
                return true;
            return available.Invoke();
        }

        public void setResultToClone(bool clone = true)
        {
            this.cloneReward = clone;
        }

        public Item Purchase(PartsPlayer player)
        {
            if (isAvailable() && player.CraftPartRecipe(this))
            {
                if (cloneReward)
                {
                    return result.Clone();
                }
                else
                {
                    Item itm = new Item();
                    itm.SetDefaults(result.type);
                    itm.stack = result.stack;
                    return itm;
                }
            }
            return new Item();
        }

        public void refund(PartsPlayer player, ref Item toRefund)
        {
            if (isAvailable() && !irreversible && toRefund.type == result.type && toRefund.stack >= result.stack)
            {
                foreach(Item itm in parts)
                {
                    player.addPart(itm.Clone());
                }
                toRefund.stack -= result.stack;
                if (toRefund.stack <= 0)
                    toRefund.TurnToAir();
            }
        }

        public static int orderByResultName(PartRecipe x, PartRecipe y)
        {
            int res = x.result.Name.CompareTo(y.result.Name);
            if(res != 0)
                return res;
            res = x.parts.Count.CompareTo(y.parts.Count);
            if (res != 0)
                return res;    
            int xCount = 0;
            int yCount = 0;
            for(int i = 0; i< x.parts.Count; i++)
            {
                xCount += x.parts[i].stack;
                yCount += y.parts[i].stack;
            }
            if(xCount != yCount)
            {
                return xCount.CompareTo(yCount);
            }
            for (int i = 0; i < x.parts.Count; i++)
            {
                res = x.parts[i].Name.CompareTo(y.parts[i].Name);
                if (res != 0)
                   return res;
            }
            return 0;
        }

        public static int orderByID(PartRecipe x, PartRecipe y)
        {
            int res = x.result.type.CompareTo(y.result.type);
            if (res != 0)
                return res;
            res = x.parts.Count.CompareTo(y.parts.Count);
            if (res != 0)
                return res;
            int xCount = 0;
            int yCount = 0;
            for (int i = 0; i < x.parts.Count; i++)
            {
                xCount += x.parts[i].stack;
                yCount += y.parts[i].stack;
            }
            if (xCount != yCount)
            {
                return xCount.CompareTo(yCount);
            }
            for (int i = 0; i < x.parts.Count; i++)
            {
                res = x.parts[i].type.CompareTo(y.parts[i].type);
                if (res != 0)
                    return res;
            }
            return 0;
        }
    }

    public class PartRecipes
    {
        public static Dictionary<string, List<PartRecipe>> recipesByResult = new Dictionary<string, List<PartRecipe>>();
        public static Dictionary<string, List<PartRecipe>> recipesByCategory = new Dictionary<string, List<PartRecipe>>();
        public static List<PartRecipe> allRecipes = new List<PartRecipe>();

        public static void Clear()
        {
            recipesByResult.Clear();
            recipesByCategory.Clear();
            allRecipes.Clear();
        }
        public static bool ContainsAsResult(Item itm)
        {
            return recipesByResult.ContainsKey(ARareItemSwapJPANs.ItemToTag(itm));
        }

        public static void addAllRecipes(params PartRecipe[] recipes)
        {
            foreach(PartRecipe rec in recipes)
            {
                addRecipe(rec);
            }
        }

        public static void addAllRecipes(List<PartRecipe> recipes)
        {
            foreach (PartRecipe rec in recipes)
            {
                addRecipe(rec);
            }
        }

        public static void addRecipe(PartRecipe recipe)
        {
            bool added = false;
            if (recipe.result.IsAir)
                return;
            if (!recipesByResult.ContainsKey(ARareItemSwapJPANs.ItemToTag(recipe.result)))
            {
                recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)] = new List<PartRecipe>();
            }
            for(int i = 0; i < recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)].Count; i++)
            {
                if(recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)][i].EqualsIgnoreStack(recipe))
                {
                    recipe.addCategory(recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)][i].categories);
                    allRecipes.Remove(recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)][i]);
                    recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)][i] = recipe;
                    allRecipes.Add(recipe);
                    added = true;
                }
            }
            if (!added)
            {
                allRecipes.Add(recipe);
                recipesByResult[ARareItemSwapJPANs.ItemToTag(recipe.result)].Add(recipe);
            }
            
            foreach(string cat in recipe.categories)
            {
                added = false;
                if (!recipesByCategory.ContainsKey(cat))
                {
                    recipesByCategory[cat] = new List<PartRecipe>();
                }
                for(int i = 0; i < recipesByCategory[cat].Count; i++)
                {
                    if (recipesByCategory[cat][i].EqualsIgnoreStack(recipe))
                    {
                        recipesByCategory[cat][i] = recipe;
                        added = true;
                    }
                }
                if (!added)
                {
                    recipesByCategory[cat].Add(recipe);
                    foreach (Item p in recipe.parts) {
                        added = false;
                        string newCat = "By Part Cost/" + p.Name;;
                        if (!recipesByCategory.ContainsKey(newCat))
                        {
                            recipesByCategory[newCat] = new List<PartRecipe>();
                        }
                        for (int i = 0; i < recipesByCategory[newCat].Count; i++)
                        {
                            if (recipesByCategory[newCat][i].EqualsIgnoreStack(recipe))
                            {
                                recipesByCategory[newCat][i] = recipe;
                                added = true;
                            }
                        }
                        if (!added)
                        {
                            recipesByCategory[newCat].Add(recipe);
                        }
                        newCat = "By Part Cost/" + p.Name +"/" + cat;
                        if (!recipesByCategory.ContainsKey(newCat))
                        {
                            recipesByCategory[newCat] = new List<PartRecipe>();
                        }
                        recipesByCategory[newCat].Add(recipe);
                    }
                }
            }
            
        }
    }
}
