using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Globals;
using Terraria.ID;

namespace ARareItemSwapJPANs.Parts.Vanilla.Bosses
{
    public class BetsyPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.DD2Betsy;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/BetsyPart_World";
            base.DisplayName.SetDefault("Betsy Part");
            base.Tooltip.SetDefault("Reward for defeating Betsy. Swap a bunch for its drops or Treasure Bag.");
        }
    }
    public class BrainOfCthulhuPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.BrainofCthulhu;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/BrainOfCthulhuPart_World";
            base.DisplayName.SetDefault("Brain Of Cthulhu Part");
            base.Tooltip.SetDefault("Reward for defeating the Brain Of Cthulhu. Swap a bunch for its drops or Treasure Bag.");
        }
    }


    public class DarkMagePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.DD2DarkMageT1;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/DarkMagePart_World";
            base.DisplayName.SetDefault("Dark Mage Part");
            base.Tooltip.SetDefault("Reward for defeating a Dark Mage. Swap a bunch for its drops.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartsGlobalNPC.addPartToNPC(NPCID.DD2DarkMageT3,this);
        }
    }

    public class DukeFishronPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.DukeFishron;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/DukeFishronPart_World";
            base.DisplayName.SetDefault("Duke Fishron Part");
            base.Tooltip.SetDefault("Reward for defeating Duke Fishron. Swap a bunch for its drops or Treasure Bag.");
        }
    }
    public class DungeonGuardianPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.DungeonGuardian;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/DungeonGuardianPart_World";
            base.DisplayName.SetDefault("Dungeon Guardian Part");
            base.Tooltip.SetDefault("Reward for defeating a Dungeon Guardian. Congratulations! Swap a bunch for its drops.");
        }
    }

    public class EaterOfWorldsPart : BossPart
    {

        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.EaterofWorldsHead;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/EaterOfWorldsPart_World";
            base.DisplayName.SetDefault("Eater Of Worlds Part");
            base.Tooltip.SetDefault("Reward for defeating the Eater Of Worlds. Swap a bunch for its drops or Treasure Bag.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartsGlobalNPC.addPartToNPC(NPCID.EaterofWorldsBody,this);
            PartsGlobalNPC.addPartToNPC(NPCID.EaterofWorldsTail,this);
        }
    }
    public class EverscreamPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Everscream;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/EverscreamPart_World";
            base.DisplayName.SetDefault("Everscream Part");
            base.Tooltip.SetDefault("Reward for defeating an Everscream. Swap a bunch for its drops.");
        }
    }

    public class EyeOfCthulhuPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.EyeofCthulhu;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/EyeOfCthulhuPart_World";
            base.DisplayName.SetDefault("Eye Of Cthulhu Part");
            base.Tooltip.SetDefault("Reward for defeating the Eye Of Cthulhu. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class FlyingDutchmanPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.PirateShip;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/FlyingDutchmanPart_World";
            base.DisplayName.SetDefault("Flying Dutchman Part");
            base.Tooltip.SetDefault("Reward for defeating a Flying Dutchman. Swap a bunch for its drops.");
        }
    }

    public class GoblinSummonerPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.GoblinSummoner;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/GoblinSummonerPart_World";
            base.DisplayName.SetDefault("Goblin Summoner Part");
            base.Tooltip.SetDefault("Reward for defeating a Goblin Summoner. Swap a bunch for its drops.");
        }
    }

    public class GolemPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Golem;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/GolemPart_World";
            base.DisplayName.SetDefault("Golem Part");
            base.Tooltip.SetDefault("Reward for defeating the Golem. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class IceQueenPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.IceQueen;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/IceQueenPart_World";
            base.DisplayName.SetDefault("Ice Queen Part");
            base.Tooltip.SetDefault("Reward for defeating an Ice Queen. Swap a bunch for its drops.");
        }
    }

    public class KingSlimePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.KingSlime;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/KingSlimePart_World";
            base.DisplayName.SetDefault("King Slime Part");
            base.Tooltip.SetDefault("Reward for defeating the King Slime. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class LunaticCultistPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.CultistBoss;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/LunaticCultistPart_World";
            base.DisplayName.SetDefault("Lunatic Cultist Part");
            base.Tooltip.SetDefault("Reward for defeating the Lunatic Cultist. Swap a bunch for its drops(?) or Treasure Bag?");
        }
    }

    public class MartianSaucerPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.MartianSaucer;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/MartianSaucerPart_World";
            base.DisplayName.SetDefault("Martian Saucer Part");
            base.Tooltip.SetDefault("Reward for defeating a Martian Saucer. Swap a bunch for its drops.");
        }
    }

    public class MoonLordPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.MoonLordCore;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/MoonLordPart_World";
            base.DisplayName.SetDefault("Moon Lord Part");
            base.Tooltip.SetDefault("Reward for defeating the Moon Lord. Swap a bunch for its drops or Treasure Bag.");
        }
    }
    public class MourningWoodPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.MourningWood;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/MourningWoodPart_World";
            base.DisplayName.SetDefault("Mourning Wood Part");
            base.Tooltip.SetDefault("Reward for defeating a Mourning Wood. Swap a bunch for its drops.");
        }
    }
    public class OgrePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.DD2OgreT2;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/OgrePart_World";
            base.DisplayName.SetDefault("Ogre Part");
            base.Tooltip.SetDefault("Reward for defeating an Ogre. Swap a bunch for its drops.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartsGlobalNPC.addPartToNPC(NPCID.DD2OgreT3,this);
        }
    }

    public class PlanteraPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Plantera;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/PlanteraPart_World";
            base.DisplayName.SetDefault("Plantera Part");
            base.Tooltip.SetDefault("Reward for defeating Plantera. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class PumpkingPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Pumpking;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/PumpkingPart_World";
            base.DisplayName.SetDefault("Pumpking Part");
            base.Tooltip.SetDefault("Reward for defeating a Pumpking. Swap a bunch for its drops.");
        }
    }
    public class QueenBeePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.QueenBee;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/QueenBeePart_World";
            base.DisplayName.SetDefault("Queen Bee Part");
            base.Tooltip.SetDefault("Reward for defeating the Queen Bee. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class RareEnemyPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/PumpkingPart_World";
            base.DisplayName.SetDefault("Rare Enemy Part");
            base.Tooltip.SetDefault("Reward for defeating a Rare Enemy!");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartsGlobalNPC.addPartToNPC(NPCID.WyvernHead, this);
            PartsGlobalNPC.addPartToNPC(NPCID.BoneLee,this);
            PartsGlobalNPC.addPartToNPC(NPCID.DungeonSlime,this);
            PartsGlobalNPC.addPartToNPC(NPCID.GoblinScout,this);
            PartsGlobalNPC.addPartToNPC(NPCID.LostGirl,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Nymph,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Paladin,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Pinky,this);
            PartsGlobalNPC.addPartToNPC(NPCID.RainbowSlime,this);
            PartsGlobalNPC.addPartToNPC(NPCID.DoctorBones,this);
            PartsGlobalNPC.addPartToNPC(NPCID.IceGolem,this);
            PartsGlobalNPC.addPartToNPC(NPCID.SandElemental,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Moth,this);
            PartsGlobalNPC.addPartToNPC(NPCID.RuneWizard,this);
            PartsGlobalNPC.addPartToNPC(NPCID.SkeletonCommando,this);
            PartsGlobalNPC.addPartToNPC(NPCID.SkeletonSniper,this);
            PartsGlobalNPC.addPartToNPC(NPCID.TacticalSkeleton,this);
            PartsGlobalNPC.addPartToNPC(NPCID.TheBride,this);
            PartsGlobalNPC.addPartToNPC(NPCID.TheGroom,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Tim,this);
            PartsGlobalNPC.addPartToNPC(NPCID.UndeadMiner,this);
            PartsGlobalNPC.addPartToNPC(NPCID.DiabolistRed,this);
            PartsGlobalNPC.addPartToNPC(NPCID.RaggedCaster,this);
            PartsGlobalNPC.addPartToNPC(NPCID.RaggedCasterOpenCoat,this);
            PartsGlobalNPC.addPartToNPC(NPCID.Necromancer,this);
            PartsGlobalNPC.addPartToNPC(NPCID.NecromancerArmored,this);
        }
    }

    public class SantaNK1Part : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.SantaNK1;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/SantaNK1Part_World";
            base.DisplayName.SetDefault("Santa-NK1 Part");
            base.Tooltip.SetDefault("Reward for defeating a Santa-NK1. Swap a bunch for its drops.");
        }
    }
    public class SkeletronPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.SkeletronHead;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/SkeletronPart_World";
            base.DisplayName.SetDefault("Skeletron Part");
            base.Tooltip.SetDefault("Reward for defeating Skeletron. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class SkeletronPrimePart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.SkeletronPrime;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/SkeletronPrimePart_World";
            base.DisplayName.SetDefault("Skeletron Prime Part");
            base.Tooltip.SetDefault("Reward for defeating Skeletron Prime. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class TheDestroyerPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.TheDestroyer;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/TheDestroyerPart_World";
            base.DisplayName.SetDefault("The Destroyer Part");
            base.Tooltip.SetDefault("Reward for defeating The Destroyer. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class TheTwinsPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Spazmatism;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/TheTwinsPart_World";
            base.DisplayName.SetDefault("The Twins Part");
            base.Tooltip.SetDefault("Reward for defeating Spasmatism or Retinazer. Swap a bunch for their drops or Treasure Bag.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartsGlobalNPC.addPartToNPC(NPCID.Retinazer,this);
        }
    }

    public class WallOfFleshPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.WallofFlesh;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/WallOfFleshPart_World";
            base.DisplayName.SetDefault("Wall Of Flesh Part");
            base.Tooltip.SetDefault("Reward for defeating the Wall Of Flesh. Swap a bunch for its drops or Treasure Bag.");
        }
    }

    public class CorruptionMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.BigMimicCorruption;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/CorruptionMimicPart_World";
            base.DisplayName.SetDefault("Corruption Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Corruption Mimic. Swap a bunch for its drops.");
        }
    }

    public class CrimsonMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.BigMimicCrimson;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/CrimsonMimicPart_World";
            base.DisplayName.SetDefault("Crimson Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Crimson Mimic. Swap a bunch for its drops.");
        }
    }

    public class HallowedMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.BigMimicHallow;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/HallowedMimicPart_World";
            base.DisplayName.SetDefault("Hallowed Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Hallowed Mimic. Swap a bunch for its drops.");
        }
    }

    public class JungleMimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.BigMimicJungle;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/JungleMimicPart_World";
            base.DisplayName.SetDefault("Jungle Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Jungle Mimic. Swap a bunch for its drops.");
        }
    }

    public class MimicPart : BossPart
    {
        public override void SetStaticDefaults()
        {
            base.bossID = NPCID.Mimic;
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/Bosses/MimicPart_World";
            base.DisplayName.SetDefault("Mimic Part");
            base.Tooltip.SetDefault("Reward for defeating a Mimic. Swap a bunch for its drops.");
        }
    }
}
