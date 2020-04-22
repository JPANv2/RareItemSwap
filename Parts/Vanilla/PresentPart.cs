using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class PresentPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/PresentPart_World";
            base.DisplayName.SetDefault("Present Part");
            base.Tooltip.SetDefault("Swap for Presents and its contents.");
        }
    }
}
