using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Calamity.Events
{
    public class AcidRainPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Events/AcidRainPart_World";
            base.DisplayName.SetDefault("Acid Rain Part");
            base.Tooltip.SetDefault("From defeating enemies during the Acid Rain in the Sulphurous Sea");
        }
    }

   
}
