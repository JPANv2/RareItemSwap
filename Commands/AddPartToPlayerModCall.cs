using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class AddPartToPlayerModCall : ModCallCommand
    {
        public AddPartToPlayerModCall() : base("AddPartToPlayer", "PlayerAddPart")
        {

        }

        public override string Help()
        {
            return " - AddPartToPlayer(Player player, Item part, optional long count) " + "\n"+
            "Adds count number of the part to the player.\n"  +
            "Returns the amount that the player has of that part (total), or -count if it would overflow (and will not add anything to the player in that case).\n"+
            "If count is ommited, it is treated as +1";
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
                return pp.increasePart(ARareItemSwapJPANs.ItemToTag(itm), toCheck.Value);
            }
            else
            {
                return pp.increasePart(ARareItemSwapJPANs.ItemToTag(itm));
            }

        }

    }
}
