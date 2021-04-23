using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class GetMaxPurchasesAvailableModCall : ModCallCommand
    {
        public GetMaxPurchasesAvailableModCall() : base("GetMaxPurchasesAvailable")
        {

        }

        public override string Help()
        {
            return " - GetMaxPurchasesAvailable (string... parts)\n"+
            "Returns a list of items with the stack as the purchase of one of them for all parts whose tags match the given strings, regardless of amount required.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length == start)
            {
                ARareItemSwapJPANs.LogError(name, " Needs at least one item part tag as input.\n" + Help());
                return null;
            }
            List<string> parts = getListOfStringFromObjects(args, 1);
            if (parts.Count == 0)
            {
                ARareItemSwapJPANs.LogError(name, " Needs at least one item part tag as input.\n" + Help());
                return null;
            }
            List<Item> targets = new List<Item>();
            foreach (PartRecipe pr in PartRecipes.allRecipes)
            {
                bool allParts = true;
                foreach (Item itm in pr.parts)
                {
                    allParts = allParts && parts.Contains(ARareItemSwapJPANs.ItemToTag(itm));
                }
                if (allParts && pr.available())
                {
                    targets.Add(pr.result.Clone());
                }
            }
            return targets;
        }

    }
}
