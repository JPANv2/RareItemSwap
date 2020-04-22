using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla.Stages
{
    public class HardmodePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Stages/HardmodePart_World";
            base.DisplayName.SetDefault("Hardmode Part");
            base.Tooltip.SetDefault("Proof you have entered Hardmode. Used for early-mid hardmode items.");
        }
    }

    public class PostPlanteraPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Stages/PostPlanteraPart_World";
            base.DisplayName.SetDefault("Post-Plantera Part");
            base.Tooltip.SetDefault("Proof you have beaten Plantera. Used for items that only appear after Plantera has been defeated.");
        }
    }

    public class PostMoonLordPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Stages/PostMoonLordPart_World";
            base.DisplayName.SetDefault("Post-Moonlord Part");
            base.Tooltip.SetDefault("Proof you have beaten Moon Lord. Used for items that only appear after the Moon Lord has been defeated.");
        }
    }
}
