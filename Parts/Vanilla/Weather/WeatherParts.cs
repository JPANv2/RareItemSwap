using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla.Weather
{
    public class RainPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Weather/RainPart_World";
            base.DisplayName.SetDefault("Rain Part");
            base.Tooltip.SetDefault("Obtained from enemies while raining.");
        }
    }

    public class SandstormPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Weather/SandstormPart_World";
            base.DisplayName.SetDefault("Sandstorm Part");
            base.Tooltip.SetDefault("Obtained from enemies while in the Desert during a Sandstorm.");
        }
    }
}
