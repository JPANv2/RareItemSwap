using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class DyePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/DyePart_World";
            base.DisplayName.SetDefault("Dye Part");
            base.Tooltip.SetDefault("Swap from and for (almost) any Dye.");
        }
    }
}
