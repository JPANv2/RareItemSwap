using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla.Biomes
{
    public class CorruptionSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/CorruptionSurfacePart_World";
            base.DisplayName.SetDefault("Corruption Part");
            base.Tooltip.SetDefault("From defeating enemies in the Corruption (above ground)");
        }
    }

    public class CorruptionUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/CorruptionUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Corruption Part");
            base.Tooltip.SetDefault("From defeating enemies in the Corruption (below ground)");
        }
    }

    public class CrimsonSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/CrimsonSurfacePart_World";
            base.DisplayName.SetDefault("Crimson Part");
            base.Tooltip.SetDefault("From defeating enemies in the Crimson (above ground)");
        }
    }

    public class CrimsonUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/CrimsonUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Crimson Part");
            base.Tooltip.SetDefault("From defeating enemies in the Crimson (below ground)");
        }
    }

    public class DesertSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/DesertSurfacePart_World";
            base.DisplayName.SetDefault("Desert Part");
            base.Tooltip.SetDefault("From defeating enemies in the Desert (above ground)");
        }
    }

    public class DesertUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/DesertUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Desert Part");
            base.Tooltip.SetDefault("From defeating enemies in the Desert (below ground)");
        }
    }

    
    public class DungeonSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/DungeonSurfacePart_World";
            base.DisplayName.SetDefault("Surface Dungeon Part");
            base.Tooltip.SetDefault("From defeating enemies in the Dungeon (above ground)");
        }
    }
    
    public class DungeonUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/DungeonUndergroundPart_World";
            base.DisplayName.SetDefault("Dungeon Part");
            base.Tooltip.SetDefault("From defeating enemies in the Dungeon");
        }
    }

    public class ForestSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/ForestSurfacePart_World";
            base.DisplayName.SetDefault("Forest Part");
            base.Tooltip.SetDefault("From defeating enemies in the Purity (above ground)");
        }
    }

    public class ForestUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/ForestUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Part");
            base.Tooltip.SetDefault("From defeating enemies underground with no other biome present");
        }
    }

    public class GlowingMushroomSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/GlowingMushroomSurfacePart_World";
            base.DisplayName.SetDefault("Glowing Mushroom Part");
            base.Tooltip.SetDefault("From defeating enemies in the Mushroom biome (above ground)");
        }
    }

    public class GlowingMushroomUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/GlowingMushroomUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Glowing Mushroom Part");
            base.Tooltip.SetDefault("From defeating enemies in the Mushroom biome (below ground)");
        }
    }

    public class GraniteSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/GraniteSurfacePart_World";
            base.DisplayName.SetDefault("Granite Surface Part");
            base.Tooltip.SetDefault("From defeating enemies in the Granite above ground");
        }
    }

    public class GraniteUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/GraniteUndergroundPart_World";
            base.DisplayName.SetDefault("Granite Part");
            base.Tooltip.SetDefault("From defeating enemies in the Granite");
        }
    }

    public class HallowedSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/HallowedSurfacePart_World";
            base.DisplayName.SetDefault("Hallowed Part");
            base.Tooltip.SetDefault("From defeating enemies in the Hallowed (above ground)");
        }
    }

    public class HallowedUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/HallowedUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Hallowed Part");
            base.Tooltip.SetDefault("From defeating enemies in the Hallowed (below ground)");
        }
    }

    public class HellSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/HellSurfacePart_World";
            base.DisplayName.SetDefault("Surface Hell Part");
            base.Tooltip.SetDefault("From defeating enemies in Hell while above ground (how did you manage that?)");
        }
    }

    public class HellUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/HellUndergroundPart_World";
            base.DisplayName.SetDefault("Hell Part");
            base.Tooltip.SetDefault("From defeating enemies in Hell");
        }
    }

    public class IceSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/IceSurfacePart_World";
            base.DisplayName.SetDefault("Ice Part");
            base.Tooltip.SetDefault("From defeating enemies in the Ice/Snow biome (above ground)");
        }
    }

    public class IceUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/IceUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Ice Part");
            base.Tooltip.SetDefault("From defeating enemies in the Ice biome (below ground)");
        }
    }

    public class JungleSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/JungleSurfacePart_World";
            base.DisplayName.SetDefault("Jungle Part");
            base.Tooltip.SetDefault("From defeating enemies in the Jungle (above ground)");
        }
    }

    public class JungleUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/JungleUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Jungle Part");
            base.Tooltip.SetDefault("From defeating enemies in the Underground Jungle");
        }
    }

    public class MarbleSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/MarbleSurfacePart_World";
            base.DisplayName.SetDefault("Marble Surface Part");
            base.Tooltip.SetDefault("From defeating enemies in the Marble above ground");
        }
    }

    public class MarbleUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/MarbleUndergroundPart_World";
            base.DisplayName.SetDefault("Marble Part");
            base.Tooltip.SetDefault("From defeating enemies in the Marble");
        }
    }

    public class MeteoriteSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/MeteoriteSurfacePart_World";
            base.DisplayName.SetDefault("Meteorite Part");
            base.Tooltip.SetDefault("From defeating enemies in the Meteorite Biome");
        }
    }

    public class MeteoriteUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/MeteoriteUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Meteorite Part");
            base.Tooltip.SetDefault("From defeating enemies in the Meteorite underground");
        }
    }

    public class OceanSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/OceanSurfacePart_World";
            base.DisplayName.SetDefault("Ocean Part");
            base.Tooltip.SetDefault("From defeating enemies in the Ocean");
        }
    }

    public class OceanUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/OceanUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Ocean Part");
            base.Tooltip.SetDefault("From defeating enemies in the Ocean while underground");
        }
    }

    public class SkySurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/SkySurfacePart_World";
            base.DisplayName.SetDefault("Sky Part");
            base.Tooltip.SetDefault("From defeating enemies in the Sky/Space");
        }
    }

    public class SkyUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/SkyUndergroundPart_World";
            base.DisplayName.SetDefault("Underground Sky Part");
            base.Tooltip.SetDefault("From defeating enemies in the Sky/Space while underground (how???)");
        }
    }

    public class SpiderCaveSurfacePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/SpiderCaveSurfacePart_World";
            base.DisplayName.SetDefault("Surface Spider Cave Part");
            base.Tooltip.SetDefault("From defeating enemies in the an above ground Spider Cave (Good Luck!)");
        }
    }

    public class SpiderCaveUndergroundPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Biomes/SpiderCaveUndergroundPart_World";
            base.DisplayName.SetDefault("Spider Cave Part");
            base.Tooltip.SetDefault("From defeating enemies in the Spider Cave");
        }
    }
}
