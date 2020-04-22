using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class DeveloperPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/DeveloperPart_World";
            base.DisplayName.SetDefault("Developer Part");
            base.Tooltip.SetDefault("Swap from and for any Developer item.");
        }
    }
}
