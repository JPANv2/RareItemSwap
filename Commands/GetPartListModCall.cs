using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class GetPartListModCall : ModCallCommand
    {
        public GetPartListModCall() : base("GetPartList", "PartList")
        {

        }

        public override string Help()
        {
            return " - GetPartList() " + "\n"+
            "Returns a list of ItemTags of the parts that exist.";
        }

        public override object Run(object[] args, int start = 1)
        {
            List<string> parts = new List<string>();
            parts.AddRange(ARareItemSwapJPANs.tokenList);
            return parts;
        }

    }
}
