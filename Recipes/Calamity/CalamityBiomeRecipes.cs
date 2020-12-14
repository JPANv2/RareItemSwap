using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Calamity.Biomes;
using ARareItemSwapJPANs.Parts.Calamity.Events;
using ARareItemSwapJPANs.Parts.Calamity.Stages;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Calamity
{
    public partial class CalamityModPartRepository : ModPartRepository
    {
        private void makeBiomeRecipes()
        {
            makeVanillaBiomesRecipes();

            makeAbyssBiomeRecipes();
            makeAstralBiomeRecipes();
            makeCragsBiomeRecipes();
            makeSunkenSeaBiomeRecipes();
            makeSulphurSeaBiomeRecipes();
        }

        private void makeVanillaBiomesRecipes()
        {
            makeFishingRecipes();
            makeShrineRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "CrawCarapace", 1, ModContent.ItemType<ForestUndergroundPart>(), 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "GiantShell", 1, ModContent.ItemType<ForestUndergroundPart>(), 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "FungalCarapace", 1, ModContent.ItemType<GlowingMushroomUndergroundPart>(), 12, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "GiantTortoiseShell", 1, ModContent.ItemType<JungleUndergroundPart>(), 15, makeAccessoryCategories(defenseKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            recipes.Add(working); 
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "SeaShell", 1, ModContent.ItemType<OceanSurfacePart>(), 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "RoverDrive", 1, ModContent.ItemType<ForestSurfacePart>(), 50, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "HeartofDarkness", 1, ModContent.ItemType<HardmodePart>(), 250, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "Laudanum", 1, ModContent.ItemType<HardmodePart>(), 250, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "StressPills", 1, ModContent.ItemType<HardmodePart>(), 250, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "ScuttlersJewel", 1, ModContent.ItemType<ForestUndergroundPart>(), 20, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "PiggyItem", 1, ModContent.ItemType<ForestSurfacePart>(), 5, new List<string>() { critterKeyword});
            working.irreversible = true;
            recipes.Add(working);

            /*ores*/
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "AerialiteOre", 2, ModContent.ItemType<ForestUndergroundPart>(),1, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, iceBiomeKeyword, modClassKeyword + ":" + "CryonicOre", 2, ModContent.ItemType<IceUndergroundPart>(), 1, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, astralKeyword, modClassKeyword + ":" + "AstralOre", 2, ModContent.ItemType<AstralInfectionPart>(), 1, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "PerennialOre", 2, ModContent.ItemType<JungleUndergroundPart>(), 1, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "UelibloomOre", 2, ModContent.ItemType<JungleUndergroundPart>(), 1, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<PostProvidencePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "AuricOre", 5, ModContent.ItemType<ForestUndergroundPart>(), 1, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<PostYharonPart>(), 1);
            recipes.Add(working);
           
            List<string> items = new List<string>()
            {
               "DraedonsLogHell",
                "DraedonsLogJungle",
                "DraedonsLogPlanetoid",
                "DraedonsLogSnowBiome",
                "DraedonsLogSunkenSea"
            };

            foreach(string itm in items)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + itm, 1, ModContent.ItemType<DeveloperPart>(), 1, new List<string>() { loreKeyword });
                recipes.Add(working);
            }
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "Rock", 1, ModContent.ItemType<DeveloperPart>(), 1000, new List<string>() { loreKeyword });
            recipes.Add(working);

            /*regular enemy drops*/
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "WulfrumShard", 5, ModContent.ItemType<ForestSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "AncientBoneDust", 1, ModContent.ItemType<HellUndergroundPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "EssenceofChaos", 1, ModContent.ItemType<HellUndergroundPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, iceBiomeKeyword, modClassKeyword + ":" + "EssenceofEleum", 1, ModContent.ItemType<IceSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, skyBiomeKeyword, modClassKeyword + ":" + "EssenceofCinder", 1, ModContent.ItemType<SkySurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, crimsonBiomeKeyword, modClassKeyword + ":" + "EbonianGel", 5, ModContent.ItemType<CrimsonSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, corruptionBiomeKeyword, modClassKeyword + ":" + "EbonianGel", 5, ModContent.ItemType<CorruptionSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            items = new List<string>()
            {
               "MurkyPaste",
               "MurkySludge",
               "TrapperBulb"
            };
            foreach (string itm in items)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + itm, 1, ModContent.ItemType<JungleUndergroundPart>(), 2, makeMaterialCategories(enemyDropsMaterialKeyword));
                recipes.Add(working);
            }
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "BeetleJuice", 1, ModContent.ItemType<JungleSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "DesertFeather", 3, ModContent.ItemType<DesertSurfacePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "Ectoblood", 1, ModContent.ItemType<DungeonUndergroundPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "EnergyCore", 1, ModContent.ItemType<ForestSurfacePart>(), 2, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            /*event drops*/
            working = makeSimpleEventPartRecipe(modKeyword, solarEclipseKeyword, modClassKeyword + ":" + "SolarVeil", 1, ModContent.ItemType<SolarEclipsePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, solarEclipseKeyword, modClassKeyword + ":" + "DarksunFragment", 1, ModContent.ItemType<SolarEclipsePart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostYharonPart>(), 1);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, pumpkinMoonKeyword, modClassKeyword + ":" + "NightmareFuel", 1, ModContent.ItemType<PumpkinMoonPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostDevourerOfGodsPart>(), 1);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, frostMoonKeyword, modClassKeyword + ":" + "EndothermicEnergy", 1, ModContent.ItemType<FrostMoonPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostDevourerOfGodsPart>(), 1);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, bloodMoonKeyword, modClassKeyword + ":" + "BloodOrb", 2, ModContent.ItemType<BloodMoonPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "Phantoplasm", 2, ModContent.ItemType<DungeonUndergroundPart>(), 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 1);
            //working.irreversible = true;
            recipes.Add(working);

            /*Pets & mounts*/
            working = makeSimpleBiomePartRecipe(modKeyword, oceanBiomeKeyword, modClassKeyword + ":" + "JoyfulHeart", 1, ModContent.ItemType<OceanSurfacePart>(), 30, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);

            /*furnitures*/
            working = makeSimpleBiomePartRecipe(modKeyword, astralKeyword, modClassKeyword + ":" + "AstralChest", 1, ModContent.ItemType<AstralInfectionPart>(), 3, makeFurnitureCategories(chestKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "LabHologramProjectorItem", 1, ModContent.ItemType<DeveloperPart>(), 1, makeFurnitureCategories(decorativeKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "PowerCellFactoryItem", 1, ModContent.ItemType<DeveloperPart>(), 1, makeFurnitureCategories(functionalStatueKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "ChargingStationItem", 1, ModContent.ItemType<DeveloperPart>(), 1, makeFurnitureCategories(functionalStatueKeyword));
            recipes.Add(working);

            /*accessories*/
            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "FabledTortoiseShell", 1, ModContent.ItemType<JungleUndergroundPart>(), 200, makeAccessoryCategories(defenseKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 50);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "PsychoticAmulet", 1, ModContent.ItemType<ForestSurfacePart>(), 100, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 50);
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, "Mimic", modClassKeyword + ":" + "TheBee", 1, ModContent.ItemType<MimicPart>(), 80, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "WulfrumBattery", 1, ModContent.ItemType<ForestSurfacePart>(), 50, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);

            /*weapons*/
            working = makeSimpleEventPartRecipe(modKeyword, bloodMoonKeyword, modClassKeyword + ":" + "Carnage", 1, ModContent.ItemType<BloodMoonPart>(), 100, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBossPartRecipe(modKeyword, "Mimic", modClassKeyword + ":" + "CelestialClaymore", 1, ModContent.ItemType<MimicPart>(), 40, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, frostMoonKeyword, modClassKeyword + ":" + "HolidayHalberd", 1, ModContent.ItemType<FrostMoonPart>(), 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, oceanBiomeKeyword, modClassKeyword + ":" + "MantisClaws", 30, ModContent.ItemType<OceanSurfacePart>(), 1, makeWeaponsCategories(meleeDamageKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "Murasama", 1, ModContent.ItemType<HellUndergroundPart>(), 100, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "Terracotta", 1, ModContent.ItemType<DesertUndergroundPart>(), 100, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "AncientShiv", 1, ModContent.ItemType<DungeonUndergroundPart>(), 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "Waraxe", 1, ModContent.ItemType<DungeonUndergroundPart>(), 20, makeWeaponsCategories(meleeDamageKeyword, axeWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "BladecrestOathsword", 1, ModContent.ItemType<HellUndergroundPart>(), 50, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "OldLordOathsword", 1, ModContent.ItemType<HellUndergroundPart>(), 50, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "BurntSienna", 1, ModContent.ItemType<DesertUndergroundPart>(), 50, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "MandibleClaws", 1, ModContent.ItemType<DesertSurfacePart>(), 30, makeWeaponsCategories(meleeDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "EvilSmasher", 1, ModContent.ItemType<DesertUndergroundPart>(), 250, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 50);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, goblinArmyKeyword, modClassKeyword + ":" + "Warblade", 1, ModContent.ItemType<GoblinArmyPart>(), 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, jungleBiomeKeyword, modClassKeyword + ":" + "Needler", 1, ModContent.ItemType<JungleUndergroundPart>(), 100, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, desertBiomeKeyword, modClassKeyword + ":" + "MandibleBow", 1, ModContent.ItemType<DesertSurfacePart>(), 30, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, pirateInvasionKeyword, modClassKeyword + ":" + "RaidersGlory", 1, ModContent.ItemType<PirateInvasionPart>(), 50, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, pirateInvasionKeyword, modClassKeyword + ":" + "Arbalest", 1, ModContent.ItemType<PirateInvasionPart>(), 200, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "PearlGod", 1, ModContent.ItemType<DungeonUndergroundPart>(), 200, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 50);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, pirateInvasionKeyword, modClassKeyword + ":" + "ProporsePistol", 1, ModContent.ItemType<PirateInvasionPart>(), 100, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, "Lunar Pillars", modClassKeyword + ":" + "TrueConferenceCall", 1, ModContent.ItemType<PostMoonLordPart>(), 100, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);


            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "Keelhaul", 1, ModContent.ItemType<DungeonUndergroundPart>(), 100, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, martianInvasionKeyword, modClassKeyword + ":" + "Wingman", 1, ModContent.ItemType<MartianInvasionPart>(), 50, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, iceBiomeKeyword, modClassKeyword + ":" + "Cryophobia", 1, ModContent.ItemType<IceSurfacePart>(), 100, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, skyBiomeKeyword, modClassKeyword + ":" + "SkyGlaze", 1, ModContent.ItemType<SkySurfacePart>(), 100, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "WrathoftheAncients", 1, ModContent.ItemType<DungeonUndergroundPart>(), 100, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "AncientIceChunk", 1, ModContent.ItemType<IceSurfacePart>(), 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 10);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "AncientIceChunk", 1, ModContent.ItemType<IceSurfacePart>(), 20, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 10);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "StaffOfNecrosteocytes", 1, ModContent.ItemType<DungeonUndergroundPart>(), 30, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "EnergyStaff", 1, ModContent.ItemType<HellUndergroundPart>(), 40, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, hallowedBiomeKeyword, modClassKeyword + ":" + "EnergyStaff", 1, ModContent.ItemType<HallowedSurfacePart>(), 40, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, hellBiomeKeyword, modClassKeyword + ":" + "AshenStalactite", 1, ModContent.ItemType<HellUndergroundPart>(), 200, makeWeaponsCategories(rougeKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, bloodMoonKeyword, modClassKeyword + ":" + "BouncingEyeball", 1, ModContent.ItemType<BloodMoonPart>(), 100, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, solarEclipseKeyword, modClassKeyword + ":" + "DefectiveSphere", 1, ModContent.ItemType<SolarEclipsePart>(), 100, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, astralKeyword, modClassKeyword + ":" + "HeavenfallenStardisk", 1, ModContent.ItemType<AstralInfectionPart>(), 250, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 50);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, dungeonBiomeKeyword, modClassKeyword + ":" + "ShinobiBlade", 1, ModContent.ItemType<DungeonUndergroundPart>(), 100, makeWeaponsCategories(rougeKeyword, swordWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, corruptionBiomeKeyword, modClassKeyword + ":" + "CursedDagger", 1, ModContent.ItemType<CorruptionUndergroundPart>(), 50, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, crimsonBiomeKeyword, modClassKeyword + ":" + "IchorSpear", 1, ModContent.ItemType<CrimsonUndergroundPart>(), 50, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, crimsonBiomeKeyword, modClassKeyword + ":" + "SpearofDestiny", 1, ModContent.ItemType<CrimsonUndergroundPart>(), 100, makeWeaponsCategories(rougeKeyword, spearWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 50);
            recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeShrineRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working;
            //surface
            workingCategories = makeAccessoryCategories(defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(offenseKeyword));
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "TrinketofChi", 1, ModContent.ItemType<ForestSurfacePart>(), 100, workingCategories);
            recipes.Add(working);
            //desert
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "LuxorsGift", 1, ModContent.ItemType<DesertUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);
            //ice
            workingCategories = new List<string>() { mountKeyword };
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "TundraLeash", 1, ModContent.ItemType<IceUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);
            //marble
            workingCategories = makeAccessoryCategories(summonerDamageKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "GladiatorsLocket", 1, ModContent.ItemType<MarbleUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);
            //granite
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "UnstablePrism", 1, ModContent.ItemType<GraniteUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);
            //glowshroom
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "FungalSymbiote", 1, ModContent.ItemType<GlowingMushroomUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);

            //corruption
            workingCategories = makeFurnitureCategories(functionalStatueKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "CorruptionEffigy", 1, ModContent.ItemType<CorruptionUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);
            //crimson
            workingCategories = makeFurnitureCategories(functionalStatueKeyword);
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "CrimsonEffigy", 1, ModContent.ItemType<CrimsonUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);

            //cavern
            workingCategories = new List<string>() { mountKeyword };
            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "OnyxExcavatorKey", 1, ModContent.ItemType<ForestUndergroundPart>(), 100, workingCategories);
            recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFishingRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<FishingPart>();
            PartRecipe working;
            List<String> blocks = new List<string>()
            {
                "FishofEleum",
                "FishofFlight",
                "FishofLight",
                "FishofNight",
                "SunbeamFish",
            };
            
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + itm, 1, biomePart, 2, makeFishingCategories(fishKeyword));
                working.addPart(ModContent.ItemType<HardmodePart>(), 1);
                recipes.Add(working);
            }
                
                // Spadefish
  
            blocks = new List<string>()
            {
                "EnchantedStarfish",
                "GlimmeringGemfish",
                "StuffedFish"
            };
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + itm, 1, biomePart, 2, makeFishingCategories(fishKeyword));
                //working.addPart(ModContent.ItemType<HardmodePart>(), 1);
                recipes.Add(working);
            }

            working = makeSimpleBiomePartRecipe(modKeyword, purityBiomeKeyword, modClassKeyword + ":" + "Spadefish", 1, biomePart, 25, new List<string>() { utilityKeyword });
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAstralBiomeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<AstralInfectionPart>();
            string biome = astralKeyword;
            PartRecipe working;
            List<String> blocks = new List<string>()
            {
                "AstralMonolith",
                "AstralDirt",
                "AstralClay",
                "AstralSilt",
                "AstralStone",
                "AstralSand", 
                "AstralSandstone",
                "HardenedAstralSand",
                "AstralFossil",
                "AstralIce",
                "AstralSnow"
            };
            foreach (string itm in blocks)
            {

                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 100, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
                recipes.Add(working);
            }

            /*critters*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "TwinklerItem", 5, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, ""+ItemID.EnchantedNightcrawler, 5, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "ArcturusAstroidean", 5, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);

            /*fishing*/
            int fishPart = ModContent.ItemType<FishingPart>();
            blocks = new List<string>()
            {
                "ProcyonidPrawn",
                "TwinklingPollox",
                "AldebaranAlewife"
            };
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 2, fishPart, 1, makeFishingCategories(fishKeyword));
                working.addPart(biomePart, 1);
                recipes.Add(working);
            }

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AstralCrate", 1, biomePart, 1, makeFishingCategories(crateKeyword));
            working.addPart(fishPart, 5);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "GacruxianMollusk", 1, biomePart, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "PolarisParrotfish", 1, biomePart, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "UrsaSergeant", 1, biomePart, 20, makeAccessoryCategories(defenseKeyword));
            working.addPart(fishPart, 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AstrophageItem", 1, biomePart, 20, makePetsCategories(normalPetsKeyword));
            working.addPart(fishPart, 20);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "MeldBlob", 5, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostMoonLordPart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "TitanHeart", 1, biomePart, 5, makeMaterialCategories(enemyDropsMaterialKeyword));
            //working.addPart(ModContent.ItemType<PostYharonPart>(), 50);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "HadarianMembrane", 1, biomePart, 10, makeMaterialCategories(enemyDropsMaterialKeyword));
            //working.addPart(ModContent.ItemType<PostYharonPart>(), 50);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AbandonedSlimeStaff", 1, biomePart, 100, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 20);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "StellarKnife", 1, biomePart, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AstralachneaStaff", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "TitanArm", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "HivePod", 1, biomePart, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AstralScythe", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "StellarCannon", 1, biomePart, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "StarbusterCore", 1, biomePart, 20, makeAccessoryCategories(summonerDamageKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            recipes.Add(working);
     

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCragsBiomeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<CragsPart>();
            string biome = cragsKeyword;
            PartRecipe working;
            /*blocks*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BrimstoneSlag", 100, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "CharredOre", 5, biomePart, 1, makeMaterialCategories(oreMaterialKeyword));
            recipes.Add(working);

            /*fishing*/
            int fishPart = ModContent.ItemType<FishingPart>();
            List<String> blocks = new List<string>()
            {
                "CoastalDemonfish",
                "Shadowfish",
                "BrimstoneFish",
                "CragBullhead"
            };
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 2, fishPart, 1, makeFishingCategories(fishKeyword));
                working.addPart(biomePart, 1);
                recipes.Add(working);
            }
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "DragoonDrizzlefish", 1, fishPart, 30, makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword));
            working.addPart(biomePart, 30);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "CharredLasher", 1, fishPart, 30, makeFishingCategories(fishKeyword));
            working.addPart(biomePart, 30);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "ChaoticFish", 1, fishPart, 1, makeFishingCategories(fishKeyword));
            working.addPart(biomePart, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Bloodfin", 1, fishPart, 10, makeFishingCategories(fishKeyword));
            working.addPart(biomePart, 10);
            working.addPart(ModContent.ItemType<PostProvidencePart>(), 1);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BrimstoneCrate", 1, biomePart, 1, makeFishingCategories(crateKeyword));
            working.addPart(fishPart, 5);
            recipes.Add(working);

            /*drops*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "EssenceofChaos", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            //working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BlightedLens", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            //working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Bloodstone", 1, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostProvidencePart>(), 1);
            //working.irreversible = true;
            recipes.Add(working);
            

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SlurperPole", 1, biomePart, 50, makeFishingCategories(utilityKeyword));
           // working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "GaelsGreatsword", 1, biomePart, 50, makeFishingCategories(utilityKeyword));
            working.addPart(ModContent.ItemType<PostYharonPart>(), 50);
            recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSunkenSeaBiomeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<SunkenSeaPart>();
            string biome = sunkenSeaKeyword;
            PartRecipe working;
            List<String> blocks = new List<string>()
            {
                "Navystone",
                "EutrophicSand",
                "PrismShard",
                "SeaPrism"
            };
            int i = 0;
            foreach (string itm in blocks)
            {
                i++;
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 100/i, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
                recipes.Add(working);
            }
            /*critters*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BabyGhostBellItem", 1, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SeaMinnowItem", 1, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);

            /*fishing*/
            int fishPart = ModContent.ItemType<FishingPart>();
            blocks = new List<string>()
            {
                "EutrophicSandfish",
                "SurfClam",
                "Serpentuna",
                //brimstone quest fish
                "Brimlish",
                "Slurpfish"
            };
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 1, fishPart, 20, makeFishingCategories(questFishKeyword));
                recipes.Add(working);
            }
            blocks = new List<string>()
            {
                "CoralskinFoolfish",
                "SunkenSailfish",
                "ScarredAngelfish",
                "PrismaticGuppy"
            };
            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 2, fishPart, 1, makeFishingCategories(fishKeyword));
                working.addPart(biomePart, 1);
                recipes.Add(working);
            }
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "GreenwaveLoach", 2, fishPart, 50, makeFishingCategories(fishKeyword));
            working.addPart(biomePart, 10);
            recipes.Add(working);


            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SunkenCrate", 1, biomePart, 1, makeFishingCategories(crateKeyword));
            working.addPart(fishPart, 5);
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "RustedJingleBell", 1, biomePart, 20, makePetsCategories(lightPetsKeyword));
            working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SerpentsBite", 1, biomePart, 20, new List<string>() { utilityKeyword + "/" + hooksKeyword});
            working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SparklingEmpress", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            working.addPart(fishPart, 50);
            recipes.Add(working);

            /*drops*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "VoltaicJelly", 1, biomePart, 40, makeAccessoryCategories(summonerDamageKeyword));
           // working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "EutrophicShank", 1, biomePart, 20, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            // working.addPart(fishPart, 10);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Serpentine", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "EutrophicScimitar", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSulphurSeaBiomeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<SulfurSeaPart>();
            string biome = sulphurSeaKeyword;
            PartRecipe working;
            /*blocks and ores*/
            List<String> blocks = new List<string>()
            {
                "Acidwood",
                "SulphurousSand",
                "SulphurousSandstone",
                "HardenedSulphurousSandstone"
            };

            foreach (string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 100, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
                recipes.Add(working);
            }

            /*ocean blocks*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, "" + ItemID.Seashell, 20, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, "" + ItemID.Starfish, 20, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, "" + ItemID.Coral, 50, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
            recipes.Add(working);

            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BabyFlakHermit", 1, biomePart, 1, new List<string>() { critterKeyword });
            working.irreversible = true;
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "RadiatingCrystal", 1, biomePart, 40, makePetsCategories(lightPetsKeyword));
            recipes.Add(working);
            /*Fishing*/
            int fishPart = ModContent.ItemType<FishingPart>();
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AbyssalCrate", 1, biomePart, 1, makeFishingCategories(crateKeyword));
            working.addPart(fishPart, 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AbyssalAmulet", 1, biomePart, 20, makeFishingCategories(accessoryKeyword));
            working.addPart(fishPart, 50);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AlluringBait", 1, biomePart, 20, makeFishingCategories(accessoryKeyword));
            working.addPart(fishPart, 50);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, bloodMoonKeyword, modClassKeyword + ":" + "Xerocodile", 1, ModContent.ItemType<BloodMoonPart>(), 20, makeFishingCategories(fishKeyword));
            working.addPart(fishPart, 10);
            recipes.Add(working);

            /*Chests and posts*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "SulphuricTreasure", 1, biomePart, 1, new List<string>() { utilityKeyword});
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BrokenWaterFilter", 1, biomePart, 20, new List<string>() { utilityKeyword });
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "RustyBeaconPrototype", 1, biomePart, 20,makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "RustyMedallion", 1, biomePart, 20, makeAccessoryCategories(offenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "EffigyOfDecay", 1, biomePart, 20, makeFurnitureCategories(functionalStatueKeyword));
            recipes.Add(working);

            /*drops*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "UrchinStinger", 20, biomePart, 1, makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "TrashmanTrashcan", 1, biomePart, 100, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "GeyserShell", 1, biomePart, 200, makePetsCategories(normalPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BelchingSaxophone", 1, biomePart, 50, makeWeaponsCategories(magicDamageKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "CorrodedFossil", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);

            /*Acid Rain*/
            biome = acidRainKeyword;
            biomePart = ModContent.ItemType<AcidRainPart>();
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "CorrodedFossil", 5, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "SulfuricScale", 5, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            //working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            recipes.Add(working);

            /*acid rain drops*/
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "SulphurousGrabber", 1, biomePart, 50, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "FlakToxicannon", 1, biomePart, 50, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "SlitheringEels", 1, biomePart, 50, makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "ParasiticSceptor", 1, biomePart, 75, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            //working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "OrthoceraShell", 1, biomePart, 50, makeWeaponsCategories(summonerDamageKeyword, otherKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "SkyfinBombers", 1, biomePart, 50, makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            working = makeSimpleEventPartRecipe(modKeyword, biome, modClassKeyword + ":" + "LeadCore", 1, biomePart, 80, makeAccessoryCategories(offenseKeyword));
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            recipes.Add(working);
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAbyssBiomeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            int biomePart = ModContent.ItemType<AbyssPart>();
            string biome = abyssKeyword;
            PartRecipe working;
            /*blocks and ores*/
            List<String> blocks = new List<string>()
            {
                "AbyssGravel",
                "PlantyMush",
                "Voidstone",
                "Tenebris"
            };

            foreach(string itm in blocks)
            {
                working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + itm, 100, biomePart, 1, makeMaterialCategories(blocksMaterialKeyword));
                recipes.Add(working);
            }
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "ChaoticOre", 3, biomePart, 1, makeMaterialCategories(oreMaterialKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(),1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "DepthCells", 3, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Lumenite", 1, biomePart, 1, makeMaterialCategories(enemyDropsMaterialKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            recipes.Add(working);

            /*pot and chest contents*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AnechoicPlating", 1, biomePart, 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "IronBoots", 1, biomePart, 20, makeAccessoryCategories(movementKeyword, movementBootsKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "DepthCharm", 1, biomePart, 20, makeAccessoryCategories(defenseKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "StrangeOrb", 1, biomePart, 20, makePetsCategories(lightPetsKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "TorrentialTear", 1, biomePart, 20, new List<string>() { utilityKeyword});
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BallOFugu", 1, biomePart, 20,makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Archerfish", 1, biomePart, 20, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BlackAnurian", 1, biomePart, 20, makeWeaponsCategories(magicDamageKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "HerringStaff", 1, biomePart, 20, makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Lionfish", 1, biomePart, 20, makeWeaponsCategories(rougeKeyword, otherKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BossRush", 1, biomePart, 10000, new List<string>() { utilityKeyword });
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AbyssalTreasure", 1, biomePart, 1, new List<string>() { utilityKeyword });
            recipes.Add(working);
            /*enemies*/
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "AbyssShocker", 1, biomePart, 50, makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "LifeJelly", 1, biomePart, 25, makeAccessoryCategories(lifeKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "ManaJelly", 1, biomePart, 25, makeAccessoryCategories(manaKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "VitalJelly", 1, biomePart, 25, makeAccessoryCategories(lifeKeyword));
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "BobbitHook", 1, biomePart, 20, new List<string>() { utilityKeyword +"/" + hooksKeyword});
            recipes.Add(working);
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "DepthBlade", 1, biomePart, 50, makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword));
            recipes.Add(working); 
            working = makeSimpleBiomePartRecipe(modKeyword, biome, modClassKeyword + ":" + "Hellborn", 1, biomePart, 50, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
