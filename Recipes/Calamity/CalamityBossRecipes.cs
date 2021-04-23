using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Common.Globals;
using ARareItemSwapJPANs.Parts.Calamity.Biomes;
using ARareItemSwapJPANs.Parts.Calamity.Bosses;
using ARareItemSwapJPANs.Parts.Calamity.Events;
using ARareItemSwapJPANs.Parts.Calamity.Stages;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Calamity
{
    public partial class CalamityModPartRepository : ModPartRepository
    {

        private void makeBossRecipes()
        {
            makeDesertScourgeRecipes();
            makeCrabulonRecipes();
            makeHiveMindRecipes();
            makePerforatorsRecipes();
            makeSlimeGodRecipes();
            makeCryogenRecipes();
            makeAquaticScourgeRecipes();
            makeBrimstoneElementalRecipes();
            makeCalamitasRecipes();
            makeLeviathanRecipes();
            makeAstrumAureusRecipes();
            makePlaguebringerGoliathRecipes();
            makeRavagerRecipes();
            makeAstrumDeusRecipes();
            makeProvidenceRecipes();
            makeStormWeaverRecipes();
            makeCeaslessVoidRecipes();
            makeSignusRecipes();
            makeDevourerOfGodsRecipes();
            makePolterghastRecipes();
            makeDragonfollyRecipes();
            makeOldDukeRecipes();
            makeYharonRecipes();
            makeSCalamitasRecipes();

            makeRareEnemyRecipes();
            makeVanillaBossRecipes();
        }

        private void makeVanillaBossRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            /*int partType = ModContent.ItemType<DesertScourgePart>();
            string bossName = DesertScourge;*/
          
            /*knowledges/lore*/
            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, KingSlimeKeyword, modClassKeyword + ":" + "KnowledgeKingSlime", 1, ModContent.ItemType<KingSlimePart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, eocKeyword, modClassKeyword + ":" + "KnowledgeEyeofCthulhu", 1, ModContent.ItemType<EyeOfCthulhuPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bocKeyword, modClassKeyword + ":" + "KnowledgeBrainofCthulhu", 1, ModContent.ItemType<BrainOfCthulhuPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, eowKeyword, modClassKeyword + ":" + "KnowledgeEaterofWorlds", 1, ModContent.ItemType<EaterOfWorldsPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bocKeyword, modClassKeyword + ":" + "KnowledgeCrimson", 1, ModContent.ItemType<BrainOfCthulhuPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, eowKeyword, modClassKeyword + ":" + "KnowledgeCorruption", 1, ModContent.ItemType<EaterOfWorldsPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, queenBeeKeyword, modClassKeyword + ":" + "KnowledgeQueenBee", 1, ModContent.ItemType<QueenBeePart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, skeletronKeyword, modClassKeyword + ":" + "KnowledgeSkeletron", 1, ModContent.ItemType<SkeletronPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "KnowledgeWallofFlesh", 1, ModContent.ItemType<WallOfFleshPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "KnowledgeUnderworld", 1, ModContent.ItemType<WallOfFleshPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, destroyerKeyword, modClassKeyword + ":" + "KnowledgeDestroyer", 1, ModContent.ItemType<TheDestroyerPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, twinsKeyword, modClassKeyword + ":" + "KnowledgeTwins", 1, ModContent.ItemType<TheTwinsPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, skeletronPrimeKeyword, modClassKeyword + ":" + "KnowledgeSkeletronPrime", 1, ModContent.ItemType<SkeletronPrimePart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, skeletronPrimeKeyword, modClassKeyword + ":" + "KnowledgeMechs", 1, ModContent.ItemType<SkeletronPrimePart>(), 7, new List<string>() { loreKeyword });
            working.addPart(ModContent.ItemType<TheTwinsPart>(), 7);
            working.addPart(ModContent.ItemType<TheDestroyerPart>(), 7);
            working.addCategoryAndSubcategories(makeByBossCategories(new List<string>() { loreKeyword }, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(new List<string>() { loreKeyword }, twinsKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, planteraKeyword, modClassKeyword + ":" + "KnowledgePlantera", 1, ModContent.ItemType<PlanteraPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, golemKeyword, modClassKeyword + ":" + "KnowledgeGolem", 1, ModContent.ItemType<GolemPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, dukeFishronKeyword, modClassKeyword + ":" + "KnowledgeDukeFishron", 1, ModContent.ItemType<DukeFishronPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, cultistKeyword, modClassKeyword + ":" + "KnowledgeLunaticCultist", 1, ModContent.ItemType<LunaticCultistPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, cultistKeyword, modClassKeyword + ":" + "KnowledgeBloodMoon", 1, ModContent.ItemType<LunaticCultistPart>(), 18, new List<string>() { loreKeyword });
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 2);
            working.addCategoryAndSubcategories(makeByEventCategories(new List<string>() { loreKeyword }, bloodMoonKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, moonLordKeyword, modClassKeyword + ":" + "KnowledgeMoonLord", 1, ModContent.ItemType<MoonLordPart>(), 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            /*misc items*/
            working = makeSimpleBossPartRecipe(modKeyword, KingSlimeKeyword, modClassKeyword + ":" + "CrownJewel", 1, ModContent.ItemType<KingSlimePart>(), 250, makeAccessoryCategories(buffsKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, eocKeyword, modClassKeyword + ":" + "VictoryShard", 1, ModContent.ItemType<EyeOfCthulhuPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, eocKeyword, modClassKeyword + ":" + "TeardropCleaver", 1, ModContent.ItemType<EyeOfCthulhuPart>(), 35, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, eocKeyword, modClassKeyword + ":" + "CounterScarf", 1, ModContent.ItemType<EyeOfCthulhuPart>(), 250, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, queenBeeKeyword, modClassKeyword + ":" + "HardenedHoneycomb", 15, ModContent.ItemType<QueenBeePart>(), 1, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, skeletronKeyword, modClassKeyword + ":" + "ClothiersWrath", 1, ModContent.ItemType<SkeletronPart>(), 200, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "RogueEmblem", 1, ModContent.ItemType<WallOfFleshPart>(), 20, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "Meowthrower", 1, ModContent.ItemType<WallOfFleshPart>(), 20,makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "BlackHawkRemote", 1, ModContent.ItemType<WallOfFleshPart>(), 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "BlastBarrel", 1, ModContent.ItemType<WallOfFleshPart>(), 20, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "MLGRune", 1, ModContent.ItemType<WallOfFleshPart>(), 5, new List<string>() { utilityKeyword});
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, wofKeyword, modClassKeyword + ":" + "IbarakiBox", 1, ModContent.ItemType<WallOfFleshPart>(), 5, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, skeletronPrimeKeyword, modClassKeyword + ":" + "GoldBurdenBreaker", 1, ModContent.ItemType<SkeletronPrimePart>(), 250, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, destroyerKeyword, modClassKeyword + ":" + "SHPC", 1, ModContent.ItemType<TheDestroyerPart>(), 25000, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, planteraKeyword, modClassKeyword + ":" + "LivingShard", 5, ModContent.ItemType<PlanteraPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, planteraKeyword, modClassKeyword + ":" + "BlossomFlux", 1, ModContent.ItemType<PlanteraPart>(), 25000, makeWeaponsCategories(rangedDamageKeyword , bowWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, golemKeyword, modClassKeyword + ":" + "AegisBlade", 1, ModContent.ItemType<GolemPart>(), 25000, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, golemKeyword, modClassKeyword + ":" + "LeadWizard", 1, ModContent.ItemType<GolemPart>(), 200, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, dukeFishronKeyword, modClassKeyword + ":" + "BrinyBaron", 1, ModContent.ItemType<DukeFishronPart>(), 25000, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, dukeFishronKeyword, modClassKeyword + ":" + "DukesDecapitator", 1, ModContent.ItemType<DukeFishronPart>(), 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, cultistKeyword, modClassKeyword + ":" + "StardustStaff", 1, ModContent.ItemType<LunaticCultistPart>(), 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, cultistKeyword, modClassKeyword + ":" + "ThornBlossom", 1, ModContent.ItemType<LunaticCultistPart>(), 200, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, moonLordKeyword, modClassKeyword + ":" + "UtensilPoker", 1, ModContent.ItemType<MoonLordPart>(), 40, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, moonLordKeyword, modClassKeyword + ":" + "GrandDad", 1, ModContent.ItemType<MoonLordPart>(), 200, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, moonLordKeyword, modClassKeyword + ":" + "Infinity", 1, ModContent.ItemType<MoonLordPart>(), 200, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, betsyKeyword, modClassKeyword + ":" + "Vesuvius", 1, ModContent.ItemType<BetsyPart>(), 25000, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, martianSaucerKeyword, modClassKeyword + ":" + "NullificationRifle", 1, ModContent.ItemType<MartianSaucerPart>(), 35, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, goblinSummonerKeyword, modClassKeyword + ":" + "TheFirstShadowflame", 1, ModContent.ItemType<GoblinSummonerPart>(), 40, makeAccessoryCategories(summonerDamageKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, goblinSummonerKeyword, modClassKeyword + ":" + "BurningStrife", 1, ModContent.ItemType<GoblinSummonerPart>(), 40, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeRareEnemyRecipes()
        {
            /*Abyss rare enemies*/
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "EidolonWyrmHeadHuge"), ModContent.GetInstance<RareEnemyPart>());
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "EidolonWyrmHead"), ModContent.GetInstance<RareEnemyPart>());

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int rarePart = ModContent.ItemType<RareEnemyPart>();
            int biomePart = ModContent.ItemType<AbyssPart>();
            PartRecipe working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "Lumenite", 5, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "Voidstone", 10, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "HalibutCannon", 1, biomePart, 25000, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 200);
            recipes.Add(working);
            int stagePart = ModContent.ItemType<PostDevourerOfGodsPart>();
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "SoulEdge", 1, biomePart, 30, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(rarePart, 20);
            working.addPart(stagePart, 10);
            recipes.Add(working); 
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "EidolicWail", 1, biomePart, 30, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 20);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "ColossalSquid"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "CalamarisLament", 1, biomePart, 30, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 20);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "InkBomb", 1, biomePart, 50, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "DepthCells", 12, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "Reaper"), ModContent.GetInstance<RareEnemyPart>());
         /*   working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "CloakingGland", 1, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);*/
            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "ReaperTooth", 1, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "DeepSeaDumbbell", 1, biomePart, 30, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "Valediction", 1, biomePart, 30, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, abyssKeyword, modClassKeyword + ":" + "TheReaper", 1, biomePart, 300, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(rarePart, 50);
            working.addPart(stagePart, 30);
            recipes.Add(working);

            /*Sulphuric sea/acid rain*/
            biomePart = ModContent.ItemType<SulfurSeaPart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "Mauler"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, sulphurSeaKeyword, modClassKeyword + ":" + "SulphuricAcidCannon", 1, biomePart, 30, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            biomePart = ModContent.ItemType<AcidRainPart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "CragmawMire"), ModContent.GetInstance<RareEnemyPart>());
            stagePart = ModContent.ItemType<HardmodePart>();
            working = makeSimpleEventPartRecipe(modKeyword,acidRainKeyword, modClassKeyword + ":" + "SpentFuelContainer", 1, biomePart, 20, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, acidRainKeyword, modClassKeyword + ":" + "NuclearRod", 1, biomePart, 20, makeAccessoryCategories(offenseKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);

            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "NuclearTerror"), ModContent.GetInstance<RareEnemyPart>());
            stagePart = ModContent.ItemType<PostDevourerOfGodsPart>();
            working = makeSimpleEventPartRecipe(modKeyword, acidRainKeyword, modClassKeyword + ":" + "GammaHeart", 1, biomePart, 30, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);

            /*desert*/
            biomePart = ModContent.ItemType<DesertSurfacePart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "Cnidrion"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword,desertBiomeKeyword, modClassKeyword + ":" + "VictoryShard", 5, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "AmidiasSpark", 1, biomePart, 40, makeAccessoryCategories(defenseKeyword));
            working.addPart(rarePart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "TheTransformer", 1, biomePart, 200, makeAccessoryCategories(defenseKeyword));
            working.addPart(rarePart, 50);
            recipes.Add(working);
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "StormlionCharger"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "StormlionMandible", 2, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working); 
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "StormjawStaff", 1, biomePart, 10, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);

            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "GreatSandShark"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "GrandScale", 2, biomePart, 5, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 5);
            working.irreversible = true;
            recipes.Add(working);

            /*sky*/
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "ThiccWaifu"), ModContent.GetInstance<RareEnemyPart>());
            biomePart = ModContent.ItemType<SkySurfacePart>();
            working = makeSimpleBiomePartRecipe(modKeyword, skyBiomeKeyword, modClassKeyword + ":" + "EyeoftheStorm", 1, biomePart, 20, makeAccessoryCategories(summonerDamageKeyword));
            working.addPart(rarePart, 20);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, skyBiomeKeyword, modClassKeyword + ":" + "StormSaber", 1, biomePart, 40, makeWeaponsCategories(meleeDamageKeyword,swordWeaponKeyword));
            working.addPart(rarePart, 20);
            recipes.Add(working);

            /*Jungle*/
            biomePart = ModContent.ItemType<JungleSurfacePart>();
            stagePart = ModContent.ItemType<PostPlanteraPart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "PlaguebringerShade"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "PlagueCellCluster", 6, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "PlaguedFuelPack", 1, biomePart, 100, makeAccessoryCategories(offenseKeyword));
            working.addPart(rarePart, 30);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "PlagueCaller", 1, biomePart, 40, makePetsCategories(normalPetsKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 10);
            recipes.Add(working);

            /*underground*/
            biomePart = ModContent.ItemType<ForestUndergroundPart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "Horse"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "EarthenPike", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "Aftershock", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "SlagMagnum", 1, biomePart, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "AridArtifact", 1, biomePart, 10, new List<string>() { utilityKeyword });
            working.addPart(rarePart, 3);
            recipes.Add(working);

            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "ArmoredDiggerHead"), ModContent.GetInstance<RareEnemyPart>());
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "DemonicBoneAsh", 2, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "MysteriousCircuitry", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "DubiousPlating", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "DraedonsRemote", 1, biomePart, 10, new List<string>() { utilityKeyword });
            working.addPart(rarePart, 3);
            working.addPart(stagePart, 1);
            recipes.Add(working);

            /*sunken sea*/
            biomePart = ModContent.ItemType<SunkenSeaPart>();
            PartsGlobalNPC.addPartToNPC(ARareItemSwapJPANs.getNPCTypeFromTag(modClassKeyword + ":" + "GiantClam"), ModContent.GetInstance<RareEnemyPart>());
            stagePart = ModContent.ItemType<HardmodePart>();
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "MolluskHusk", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.addPart(stagePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "Navystone", 200, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(rarePart, 1);
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "GiantPearl", 1, biomePart, 20, makeAccessoryCategories(debuffsKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "AmidiasPendant", 1, biomePart, 20, makeAccessoryCategories(offenseKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "ClamCrusher", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword));
            working.addPart(rarePart, 5);
            working.addPart(stagePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "ClamorRifle", 1, biomePart, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 5);
            working.addPart(stagePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "Poseidon", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            working.addPart(rarePart, 5);
            working.addPart(stagePart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, sunkenSeaKeyword, modClassKeyword + ":" + "ShellfishStaff", 1, biomePart, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(rarePart, 5);
            working.addPart(stagePart, 5);
            recipes.Add(working);

            //other rare enemy drops
            biomePart = ModContent.ItemType<DesertSurfacePart>();
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "WifeinaBottle", 1, biomePart, 50, makeAccessoryCategories(summonerDamageKeyword));
            working.addPart(rarePart, 10);
            working.addPart(stagePart, 15);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "WifeinaBottlewithBoobs", 1, biomePart, 250, makeAccessoryCategories(summonerDamageKeyword));
            working.addPart(rarePart, 30);
            working.addPart(stagePart, 35);
            recipes.Add(working);
            biomePart = ModContent.ItemType<ForestUndergroundPart>();
            working = makeSimpleBiomePartRecipe(modKeyword, forestBiomeKeyword, modClassKeyword + ":" + "EyeofMagnus", 1, biomePart, 30, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            working.addPart(rarePart, 30);
            working.addPart(stagePart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, forestBiomeKeyword, modClassKeyword + ":" + "PlasmaRod", 1, biomePart, 50, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            working.addPart(rarePart, 5);
            recipes.Add(working);





            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDesertScourgeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<DesertScourgePart>();
            string bossName = DesertScourge;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DesertScourgeBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DesertScourgeTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DesertScourgeMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeDesertScourge", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OceanCrest", 1, partType, 100, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VictoryShard", 3, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SandyAnglingKit", 1, partType, 5, new List<string>() { otherKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AquaticDischarge", 1, partType, 20,makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Barinade", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "StormSpray", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SeaboundStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ScourgeoftheDesert", 1, partType, 20, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DuneHopper", 1, partType, 250, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SandCloak", 1, partType, 50, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            workingCategories = makeAccessoryCategories(movementKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AeroStone", 1, partType, 50, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DeepDiver", 1, partType, 250, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DriedSeafood", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makeCrabulonRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<CrabulonPart>();
            string bossName = Crabulon;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrabulonBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrabulonTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrabulonMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeCrabulon", 1, partType, 20, new List<string>() { loreKeyword });

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FungalClump", 1, partType, 100, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "MycelialClaws", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Fungicide", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HyphaeRod", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Shroomerang", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Mycoroot", 1, partType, 20, makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword));
            recipes.Add(working);
           

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DecapoditaSprout", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeHiveMindRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<HiveMindPart>();
            string bossName = HiveMind;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HiveMindBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HiveMindTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HiveMindMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeHiveMind", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            workingCategories = makeAccessoryCategories(defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodyWormTooth", 1, partType, 100, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TrueShadowScale", 8, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PerfectDark", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeechingDagger", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Shadethrower", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ShadowdropStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ShaderainStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DankStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RotBall", 10, partType, 1, makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FilthyGlove", 1, partType, 20, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Teratoma", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makePerforatorsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<PerforatorHivePart>();
            string bossName = Perforators;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PerforatorBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PerforatorTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PerforatorMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgePerforators", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RottenBrain", 1, partType, 100, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodSample", 8, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VeinBurster", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodyRupture", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SausageMaker", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Aorta", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Eviscerator", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodBath", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodClotStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ToothBall", 10, partType, 1, makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodstainedGlove", 1, partType, 20, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodyVein", 1, partType, 50, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodyWormFood", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        private void makeSlimeGodRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<SlimeGodPart>();
            string bossName = SlimeGod;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SlimeGodBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SlimeGodTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SlimeGodMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SlimeGodMask2", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeSlimeGod", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ManaOverloader", 1, partType, 100, makeAccessoryCategories(manaKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PurifiedGel", 10, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OverloadedBlaster", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AbyssalTome", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EldritchTome", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CorroslimeStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrimslimeStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PurifiedJam", 1, partType, 50, new List<string>() { potionKeyword });
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OverloadedSludge", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCryogenRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<CryogenPart>();
            string bossName = Cryogen;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryogenBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryogenTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryogenMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeCryogen", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SoulofCryogen", 1, partType, 100, makeAccessoryCategories(movementKeyword, movementFlyingKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FrostFlare", 1, partType, 250, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ColdDivinity", 1, partType, 25000, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryoBar", 5, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EssenceofEleum", 5, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);

            workingCategories = makeAccessoryCategories(defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryoStone", 1, partType, 50, workingCategories);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Regenator", 1, partType, 200, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
     
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Avalanche", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GlacialCrusher", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EffluviumBow", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BittercoldStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SnowstormStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Icebreaker", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);
           
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CryoKey", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAquaticScourgeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<AquaticScourgePart>();
            string bossName = AquaticScourge;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AquaticScourgeBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AquaticScourgeTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AquaticScourgeMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeAquaticScourge", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeSulphurSea", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AquaticEmblem", 1, partType, 100, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VictoryShard", 5, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BleachedAnglingKit", 1, partType, 5, new List<string>() { otherKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SubmarineShocker", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Barinautical", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Downpour", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DeepseaStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ScourgeoftheSeas", 1, partType, 20, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            recipes.Add(working);
           
            workingCategories = makeAccessoryCategories(movementKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AeroStone", 1, partType, 50, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CorrosiveSpine", 1, partType, 1000, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SeasSearing", 1, partType, 25000, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Seafood", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBrimstoneElementalRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<BrimstoneElementalPart>();
            string bossName = BrimstoneElemental;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneWaifuBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneElementalTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneWaifuMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeBrimstoneElemental", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeBrimstoneCrag", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Gehenna", 1, partType, 100, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EssenceofChaos", 2, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Abaddon", 1, partType, 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Brimlance", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SeethingDischarge", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DormantBrimseeker", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            workingCategories = makeAccessoryCategories(summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RoseStone", 1, partType, 50, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CharredRelic", 1, partType, 250, makePetsCategories(normalPetsKeyword));
            recipes.Add(working); 

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Brimrose", 1, new List<int>() { partType, 250, ModContent.ItemType<PostProvidencePart>(), 5 }, new List<string>() { mountKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Bloodstone", 10, new List<int>() { partType, 1, ModContent.ItemType<PostProvidencePart>(), 1 }, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CharredIdol", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCalamitasRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<CalamitasPart>();
            string bossName = Calamitas;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamitasBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamitasTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CataclysmTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CatastropheTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamitasMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeCalamitasClone", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamityRing", 1, partType, 100, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ChaosStone", 1, partType, 50, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneFlamesprayer", 1, partType, 50, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneFlameblaster", 1, partType, 50, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrushsawCrasher", 1, partType, 50, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
           
            
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamityDust", 1, partType, 3, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EssenceofChaos", 1, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlightedLens", 2, partType, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Animosity", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheEyeofCalamitas", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamitasInferno", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlightedEyeStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlightedEyeball", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLeviathanRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<LeviathanPart>();
            string bossName = Leviathan;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeviathanBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeviathanTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AnahitaTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeviathanMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AnahitaMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeLeviathanandSiren", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeOcean", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeviathanAmbergris", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheCommunity", 1, partType, 25000, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);

            workingCategories = makeAccessoryCategories(summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LureofEnthrallment", 1, partType, 40, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Greentide", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Leviatitan", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SirensSong", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Atlantis", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GastricBelcherStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrackishFlask", 1, partType, 20, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeviathanTeeth", 1, partType, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SirensHeart", 1, partType, 50, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);
            

            /*working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Seafood", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);*/

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAstrumAureusRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<AstrumAureusPart>();
            string bossName = AstrumAureus;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstrageldonBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstrageldonTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AureusMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeAstrumAureus", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
           
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GravistarSabaton", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LeonidProgenitor", 1, partType, 25000, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SquishyBeanMount", 1, partType, 250, new List<string>() { mountKeyword});
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 5);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            workingCategories.AddRange(new List<string>() { potionKeyword } );
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstralJelly", 3, partType, 1, workingCategories);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Stardust", 8, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Nebulash", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AuroraBlazer", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AlulaAustralis", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BorealisBomber", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AuroradicalThrow", 1, partType, 20, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            recipes.Add(working);           


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstralChunk", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePlaguebringerGoliathRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<PlaguebringerGoliathPart>();
            string bossName = PlaguebringerGoliath;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlaguebringerGoliathBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlaguebringerGoliathTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlaguebringerGoliathMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgePlaguebringerGoliath", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ToxicHeart", 1, partType, 100, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Malachite", 1, partType, 25000, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloomStone", 1, partType, 50, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlagueCaller", 1, partType, 50, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "InfectedArmorPlating", 4, partType, 1, workingCategories);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlagueCellCluster", 3, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VirulentKatana", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DiseasedPike", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ThePlaguebringer", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Malevolence", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PestilentDefiler", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheHive", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword,launcherWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "MepheticSprayer", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PlagueStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FuelCellBundle", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "InfectedRemote", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheSyringe", 1, partType, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Abomination", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeRavagerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<RavagerPart>();
            string bossName = Ravager;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RavagerBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RavagerTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RavagerMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeRavager", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CorpusAvertorMelee", 1, partType, 4000, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CorpusAvertor", 1, partType, 4000, makeWeaponsCategories(rougeKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodflareCore", 1, partType, 100, makeAccessoryCategories(lifeKeyword));
            working.addPart(ModContent.ItemType<PostProvidencePart>(), 5);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FleshTotem", 1, partType, 40, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodPact", 1, partType, 40, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FleshyGeodeT1", 1, partType, 5, workingCategories);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FleshyGeodeT2", 1, partType, 5, workingCategories);
            working.addPart(ModContent.ItemType<PostProvidencePart>(), 1);
            recipes.Add(working);
           
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "UltimusCleaver", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RealmRavager", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Hematemesis", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SpikecragStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CraniumSmasher", 1, partType, 20, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientMedallion", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAstrumDeusRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<AstrumDeusPart>();
            string bossName = AstrumDeus;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstrumDeusBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstrumDeusTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstrumDeusMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeAstrumDeus", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeAstralInfection", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AstralBulwark", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HideofAstrumDeus", 1, partType, 500, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Quasar", 1, partType, 500, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ChromaticOrb", 1, partType, 50, makePetsCategories(lightPetsKeyword));
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Stardust", 21, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);
 
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheMicrowave", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "StarSputter", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Starfall", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GodspawnHelixStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RegulusRiot", 1, partType, 20, makeWeaponsCategories(rougeKeyword,otherKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Starcore", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeProvidenceRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<ProvidencePart>();
            string bossName = Providence;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProvidenceBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProvidenceTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProvidenceMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedGuardianTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedGuardianMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeProvidence", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeProfanedGuardians", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlazingCore", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ElysianAegis", 1, partType, 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ElysianWings", 1, partType, 20, makeAccessoryCategories(movementKeyword, movementFlyingKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PristineFury", 1, partType, 25000, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SamuraiBadge", 1, partType, 500, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedSoulCrystal", 1, partType, 25000, makeAccessoryCategories(otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedMoonlightDye", 1, partType, 20, new List<string>() { dyeKeyword});
            working.addPart(ModContent.ItemType<DyePart>(), 1);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "UnholyEssence", 7, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DivineGeode", 6, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);

           
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HolyCollider", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SolarFlare", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TelluricGlare", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlissfulBombardier", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PurgeGuzzler", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DazzlingStabberStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "MoltenAmputator", 1, partType, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RelicOfDeliverance", 1, partType, 50, makeWeaponsCategories(trueDamageKeyword, spearWeaponKeyword), isProvidenceDefeated);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RelicOfConvergence", 1, partType, 50, new List<string>() { utilityKeyword }, isProvidenceDefeated);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RelicOfResilience", 1, partType, 50, new List<string>() { utilityKeyword }, isProvidenceDefeated);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RuneofCos", 5, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedCoreUnlimited", 5, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedCore", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        public bool isProvidenceDefeated()
        {
            return (bool)mod.Call(new object[] { "GetBossDowned", "providence" });
        }

        private void makeStormWeaverRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<StormWeaverPart>();
            string bossName = StormWeaver;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "WeaverTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "StormWeaverMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeSentinels", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ArmoredShell", 1, partType, 2, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheStorm", 1, partType, 50, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "StormDragoon", 1, partType, 50, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Thunderstorm", 1, partType, 500, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerHelm", 1, partType, 80, makeArmorCategories(armorHeadKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerChestplate", 1, partType, 80, makeArmorCategories(armorBodyKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerLeggings", 1, partType, 80, makeArmorCategories(armorLegsKeyword));
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCeaslessVoidRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<CeaselessVoidPart>();
            string bossName = CeaselessVoid;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CeaselessVoidTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CeaselessVoidMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeSentinels", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
          
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DarkPlasma", 1, partType, 1, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "MirrorBlade", 1, partType, 50, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ArcanumoftheVoid", 1, partType, 50, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheEvolution", 1, partType, 500, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerHelm", 1, partType, 80, makeArmorCategories(armorHeadKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerChestplate", 1, partType, 80, makeArmorCategories(armorBodyKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerLeggings", 1, partType, 80, makeArmorCategories(armorLegsKeyword));
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSignusRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<SignusPart>();
            string bossName = Signus;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SignusTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SignusMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeSentinels", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TwistingNether", 1, partType, 1, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CosmicKunai", 1, partType, 50, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Cosmilamp", 1, partType, 50, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "LanternoftheSoul", 1, partType, 500, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword));
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SpectralVeil", 1, partType, 1000, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerHelm", 1, partType, 80, makeArmorCategories(armorHeadKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerChestplate", 1, partType, 80, makeArmorCategories(armorBodyKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AncientGodSlayerLeggings", 1, partType, 80, makeArmorCategories(armorLegsKeyword));
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDevourerOfGodsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<DevourerOfGodsPart>();
            string bossName = DevourerOfGods;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DevourerofGodsBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DevourerofGodsTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DevourerofGodsMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeDevourerofGods", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "NebulousCore", 1, partType, 100, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Skullmasher", 1, partType, 1000, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Norfleet", 1, partType, 1000, makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CosmicDischarge", 1, partType, 25000, makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CosmicPlushie", 1, partType, 100000, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Fabsol", 1, partType, 250, new List<string> { mountKeyword});
            recipes.Add(working);
           
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CosmiliteBar", 8, partType, 1, workingCategories);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CosmiliteBrick", 64, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Excelsus", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EradicatorMelee", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheObliterator", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Deathwind", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DeathhailStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "StaffoftheMechworm", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Eradicator", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Starcore", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePolterghastRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<PolterghastPart>();
            string bossName = Polterghast;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PolterghastBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PolterghastTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PolterghastMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgePolterghast", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);
            
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Affliction", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RuinousSoul", 4, partType, 1, workingCategories);
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Phantoplasm", 6, partType, 1, workingCategories);
            working.irreversible = true;
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TerrorBlade", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BansheeHook", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DaemonsFlame", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FatesReveal", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GhastlyVisage", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EtherealSubjugator", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GhoulishGouger", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "NecroplasmicBeacon", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDragonfollyRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<DragonfollyPart>();
            string bossName = Dragonfolly;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BumblebirbBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BumblebirbTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BumblefuckMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeBumblebirb", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DynamoStemCells", 1, partType, 100, makeAccessoryCategories(movementKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BirdSeed", 1, partType, 50, new List<string>() { mountKeyword });
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EffulgentFeather", 4, partType, 1, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Swordsplosion", 1, partType, 500, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GildedProboscis", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "GoldenEagle", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RougeSlash", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BirbPheromones", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeOldDukeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<OldDukePart>();
            string bossName = OldDuke;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OldDukeBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OldDukeTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "OldDukeMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeOldDuke", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "MutatedTruffle", 1, partType, 100,new List<string>() { mountKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DukeScales", 1, partType, 50, makeAccessoryCategories(debuffsKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "InsidiousImpaler", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FetidEmesis", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SepticSkewer", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VitriolicViper", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CadaverousCarrion", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ToxicantTwister", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BloodwormItem", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeYharonRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<YharonPart>();
            string bossName = Yharon;

            PartRecipe working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "YharonBag", 1, partType, 200, new List<string>() { TreasureBagKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "YharonTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "YharonMask", 1, partType, 40, new List<string>() { maskKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeYharon", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "YharimsGift", 1, partType, 100, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FoxDrive", 1, partType, 250, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ForgottenDragonEgg", 1, partType, 50, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DragonRage", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TheBurningSky", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DragonsBreath", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ChickenCannon", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PhoenixFlameBarrage", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "AngryChickenStaff", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ProfanedTrident", 1, partType, 20, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "FinalDawn", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);

            //second phase drops

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "HellcasterFragment", 6, partType, 1, workingCategories,isYharonDefeated);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DrewsWings", 1, partType, 20, makeAccessoryCategories(movementKeyword, movementFlyingKeyword), isYharonDefeated);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "VoidVortex", 1, partType, 200, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword), isYharonDefeated);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "YharimsCrystal", 1, partType, 500, makeWeaponsCategories(magicDamageKeyword, otherKeyword), isYharonDefeated);
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ChickenEgg", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        public bool isYharonDefeated()
        {
            return (bool)mod.Call(new object[] { "GetBossDowned", "yharon" });
        }

        private void makeSCalamitasRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int partType = ModContent.ItemType<SupremeCalamitasPart>();
            string bossName = SCalamitas;

            PartRecipe 
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SupremeCalamitasTrophy", 1, partType, 50, new List<string>() { TrophyKeyword });
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "KnowledgeCalamitas", 1, partType, 20, new List<string>() { loreKeyword });
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Animus", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working); 
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Azathoth", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Contagion", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CrystylCrusher", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "DraconicDestruction", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Earth", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Fabstaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RoyalKnivesMelee", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RoyalKnives", 1, partType, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "NanoblackReaperMelee", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "NanoblackReaperRogue", 1, partType, 20, makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "RedSun", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "ScarletDevil", 1, partType, 20, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "SomaPrime", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Svantechnical", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BlushieStaff", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BensUmbrella", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Judgement", 1, partType, 20, makeWeaponsCategories(magicDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TriactisTruePaladinianMageHammerofMightMelee", 1, partType, 20, makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "TriactisTruePaladinianMageHammerofMight", 1, partType, 20, makeWeaponsCategories(rougeKeyword, hammerWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Endogenesis", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "PrototypeAndromechaRing", 1, partType, 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Megafleet", 1, partType, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "BrimstoneJewel", 1, partType, 20, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Vehemenc", 1, partType, 250, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "Levi", 1, partType, 500, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "CalamitousEssence", 6, partType, 1, workingCategories);
            recipes.Add(working);

            working = makeSimpleBossPartRecipe(modKeyword, bossName, modClassKeyword + ":" + "EyeofExtinction", 1, partType, 1, new List<string>() { utilityKeyword });
            working.irreversible = true;
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

    }
}
