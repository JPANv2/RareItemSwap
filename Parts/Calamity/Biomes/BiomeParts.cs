using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Calamity.Biomes
{
    public class AbyssPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/AbyssPart_World";
            base.DisplayName.SetDefault("Abyss Part");
            base.Tooltip.SetDefault("From defeating enemies in the Abyss");
        }
    }

    public class AstralInfectionPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/AstralInfectionPart_World";
            base.DisplayName.SetDefault("Astral Infection Part");
            base.Tooltip.SetDefault("From defeating enemies in the Astral Infection");
        }
    }
    public class UndergroundAstralInfectionPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/UndergroundAstralInfectionPart_World";
            base.DisplayName.SetDefault("Underground Astral Infection Part");
            base.Tooltip.SetDefault("From defeating enemies in the Underground Astral Infection");
        }
    }

    public class CragsPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/CragsPart_World";
            base.DisplayName.SetDefault("Brimstone Crag Part");
            base.Tooltip.SetDefault("From defeating enemies in the Brimstone Crag");
        }
    }

    public class SulfurSeaPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/SulfurSeaPart_World";
            base.DisplayName.SetDefault("Sulphurous Sea Part");
            base.Tooltip.SetDefault("From defeating enemies in the Sulphurous Sea");
        }
    }

    public class SunkenSeaPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Biomes/SunkenSeaPart_World";
            base.DisplayName.SetDefault("Sunken Sea Part");
            base.Tooltip.SetDefault("From defeating enemies in the Sunken Sea");
        }
    }
}
