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
                PartsGlobalNPC.npcParts[bossID] = this;
        }
    }
}
