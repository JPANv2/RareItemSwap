using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class HasPartModCall : ModCallCommand
    {
        public HasPartModCall() : base("HasPart", "PlayerHasPart")
        {

        }

        public override string Help()
        {
            return " - HasPart(Player player, Item part, optional long count) " + "\n"+
            "Returns the total of that part the player has, or true/false if the optional count is sent.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 1)
            {
                ARareItemSwapJPANs.LogError(name, "Requires at least 2 Arguments;\n" + Help());
                return null;
            }
            Player p = getPlayerFromObject(args[start]);
            if (p == null)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid player");
                return null;
            }
            PartsPlayer pp = p.GetModPlayer<PartsPlayer>();
            if(pp == null)
            {
               ARareItemSwapJPANs.LogError(name, "Invalid player");
               return null;
            }
            Item itm = getItemFromObject(args[start + 1]);
            if(itm == null)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item for part: null");
                return null;
            }

            long total = pp.getPartAmount(ARareItemSwapJPANs.ItemToTag(itm));
            if(total == -1)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item for part: item is not a part");
                return null;
            }

            if(args.Length - start > 2)
            {
                long? toCheck = getLongFromObject(args[start + 2]);
                if(toCheck == null || !toCheck.HasValue)
                {
                    ARareItemSwapJPANs.LogError(name, "Invalid long for count");
                    return null;
                }
                return total >= toCheck;
            }
            else
            {
                return total;
            }

        }

    }
}
