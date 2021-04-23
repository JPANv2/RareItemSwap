using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class AddPartToDropAtModCall: ModCallCommand
    {
        public AddPartToDropAtModCall() : base("AddPartToDropAt", "DropPartAt")
        {

        }

        public override string Help()
        {
            return " - AddPartToDropAt(String tableID, Item part, Func<bool> dropRule) " + "\n" +
            "Adds the part to the given drop table so it is added to the drop pool when \"dropRule\" is true.\n"+
            "Valid tables are \"biome\",for dropping when in a specific mod biome, \"stage\" for dropping after a certain boss was defeated, " +
            "\"event\" for dropping during specific events (lunar or goblin-like) and \"weather\" for weather related events.\n"+
            "If the Part does not exist, it will be added as a part, same as with \"AddNewPart\" command.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 2) {
                ARareItemSwapJPANs.LogError(name, "Requires at least 3 Arguments;\n" + Help());
                return false;
            }
            string table = args[start] as string;
            if (table == null) {
                ARareItemSwapJPANs.LogError(name, "Table must be one of 4 valid strings: (biome, event, stage or weather)");
                return false;
            }
            table = table.ToLower();
            if (table.StartsWith("\""))
            {
                table = table.Substring(1);
            }
            if (table.EndsWith("\""))
            {
                table = table.Substring(0, table.Length -1);
            }
            Dictionary<string, Func<bool>> res;
            if (table.Equals("biome"))
            {
                res = ARareItemSwapJPANs.publicRepository.dropsInBiome;
            }else if (table.Equals("stage"))
            {
                res = ARareItemSwapJPANs.publicRepository.dropsInStage;
            }
            else if (table.Equals("event"))
            {
                res = ARareItemSwapJPANs.publicRepository.dropsInEvent;
            }
            else if (table.Equals("weather"))
            {
                res = ARareItemSwapJPANs.publicRepository.dropsInWeather;
            }
            else
            {
                ARareItemSwapJPANs.LogError(name, "Table must be one of 4 valid strings: (biome, event, stage or weather)");
                return false;
            }

            Item item = getItemFromObject(args[start+1]);
            Func<bool> dropRule = args[start + 2] as Func<bool>;
            
            if(item == null || item.type == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item");
                return false;
            }
            if (dropRule == null)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid drop function");
                return false;
            }
            String tag = ARareItemSwapJPANs.ItemToTag(item);
            if (!ARareItemSwapJPANs.tokenList.Contains(tag))
            {
                ARareItemSwapJPANs.tokenList.Add(tag);

                Mod rmod = ModLoader.GetMod("ResearchFrom14");
                if (rmod != null)
                {
                    rmod.Call("SetDefaultMaxResearch", item.type, 100);
                    rmod.Call("SetDefaultCategories", item.type, "Parts");
                }
            }

            res[tag] = dropRule;

            return true;
        }

    }
}
