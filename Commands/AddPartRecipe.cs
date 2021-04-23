using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Recipes;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class AddPartRecipeModCall: ModCallCommand
    {
        public AddPartRecipeModCall() : base("AddPartRecipe", "PartRecipe")
        {

        }

        public override string Help()
        {
            return " - AddPartRecipe(Item toAdd, int? count, bool? irreversible, int? PartPairsCount, (Item partToSwap, int? count)*PartPairsCount, string mod, Func<bool> availability, string... categories) " + "\n" +
            "Creates the Part recipe -> (toAdd * count) <=> (toSwap[1] * count[1]) + (toSwap[2] * count[2])... +(toSwap[PartPairsCount] * count[PartPairsCount]) \n" +
            "Can be used to override existing recipes (same output and parts, but different counts). Cannot be used to remove recipes.\n";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 5)
            {
                ARareItemSwapJPANs.LogError(name, "Requires at least 6 Arguments;\n" + Help());
                return false;
            }
            Item item = getItemFromObject(args[start]);
            if (item == null || item.IsAir)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item to exchange");
                return false;
            }
            int? count = getIntFromObject(args[start+1]);
            if (count == null || !count.HasValue || count.Value == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item to exchange count");
                return false;
            }
            bool? irreversible = args[start + 2] as bool?;
            if (irreversible == null || !irreversible.HasValue)
            {
                irreversible = false;
            }

            int? pairsCount = getIntFromObject(args[start + 3]);
            if (pairsCount == null || !pairsCount.HasValue || pairsCount.Value == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid part count");
                return false;
            }

            if(args.Length < start + pairsCount.Value*2 + 4)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid part count: too few arguments");
                return false;
            }

            Item[] parts = new Item[pairsCount.Value];
            int[] counts = new int[pairsCount.Value];
            for (int i = 0; i < pairsCount.Value; i++)
            {
                Item itm = getItemFromObject(args[start + i * 2 + 4]);
                if(itm == null)
                {
                    ARareItemSwapJPANs.LogError(name, "Invalid part item (at "+ (start + i * 2 + 4) + ")");
                    return false;
                }
                int? cnt = getIntFromObject(args[start + i * 2 + 5]);
                if (cnt == null || !cnt.HasValue || cnt.Value == 0)
                {
                    ARareItemSwapJPANs.LogError(name, "Invalid part item to exchange count (at " + (start + i * 2 + 5) + ")");
                    return false;
                }

                parts[i] = itm;
                counts[i] = cnt.Value;
            }
            int nextStart = start + 4 + pairsCount.Value * 2;

            string modName = args[nextStart] as string;
            if(modName == null || modName.Trim().Length == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid mod name");
                return false;
            }
           
            Func<bool> available = args[nextStart + 1] as Func<bool>;

            List<string> categories = getListOfStringFromObjects(args, nextStart + 2);

           PartRecipes.addAllRecipes(ModPartRepository.makePartRecipe(modName,item,count.Value,parts,counts,categories,available));

           return true;
        }

    }
}
