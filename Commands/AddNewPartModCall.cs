using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class AddNewPartModCall: ModCallCommand
    {
        public AddNewPartModCall() : base("AddNewPart", "NewPart")
        {

        }

        public override string Help()
        {
            return " - AddNewPart(Item part) " + "\n" +
            "Inserts that item in the part list, being automatically added to the pouch when picked up and open the part shop when used.\n"+
            "Don't forget to use the \"AddPartToDropAt\" functions if you want to add it to one of the default drop tables.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 0)
                return false;
            Item item = getItemFromObject(args[start]);
            if(item == null)
                return false;

            ARareItemSwapJPANs.tokenList.Add(ARareItemSwapJPANs.ItemToTag(item));

            Mod rmod = ModLoader.GetMod("ResearchFrom14");
            if (rmod == null)
                return true;
            rmod.Call("SetDefaultMaxResearch", item.type, 100);
            rmod.Call("SetDefaultCategories", item.type, "Parts");

            return true;
        }

    }
}
