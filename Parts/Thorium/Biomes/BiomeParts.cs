using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Thorium.Biomes
{
    public class AquaticDepthsPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Biomes/AquaticDepthsPart_World";
            base.DisplayName.SetDefault("Aquatic Depths Part");
            base.Tooltip.SetDefault("From defeating enemies in the Aquatic Depths");
        }
    }
}
