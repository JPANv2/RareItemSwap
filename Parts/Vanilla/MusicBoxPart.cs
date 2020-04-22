using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class MusicBoxPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/MusicBoxPart_World";
            base.DisplayName.SetDefault("Music Box Part");
            base.Tooltip.SetDefault("Swap from and for (nearly)any Music Box.");
        }
    }
}
