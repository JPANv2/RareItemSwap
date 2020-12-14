using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts.Calamity.Biomes;
using ARareItemSwapJPANs.Parts.Calamity.Events;
using ARareItemSwapJPANs.Parts.Calamity.Stages;
using ARareItemSwapJPANs.Parts.Vanilla;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Calamity
{
    public partial class CalamityModPartRepository : ModPartRepository
    {
        Mod mod;

        #region keywords
        /*mod keywords*/
        public const string modKeyword = "Calamity";
        public const string modClassKeyword = "CalamityMod";
        /*classes*/
        public const string rougeKeyword = "Rouge";
        public const string loreKeyword = "Lore";
        /*biomes*/
        public const string abyssKeyword = "Abyss";
        public const string astralKeyword = "Astral Infection";
        public const string cragsKeyword = "Brimstone Crag";
        public const string sulphurSeaKeyword = "Sulphurous Sea";
        public const string sunkenSeaKeyword = "Sunken Sea";
        /*events*/
        public const string acidRainKeyword = "Acid Rain";
        /*bosses*/
        public const string DesertScourge = "Desert Scourge";
        public const string Crabulon = "Crabulon";
        public const string HiveMind = "Hive Mind";
        public const string Perforators = "Perforators";
        public const string SlimeGod = "Slime God";
        public const string Cryogen = "Cryogen";
        public const string AquaticScourge = "Aquatic Scourge";
        public const string BrimstoneElemental = "Brimstone Elemental";
        public const string Calamitas = "Calamitas";
        public const string Leviathan = "Leviathan and Anahita";
        public const string AstrumAureus = "Astrum Aureus";
        public const string PlaguebringerGoliath = "Plaguebringer Goliath";
        public const string Ravager = "Ravager";
        public const string AstrumDeus = "Astrum Deus";
        public const string Providence = "Providence, the Profaned Goddess";
        public const string StormWeaver = "Storm Weaver";
        public const string CeaselessVoid = "Ceaseless Void";
        public const string Signus = "Signus, Envoy of the Devourer";
        public const string DevourerOfGods = "Devourer of Gods";
        public const string Polterghast = "Polterghast";
        public const string Dragonfolly = "Dragonfolly";
        public const string OldDuke = "Old Duke";
        public const string Yharon = "Yharon, Jungle Dragon";
        public const string SCalamitas = "Supreme Calamitas";
        /*npcs*/
        public const string Bandit = "Bandit";
        public const string SeaKing = "Sea King";
        public const string Archmage = "Archmage";
        public const string DrunkPrincess = "Drunk Princess";

        #endregion

        public override List<int> getBiomePartsDrops(NPC npc, Player p, List<int> parts)
        {
            if (mod != null)
            {
                if ((bool)mod.Call(new object[] { "GetInZone", p, "abyss" }))
                {
                    parts.Clear();
                    parts.Add(ModContent.ItemType<AbyssPart>());
                    return new List<int>();
                }
                if ((bool)mod.Call(new object[] { "GetInZone", p, "astral" }))
                {
                    parts.Clear();
                    if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                        parts.Add(ModContent.ItemType<AstralInfectionPart>());
                    else if (p.ZoneDirtLayerHeight)
                    {
                        parts.Add(ModContent.ItemType<AstralInfectionPart>());
                        parts.Add(ModContent.ItemType<UndergroundAstralInfectionPart>());
                    }
                    else
                        parts.Add(ModContent.ItemType<UndergroundAstralInfectionPart>());

                    return new List<int>();
                }
                if ((bool)mod.Call(new object[] { "GetInZone", p, "crags" }))
                {
                    parts.Clear();
                    parts.Add(ModContent.ItemType<CragsPart>());
                    return new List<int>();
                }
                if ((bool)mod.Call(new object[] { "GetInZone", p, "sunkensea" }))
                {
                    parts.Clear();
                    parts.Add(ModContent.ItemType<SunkenSeaPart>());
                    return new List<int>();
                }
                if ((bool)mod.Call(new object[] { "GetInZone", p, "sulphursea" }))
                {
                    parts.Clear();
                    parts.Add(ModContent.ItemType<SulfurSeaPart>());
                    return new List<int>();
                }
            }
            return base.getBiomePartsDrops(npc, p, parts);
        }

        public override List<int> getEventPartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            if (mod != null)
            {

                if ((bool)mod.Call(new object[] { "GetInZone", p, "sulphursea" }))
                {
                    Type w = mod.GetType().Assembly.GetType("CalamityMod.World.CalamityWorld");
                    if (w != null)
                    {
                        if ((bool)(w.GetField("rainingAcid", BindingFlags.Static | BindingFlags.Public).GetValue(null)))
                        {
                            listSoFar.Add(ModContent.ItemType<AcidRainPart>());
                        }
                    }
                    return new List<int>();
                }
            }
            return base.getEventPartsDrops(npc, p, listSoFar);
        }

        public override List<int> getStagePartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            if (mod != null)
            {
                if ((bool)mod.Call(new object[] { "GetBossDowned", "providence" }))
                {
                    listSoFar.Add(ModContent.ItemType<PostProvidencePart>());
                }
                if ((bool)mod.Call(new object[] { "GetBossDowned", "devourerofgods" }))
                {
                    listSoFar.Add(ModContent.ItemType<PostDevourerOfGodsPart>());
                }
                Type w = mod.GetType().Assembly.GetType("CalamityMod.World.CalamityWorld");
                if (w != null)
                {
                    if ((bool)(w.GetField("buffedEclipse", BindingFlags.Static | BindingFlags.Public).GetValue(null)))
                    {
                        listSoFar.Add(ModContent.ItemType<PostYharonPart>());
                    }
                }
                return new List<int>();
            }
            return base.getStagePartsDrops(npc, p, listSoFar);
        }

        public override void AddRecipes()
        {
            mod = Terraria.ModLoader.ModLoader.GetMod("CalamityMod");
            if (mod == null)
                return;
            makeBossRecipes();
             makeShopRecipes();
            makeBiomeRecipes();
            /* makeChestsAndFishingRecipes();
             makeMiscRecipes();*/
        }
    }
      
}
