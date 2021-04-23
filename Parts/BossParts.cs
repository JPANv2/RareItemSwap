using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Globals;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts
{
    public abstract class BossPart : ItemPart
    {
        public override bool CloneNewInstances => base.CloneNewInstances;

        public int bossID = 0;

        public override void AddRecipes()
        {
            base.AddRecipes();
            if(bossID != 0)
                PartsGlobalNPC.addPartToNPC(bossID,this);
            Mod rmod = ModLoader.GetMod("ResearchFrom14");
            if (rmod == null)
                return;
            rmod.Call("SetDefaultMaxResearch", item.type, 500);
            rmod.Call("SetDefaultCategories", item.type, "Parts");
            rmod.Call("SetDefaultCategories", item.type, "Parts/Boss Parts");
        }
    }
}
