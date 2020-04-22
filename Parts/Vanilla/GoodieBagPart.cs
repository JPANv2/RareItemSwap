using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class GoodieBagPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/GoodieBagPart_World";
            base.DisplayName.SetDefault("Goodie Bag Part");
            base.Tooltip.SetDefault("Swap for Goodie Bags and its contents.");
        }
    }
}
