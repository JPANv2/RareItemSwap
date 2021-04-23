using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Commands
{
    public class DebugDumpModCall : ModCallCommand
    {
        public DebugDumpModCall() : base("DebugDump")
        {

        }

        public override string Help()
        {
            return " - DebugDump() " + "\n" +
            "Writes a few files in the Log folder containing the items that do not have crafting recipes for all mods.\n" +
            "Useful for making mod-compatibility for this mod.";
        }

        public override object Run(object[] args, int start = 1)
        {
            ARareItemSwapJPANs.makeItemTables();
            ARareItemSwapJPANs.makeNPCTables();
            return true;
        }
    }
}
