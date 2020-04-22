using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class PaintingPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/PaintingPart_World";
            base.DisplayName.SetDefault("Painting Part");
            base.Tooltip.SetDefault("From and for acquiring Paintings");
        }
    }
}
