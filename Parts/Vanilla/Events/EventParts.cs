using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARareItemSwapJPANs.Parts.Vanilla.Events
{
    public class BloodMoonPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/BloodMoonPart_World";
            base.DisplayName.SetDefault("Blood Moon Part");
            base.Tooltip.SetDefault("From enemies during a Blood Moon");
        }
    }
    public class FrostLegionPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/FrostLegionPart_World";
            base.DisplayName.SetDefault("Frost Legion Part");
            base.Tooltip.SetDefault("From enemies during a Frost Legion");
        }
    }

    public class FrostMoonPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/FrostMoonPart_World";
            base.DisplayName.SetDefault("Frost Moon Part");
            base.Tooltip.SetDefault("From enemies during a Frost Moon");
        }
    }

    public class GoblinArmyPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/GoblinArmyPart_World";
            base.DisplayName.SetDefault("Goblin Army Part");
            base.Tooltip.SetDefault("From enemies during a Goblin Army invasion");
        }
    }

    public class MartianInvasionPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/MartianInvasionPart_World";
            base.DisplayName.SetDefault("Martian Invasion Part");
            base.Tooltip.SetDefault("From enemies during a Martian invasion");
        }
    }

    public class PirateInvasionPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/PirateInvasionPart_World";
            base.DisplayName.SetDefault("Pirate Invasion Part");
            base.Tooltip.SetDefault("From enemies during a Pirate invasion");
        }
    }

    public class PumpkinMoonPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/PumpkinMoonPart_World";
            base.DisplayName.SetDefault("Pumpkin Moon Part");
            base.Tooltip.SetDefault("From enemies during a Pumpkin Moon");
        }
    }

    public class SlimeRainPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/SlimeRainPart_World";
            base.DisplayName.SetDefault("Slime Rain Part");
            base.Tooltip.SetDefault("From enemies during a Slime Rain");
        }
    }

    public class SolarEclipsePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Events/SolarEclipsePart_World";
            base.DisplayName.SetDefault("Solar Eclipse Part");
            base.Tooltip.SetDefault("From enemies during a Solar Eclipse");
        }
    }
}
