using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class FishingPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/FishingPart_World";
            base.DisplayName.SetDefault("Fishing Part");
            base.Tooltip.SetDefault("Obtained while Fishing. Trade for fish-related items.");
        }
    }
}
