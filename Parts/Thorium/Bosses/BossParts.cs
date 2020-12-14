using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Globals;

namespace ARareItemSwapJPANs.Parts.Thorium.Bosses
{
    public class AbyssionPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:AbyssionReleased");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/AbyssionPart_World";
            base.DisplayName.SetDefault("Abyssion Part");
            base.Tooltip.SetDefault("Reward for defeating Abyssion, The Forgotten One. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class BoreanStriderPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:BoreanStriderPopped");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/BoreanStriderPart_World";
            base.DisplayName.SetDefault("Borean Strider Part");
            base.Tooltip.SetDefault("Reward for defeating Borean Strider. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class BuriedChampionPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:TheBuriedWarrior");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/BuriedChampionPart_World";
            base.DisplayName.SetDefault("Buried Champion Part");
            base.Tooltip.SetDefault("Reward for defeating the Buried Champion. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class CoznixPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:FallenDeathBeholder");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/CoznixPart_World";
            base.DisplayName.SetDefault("Coznix Part");
            base.Tooltip.SetDefault("Reward for defeating Coznix, The Fallen Beholder. Swap a bunch for its drops or Treasure Bag.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            int p2 = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:FallenDeathBeholder2");
            if(p2 > 0)
            PartsGlobalNPC.addPartToNPC(p2,this);
        }
    }

    public class GrandThunderBirdPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:TheGrandThunderBirdv2");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/GrandThunderBirdPart_World";
            base.DisplayName.SetDefault("Grand Thunder Bird Part");
            base.Tooltip.SetDefault("Reward for defeating the Grand Thunder Bird. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class GraniteEnergyStormPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:GraniteEnergyStorm");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/GraniteEnergyStormPart_World";
            base.DisplayName.SetDefault("Granite Energy Storm Part");
            base.Tooltip.SetDefault("Reward for defeating the Granite Energy Storm. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class JellyfishQueenPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:QueenJelly");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/JellyfishQueenPart_World";
            base.DisplayName.SetDefault("Queen Jellyfish Part");
            base.Tooltip.SetDefault("Reward for defeating the Queen Jellyfish. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class LichPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:LichHeadless");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/LichPart_World";
            base.DisplayName.SetDefault("Lich Part");
            base.Tooltip.SetDefault("Reward for defeating the Lich. Swap a bunch for its drops or Treasure Bag.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            int p2 = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Lich");
            if (p2 > 0)
                PartsGlobalNPC.addPartToNPC(p2,this);
        }
    }

    public class RagnarokPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:RealityBreaker");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/RagnarokPart_World";
            base.DisplayName.SetDefault("Primordials Part");
            base.Tooltip.SetDefault("Reward for defeating any of the Primordials. Swap a bunch for its drops or Treasure Bag.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            int[] p2 = new int[]{
                ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Aquaius"),
                ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Omnicide"),
                ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:SlagFury")
            };
            foreach(int i in p2)
            {
                if(i != 0) PartsGlobalNPC.addPartToNPC(i,this);
            }
        }
    }

    public class StarScouterPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:ThePrimeScouter");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/StarScouterPart_World";
            base.DisplayName.SetDefault("Star Scouter Part");
            base.Tooltip.SetDefault("Reward for defeating the Start Scouter. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class ViscountPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Viscount");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/ViscountPart_World";
            base.DisplayName.SetDefault("Viscount Part");
            base.Tooltip.SetDefault("Reward for defeating the Viscount. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    //Mimics
    public class SubmergedMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:DepthMimic");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/SubmergedMimicPart_World";
            base.DisplayName.SetDefault("Submerged Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Submerged Mimic. Swap a bunch for its drops.");
        }
    }

    public class MyceliumMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:MyceliumMimic");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/MyceliumMimicPart_World";
            base.DisplayName.SetDefault("Mycelium Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Mycelium Mimic. Swap a bunch for its drops.");
        }
    }

    public class HellBringerMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:HellBringerMimic");
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/Bosses/HellBringerMimicPart_World";
            base.DisplayName.SetDefault("Hell Bringer Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Mycelium Mimic. Swap a bunch for its drops.");
        }
    }
}
