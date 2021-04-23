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
    public class AddBasicShopRecipeModCall: ModCallCommand
    {
        public AddBasicShopRecipeModCall() : base("AddBasicShopRecipe", "BasicShopRecipe","ShopRecipe")
        {

        }

        public override string Help()
        {
            return " - AddBasicShopRecipe(Item toAdd, string mod, string shopName, Func<bool> availability, string... categories) " + "\n" +
            "Creates a simple shop recipe for the given item, in the Mod section and in the Shop/shopName section, available only when availability function is true.\n"+
            "This simple shop recipe includes a trade for every Shop Token that it can have, so any multiple of 5 copper, 5 silver or 5 gold.\n" +
            "other than mod and shopName, availability can be null to be ignored, and Categories are optional, but will make the item easier to find.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 3)
            {
                ARareItemSwapJPANs.LogError(name, "Requires at least 4 Arguments;\n" + Help());
                return false;
            }
            Item item = getItemFromObject(args[start]);
            if (item == null || item.IsAir)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item");
                return false;
            }
            string modName = args[start + 1] as string;
            string shopName = args[start + 2] as string;
            if(modName == null || modName.Trim().Length == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid mod name");
                return false;
            }
            if (shopName == null || shopName.Trim().Length == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid shop name");
                return false;
            }
            Func<bool> available = args[start + 3] as Func<bool>;


           PartRecipes.addAllRecipes(ModPartRepository.buildCommonShopRecipe(item.type, getListOfStringFromObjects(args, 4), shopName, available, modName));

           return true;
        }

    }
}
