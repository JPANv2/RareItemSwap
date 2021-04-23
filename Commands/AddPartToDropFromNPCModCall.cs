using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Globals;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class AddPartToDropFromNPCModCall: ModCallCommand
    {
        public AddPartToDropFromNPCModCall() : base("AddPartToDropFromNPC", "DropPartFromNPC", "DropPartNPC")
        {

        }

        public override string Help()
        {
            return " - AddPartToDropFromNPC(Item part, NPC npc) " + "\n" +
            "Adds the part to the given npc's drop table so it is dropped when the npc is defeated.\n"+
            "Useful for adding RareEnemyParts to your mod's Rare Enemies!\n"+
            "If the Part does not exist, it will be added as a part, same as with \"AddNewPart\" command.";
        }

        public override object Run(object[] args, int start = 1)
        {
            if (args.Length - start <= 1) {
                ARareItemSwapJPANs.LogError(name, "Requires at least 2 Arguments;\n" + Help());
                return false;
            }
            Item item = getItemFromObject(args[start]); 
            if(item == null || item.type == 0)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid item");
                return false;
            }
            NPC npc = getNPCFromObject(args[start + 1]);
            if (npc == null)
            {
                ARareItemSwapJPANs.LogError(name, "Invalid npc");
                return false;
            }
            String tag = ARareItemSwapJPANs.ItemToTag(item);
            if (!ARareItemSwapJPANs.tokenList.Contains(tag))
            {
                ARareItemSwapJPANs.tokenList.Add(tag);

                Mod rmod = ModLoader.GetMod("ResearchFrom14");
                if (rmod != null)
                {
                    if (npc.boss)
                    {
                        rmod.Call("SetDefaultMaxResearch", item.type, 500);
                        rmod.Call("SetDefaultCategories", item.type, "Parts");
                        rmod.Call("SetDefaultCategories", item.type, "Parts/Boss Parts");
                    }
                    else
                    {
                        rmod.Call("SetDefaultMaxResearch", item.type, 100);
                        rmod.Call("SetDefaultCategories", item.type, "Parts");
                    }
                }
            }

            PartsGlobalNPC.addPartToNPC(npc.type, item);

            return true;
        }

    }
}
