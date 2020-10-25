using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Thorium.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using Terraria.ModLoader;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Parts.Vanilla.Weather;

namespace ARareItemSwapJPANs.Recipes.Thorium
{
    public partial class ThoriumModPartRepository : ModPartRepository
    {

        private void makeMiscRecipes()
        {
            makeMaterialRecipes();
            makeToolsAndWeaponsRecipes();
            makeArmorAndAccessoriesRecipes();
            makeOtherEquipmentRecipes();
            makeMusicBoxRecipes();

            
                List<PartRecipe> recipes = new List<PartRecipe>();
                List<string> workingCategories;

                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, "ThoriumMod:Jelly", 1);
                workingCategories = new List<string>() { potionKeyword }; working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 8, "ThoriumMod:CrystalWave", 1);
            workingCategories = new List<string>() { potionKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, "ThoriumMod:GoldDuck", 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, "ThoriumMod:HealerCard", 1);
            working.irreversible = true;
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            List<string> dyes = new List<string>()
            {
                "ThoriumMod:ReflectiveAquaiteDye",
                "ThoriumMod:ReflectiveMagmaDye",
                "ThoriumMod:ReflectiveThoriumDye"
            };
            foreach (string dye in dyes)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 1, dye, 1);
                workingCategories = makeVanityCategories(dyeKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); PartRecipes.addRecipe(working);
            }

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 10, "ThoriumMod:Mistletoe", 1);
            workingCategories = makeFurnitureCategories(decorativeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:MinotaurStatue", 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 2, "ThoriumMod:RejectStatue", 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:TechniqueBloodLotus", 1);
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 25);
            workingCategories = new List<string>() { utilityKeyword + "/" + techniqueKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PaintingPart>(), 1, "ThoriumMod:GrayDPaintingItem", 1);
            workingCategories = makeFurnitureCategories(paintingKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeToolsAndWeaponsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 20, "ThoriumMod:YewWoodBlowpipe", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 20, "ThoriumMod:DarkGate", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 3, "ThoriumMod:Concertina", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 25, "ThoriumMod:Lullaby", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 25, "ThoriumMod:MoonlightStaff", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:Bagpipe", 1);
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 25);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:EskimoBanjo", 1);
            working.addPart(ModContent.ItemType<FrostLegionPart>(), 20);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostLegionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:TlordsTsword", 1);
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 25);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 20, "ThoriumMod:SunflareGuitar", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:StarfishSlicer", 50);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 5, "ThoriumMod:FireAxe", 1);
            working.addPart(ModContent.ItemType<SolarEclipsePart>(), 25);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, axeWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 20, "ThoriumMod:SunrayStaff", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 100, "ThoriumMod:Lantern", 1);
            workingCategories = makeWeaponsCategories(trueDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 25, "ThoriumMod:RedHourglass", 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 20, "ThoriumMod:Arthropod", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 25, "ThoriumMod:TranquilizerGun", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 20, "ThoriumMod:VoltModule", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 1, "ThoriumMod:ElectroRebounder", 25);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FrostLegionPart>(), 1, "ThoriumMod:LegionOrnament", 10);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostLegionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, "ThoriumMod:SeveredHand", 25);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, "ThoriumMod:EvisceratingClaw", 50);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 1, "ThoriumMod:ShadowPurgeCaltrop", 5);
            working.addPart(ModContent.ItemType<HardmodePart>(),1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 1, "ThoriumMod:SpikeBomb", 15);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:VoltHatchet", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, axeWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 20, "ThoriumMod:SwampSpike", 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 20, "ThoriumMod:StalkersSnippers", 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 15, "ThoriumMod:MortarStaff", 1);
            working.addPart(ModContent.ItemType<HellUndergroundPart>(), 25);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 20, "ThoriumMod:HiveMind", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 15, "ThoriumMod:MortarStaff", 1);
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 25);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 25, "ThoriumMod:Zapper", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 25, "ThoriumMod:VegaPhaser", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FrostLegionPart>(), 20, "ThoriumMod:TommyGun", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 8);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostLegionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 15, "ThoriumMod:SpineBuster", 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 15);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 15, "ThoriumMod:SpineBuster", 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 15);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 15, "ThoriumMod:VileSpitter", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedUndergroundPart>(), 15, "ThoriumMod:PrismiteStaff", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 50, "ThoriumMod:GnomePick", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FrostLegionPart>(), 20, "ThoriumMod:HailBomber", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostLegionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 15, "ThoriumMod:FrostPlagueStaff", 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 15);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 35, "ThoriumMod:DetachedUFOBlaster", 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, "ThoriumMod:IceFairyStaff", 1);
            working.addPart(ModContent.ItemType<RainPart>(), 20);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:CartlidgedCatcher", 1);
            workingCategories = makeFishingCategories(utilityKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 20, "ThoriumMod:Leviathan", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 40, "ThoriumMod:NanoClamCane", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);  working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, "ThoriumMod:BlizzardsEdge", 1);
            working.addPart(ModContent.ItemType<RainPart>(), 20);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 20, "ThoriumMod:Spearmint", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:NecroticStaff", 1);
            working.addPart(ModContent.ItemType<BloodMoonPart>(), 25);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 50, "ThoriumMod:ShieldDroneBeacon", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 75, "ThoriumMod:TeslaDefibrillator", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FrostLegionPart>(), 20, "ThoriumMod:BackStabber", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 8);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostLegionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 20, "ThoriumMod:SpineBreaker", 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 20, "ThoriumMod:BoneFlayerTail", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 20, "ThoriumMod:EbonyTail", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 20, "ThoriumMod:GatewayGlass", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 20);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makeArmorAndAccessoriesRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 25, "ThoriumMod:FanLetter", 1);
            workingCategories = makeAccessoryCategories(bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, "ThoriumMod:FanLetter2", 1);
            workingCategories = makeAccessoryCategories(bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 25, "ThoriumMod:DarkHeart", 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, "ThoriumMod:DarkHeart", 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, "ThoriumMod:HeartOfStone", 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 15, "ThoriumMod:SerpentShield", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 15);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 15, "ThoriumMod:AloeLeaf", 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 25, "ThoriumMod:ShadeBand", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            workingCategories = makeAccessoryCategories(manaKeyword); ; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 25, "ThoriumMod:IncubatedEgg", 1);
            workingCategories = makeAccessoryCategories(summonerDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 25, "ThoriumMod:OlympicTorch", 1);
            workingCategories = makeAccessoryCategories(throwingDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, "ThoriumMod:DeadEyePatch", 1);
            workingCategories = makeAccessoryCategories(throwingDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 20, "ThoriumMod:SpinyShell", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 20, "ThoriumMod:VampireGland", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(lifeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
           
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 25, "ThoriumMod:AncientAegis", 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 30, "ThoriumMod:DemonTongue", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 30, "ThoriumMod:GraveGoods", 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 30, "ThoriumMod:BallnChain", 1);
            workingCategories = makeAccessoryCategories(otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 25, "ThoriumMod:AstroBeetleHusk", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeOtherEquipmentRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            //pets
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 50, "ThoriumMod:AbyssalWhistle", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 70, "ThoriumMod:DelectableNut", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 50, "ThoriumMod:ExoticMynaEgg", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 80, "ThoriumMod:TortleScute", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 50, "ThoriumMod:FishEgg", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 40, "ThoriumMod:AncientCheeseBlock", 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 50, "ThoriumMod:BioPod", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 40, "ThoriumMod:LostMail", 1);
            working.addPart(ModContent.ItemType<RainPart>(), 20);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 50, "ThoriumMod:BlisterSack", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //mounts
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 50, "ThoriumMod:SpectralFang", 1);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:WhaleSummon", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 75, "ThoriumMod:BattleHorn", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 100, "ThoriumMod:DesecratedHeart", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 80, "ThoriumMod:MoltenCollar", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 35);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 150, "ThoriumMod:BeetleKeepsake", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { mountKeyword +"/"+ transformationKeyword}; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 50, "ThoriumMod:SinisterAcorn", 1);
            workingCategories = new List<string>() { mountKeyword + "/" + transformationKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 50, "ThoriumMod:GoldenScale", 1);
            workingCategories = new List<string>() { mountKeyword + "/" + transformationKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMaterialRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, "ThoriumMod:AvianCartilage", 6);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 2, "ThoriumMod:DangerShard",1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, "ThoriumMod:Petal", 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 1, "ThoriumMod:BronzeFragments", 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteUndergroundPart>(), 1, "ThoriumMod:GraniteEnergyCore", 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories,graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:UnholyShards"), 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:AbyssalChitin", 4);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:DepthScale", 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:FishScale", 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, "ThoriumMod:FishScale", 8);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 5, "ThoriumMod:IntactGeode", 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, "ThoriumMod:HolyKnightsAlloy", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, "ThoriumMod:IcyShard", 4);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 10, "ThoriumMod:BrokenHeroFragment", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, "ThoriumMod:FamilyHeirloom", 1);
            working.irreversible = true;
            workingCategories = makeMaterialCategories(otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, "ThoriumMod:MoltenResidue", 2);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, "ThoriumMod:PharaohsBreath", 8);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, "ThoriumMod:BirdTalon", 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 1, "ThoriumMod:AlienTech", 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, "ThoriumMod:SolarPebble", 8);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, "ThoriumMod:Blood", 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, "ThoriumMod:BioMatter", 2);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1, "ThoriumMod:CeruleanMorel", 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomSurfacePart>(), 1, "ThoriumMod:CeruleanMorel", 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, "ThoriumMod:DarkMatter", 2);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 10, "ThoriumMod:BrokenDarksteelHelmet", 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            // Plants
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, "ThoriumMod:ManaBerry", 5);
            workingCategories = new List<string>() { otherKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:MarineKelp", 15);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:MarineKelpSeeds", 15);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:WaterChestnut", 5);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, "ThoriumMod:LivingLeaf",2);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //blocks
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:BrackMud", 75);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:MarineRock", 100);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:MarineRockMoss", 100);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //ores
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, "ThoriumMod:SmoothCoal", 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:Aquaite", 5);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, "ThoriumMod:ThoriumOre", 8);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, "ThoriumMod:MagmaOre", 5);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, "ThoriumMod:IllumiteChunk", 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, "ThoriumMod:LodeStoneChunk", 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, "ThoriumMod:ValadiumChunk", 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //gems
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, "ThoriumMod:Onyx", 3);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, "ThoriumMod:Opal", 3);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 1, "ThoriumMod:Pearl", 3);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            //fragments
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, "ThoriumMod:CelestialFragment",1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, "ThoriumMod:CometFragment", 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, "ThoriumMod:WhiteDwarfFragment", 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMusicBoxRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<string> boxes = new List<string>()
            {
                "ThoriumMod:BoreanStriderMusicBox",
                "ThoriumMod:DepthsMusicBox",
                "ThoriumMod:FallenBeholderMusicBox",
                "ThoriumMod:PrimordialsMusicBox",
                "ThoriumMod:ThunderBirdMusicBox",
                "ThoriumMod:ViscountMusicBox"
            };

            foreach (string box in boxes)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MusicBoxPart>(), 1, box, 1);
                workingCategories = makeFurnitureCategories(musicBoxKeyword);
                workingCategories.AddRange(makeAccessoryCategories(musicBoxKeyword));
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
            }
        }
    }
}
