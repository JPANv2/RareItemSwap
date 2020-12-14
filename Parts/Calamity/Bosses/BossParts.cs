using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Globals;

namespace ARareItemSwapJPANs.Parts.Calamity.Bosses
{
    public class AquaticScourgePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:AquaticScourgeHead");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/AquaticScourgePart_World";
            base.DisplayName.SetDefault("Aquatic Scourge Part");
            base.Tooltip.SetDefault("Reward for defeating the Aquatic Scourge. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class AstrumAureusPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:AstrumAureus");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/AstrumAureusPart_World";
            base.DisplayName.SetDefault("Astrum Aureus Part");
            base.Tooltip.SetDefault("Reward for defeating Astrum Aureus. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class AstrumDeusPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:AstrumDeusHeadSpectral");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/AstrumDeusPart_World";
            base.DisplayName.SetDefault("Astrum Deus Part");
            base.Tooltip.SetDefault("Reward for defeating Astrum Deus. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class BrimstoneElementalPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:BrimstoneElemental");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/BrimstoneElementalPart_World";
            base.DisplayName.SetDefault("Brimstone Elemental Part");
            base.Tooltip.SetDefault("Reward for defeating the Brimstone Elemental. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class CalamitasPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:CalamitasRun3");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/CalamitasPart_World";
            base.DisplayName.SetDefault("Calamitas Part");
            base.Tooltip.SetDefault("Reward for defeating Calamitas. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class SupremeCalamitasPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:SupremeCalamitas");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/SupremeCalamitasPart_World";
            base.DisplayName.SetDefault("Supreme Calamitas Part");
            base.Tooltip.SetDefault("Reward for defeating Supreme Calamitas. Swap a bunch for its drops.");
        }
    }

    public class CeaselessVoidPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:CeaselessVoid");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/CeaselessVoidPart_World";
            base.DisplayName.SetDefault("Ceaseless Void Part");
            base.Tooltip.SetDefault("Reward for defeating the Ceaseless Void. Swap a bunch for its drops.");
        }
    }

    public class CrabulonPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:CrabulonIdle");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/CrabulonPart_World";
            base.DisplayName.SetDefault("Crabulon Part");
            base.Tooltip.SetDefault("Reward for defeating Crabulon. Swap a bunch for its drops.");
        }
    }

    public class CryogenPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Cryogen");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/CryogenPart_World";
            base.DisplayName.SetDefault("Cryogen Part");
            base.Tooltip.SetDefault("Reward for defeating Cryogen. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class DesertScourgePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:DesertScourgeHead");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/DesertScourgePart_World";
            base.DisplayName.SetDefault("Desert Scourge Part");
            base.Tooltip.SetDefault("Reward for defeating the Desert Scourge. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class DevourerOfGodsPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:DevourerofGodsHeadS");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/DevourerOfGodsPart_World";
            base.DisplayName.SetDefault("Devourer Of Gods Part");
            base.Tooltip.SetDefault("Reward for defeating the Devourer Of Gods. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class DragonfollyPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Bumblefuck");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/DragonfollyPart_World";
            base.DisplayName.SetDefault("Dragonfolly Part");
            base.Tooltip.SetDefault("Reward for defeating the Dragonfolly. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class HiveMindPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:HiveMindP2");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/HiveMindPart_World";
            base.DisplayName.SetDefault("Hive Mind Part");
            base.Tooltip.SetDefault("Reward for defeating the Hive Mind. Swap a bunch for its drops or Treasure Bag.");
        }
    }
    public class LeviathanPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Leviathan");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/LeviathanPart_World";
            base.DisplayName.SetDefault("Leviathan Part");
            base.Tooltip.SetDefault("Reward for defeating Leviathan and Anahita. Swap a bunch for its drops or Treasure Bag.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            int p2 = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Siren");
            if (p2 > 0)
                PartsGlobalNPC.addPartToNPC(p2, this);
        }
    }
    public class OldDukePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:OldDuke");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/OldDukePart_World";
            base.DisplayName.SetDefault("Old Duke Part");
            base.Tooltip.SetDefault("Reward for defeating the Old Duke. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class PerforatorHivePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:PerforatorHive");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/PerforatorHivePart_World";
            base.DisplayName.SetDefault("Perforator Hive Part");
            base.Tooltip.SetDefault("Reward for defeating the Perforator Hive. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class PlaguebringerGoliathPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:PlaguebringerGoliath");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/PlaguebringerGoliathPart_World";
            base.DisplayName.SetDefault("Plaguebringer Goliath Part");
            base.Tooltip.SetDefault("Reward for defeating Plaguebringer Goliath. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class PolterghastPart: BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Polterghast");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/PolterghastPart_World";
            base.DisplayName.SetDefault("Polterghast Part");
            base.Tooltip.SetDefault("Reward for defeating Polterghast. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class ProvidencePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Providence");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/ProvidencePart_World";
            base.DisplayName.SetDefault("Providence Part");
            base.Tooltip.SetDefault("Reward for defeating Providence, the Profaned Goddess. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class RavagerPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:RavagerBody");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/RavagerPart_World";
            base.DisplayName.SetDefault("Ravager Part");
            base.Tooltip.SetDefault("Reward for defeating Ravager. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class SignusPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Signus");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/SignusPart_World";
            base.DisplayName.SetDefault("Signus Part");
            base.Tooltip.SetDefault("Reward for defeating Signus, Envoy of the Devourer. Swap a bunch for its drops.");
        }
    }


    public class SlimeGodPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:SlimeGodCore");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/SlimeGodPart_World";
            base.DisplayName.SetDefault("Slime God Part");
            base.Tooltip.SetDefault("Reward for defeating Slime God. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class StormWeaverPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:StormWeaverHeadNaked");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/StormWeaverPart_World";
            base.DisplayName.SetDefault("Storm Weaver Part");
            base.Tooltip.SetDefault("Reward for defeating Storm Weaver. Swap a bunch for its drops.");
        }
    }

    public class YharonPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("CalamityMod:Yharon");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Bosses/SlimeGodPart_World";
            base.DisplayName.SetDefault("Yharon Part");
            base.Tooltip.SetDefault("Reward for defeating the Jungle Dragon, Yharon. Swap a bunch for its drops or Treasure Bag.");
        }
    }
}
