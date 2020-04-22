using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using ARareItemSwapJPANs.Parts.Vanilla.Weather;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Vanilla
{
    public partial class VanillaModPartRepository : ModPartRepository
    {
        #region bosses
        private void makeBossDropRecipes()
        {
            makeKingSlimeRecipes();
            makeEoCRecipes();
            makeEoWRecipes();
            makeBoCRecipes();
            makeQueenBeeRecipes();
            makeSkeletronRecipes();
            makeWoFRecipes();

            makeTwinsRecipes();
            makeDestroyerRecipes();
            makeSkeletronPrimeRecipes();
            makePlanteraRecipes();
            makeGolemRecipes();
            makeDukeFishronRecipes();
            makeLunaticCultistRecipes();
            makeMoonLordRecipes();

            makeDarkMageRecipes();
            makeOgreRecipes();
            makeBetsyRecipes();

            makeFlyingDutchmanRecipes();
            makeGoblinSummonerRecipes();
            makeMartianSaucerRecipes();

            makeMourningWoodRecipes();
            makePumpkingRecipes();

            makeEverscreamRecipes();
            makeSantaNK1Recipes();
            makeIceQueenRecipes();

            makeRareEnemyRecipes();
        }

        private void makeRareEnemyRecipes()
        {
            makeMimicRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.BlackBelt, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.Tabi, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.MetalDetector, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.PaladinsHammer, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.PaladinsShield, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ItemID.PinkGel, 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 50, ItemID.SlimeStaff, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ItemID.RainbowBrick, 12);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.BlessedApple, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 2);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.FrostCore, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 2);
            working.addPart(ModContent.ItemType<IceSurfacePart>(), 1);
            working.addPart(ModContent.ItemType<RainPart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.IceFeather, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 2);
            working.addPart(ModContent.ItemType<IceSurfacePart>(), 1);
            working.addPart(ModContent.ItemType<RainPart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 50, ItemID.FrostStaff, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            working.addPart(ModContent.ItemType<IceSurfacePart>(), 5);
            working.addPart(ModContent.ItemType<RainPart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.AncientBattleArmorMaterial, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 2);
            working.addPart(ModContent.ItemType<DesertSurfacePart>(), 1);
            working.addPart(ModContent.ItemType<SandstormPart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 10, ItemID.ButterflyDust, 1);
            working.addPart(ModContent.ItemType<JungleSurfacePart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ItemID.WizardHat, 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.RuneHat, 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.RuneRobe, 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.SWATHelmet, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.SniperRifle, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.TacticalShotgun, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.RocketLauncher, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.SniperScope, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.InfernoFork, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, spearWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.ShadowbeamStaff, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 30, ItemID.SpectreStaff, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.MiningShirt, 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 5);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.MiningPants, 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 5);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMimicRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.StarCloak, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.CrossNecklace, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.TitanGlove, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.PhilosophersStone, 1);
            workingCategories = makeAccessoryCategories(lifeKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.MagicDagger, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, thrownWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ItemID.DualHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 20, ItemID.WormHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 20, ItemID.DartRifle, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 20, ItemID.ClingerStaff, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 20, ItemID.ChainGuillotines, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 20, ItemID.PutridScent, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 20, ItemID.TendonHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 20, ItemID.DartPistol, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 20, ItemID.SoulDrain, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 20, ItemID.FetidBaghnakhs, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 20, ItemID.FleshKnuckles, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedMimicPart>(), 20, ItemID.IlluminantHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedMimicPart>(), 20, ItemID.DaedalusStormbow, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedMimicPart>(), 20, ItemID.FlyingKnife, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, thrownWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedMimicPart>(), 20, ItemID.CrystalVileShard, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeIceQueenRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 50, ItemID.IceQueenTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 20, ItemID.SnowmanCannon, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 20, ItemID.BlizzardStaff, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 20, ItemID.NorthPole, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 100, ItemID.BabyGrinchMischiefWhistle, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 150, ItemID.ReindeerBells, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSantaNK1Recipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SantaNK1Part>(), 50, ItemID.SantaNK1Trophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, santaNK1Keyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SantaNK1Part>(), 20, ItemID.EldMelter, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, flamethrowerWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, santaNK1Keyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SantaNK1Part>(), 20, ItemID.ChainGun, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, santaNK1Keyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEverscreamRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 50, ItemID.EverscreamTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 100, ItemID.FestiveWings, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 50, ItemID.ChristmasHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 50, ItemID.Razorpine, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 50, ItemID.ChristmasTreeSword, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePumpkingRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.PumpkingTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.BlackFairyDust, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.SpiderEgg, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 1, ItemID.CandyCorn, 20);
            workingCategories = makeAmmoCategories(otherKeyword, rangedDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 1, ItemID.ExplosiveJackOLantern, 10);
            workingCategories = makeAmmoCategories(otherKeyword, rangedDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.CandyCornRifle, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.JackOLanternLauncher, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.TheHorsemansBlade, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.RavenStaff, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ItemID.BatScepter, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMourningWoodRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.MourningWoodTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 1, ItemID.SpookyWood, 10);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 1, ItemID.Stake, 10);
            workingCategories = makeAmmoCategories(otherKeyword, rangedDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.StakeLauncher, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.NecromanticScroll, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(summonerDamageKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.SpookyTwig, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.CursedSapling, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 20, ItemID.SpookyHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMartianSaucerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 50, ItemID.MartianSaucerTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.InfluxWaver, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.XenoStaff, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.LaserMachinegun, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.ChargedBlasterCannon, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.Xenopopper, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.ElectrosphereLauncher, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.LaserDrill, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.CosmicCarKey, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ItemID.AntiGravityHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeGoblinSummonerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinSummonerPart>(), 20, ItemID.ShadowFlameKnife, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, goblinSummonerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinSummonerPart>(), 20, ItemID.ShadowFlameBow, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, goblinSummonerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinSummonerPart>(), 20, ItemID.ShadowFlameHexDoll, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, goblinSummonerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFlyingDutchmanRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ItemID.FlyingDutchmanTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ItemID.Cutlass, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 50, ItemID.GoldRing, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 100, ItemID.DiscountCard, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 100, ItemID.DiscountCard, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 150, ItemID.LuckyCoin, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 200, ItemID.CoinGun, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBetsyRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 200, ItemID.BossBagBetsy, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 50, ItemID.BossTrophyBetsy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 50, ItemID.BossMaskBetsy, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 40, ItemID.BetsyWings, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, 3870, 1); //Betsy's Wrath
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, 3858, 1); //Sky dragon's fury
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, 3827, 1); //Flying Dragon
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, ItemID.DD2BetsyBow, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeOgreRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe/* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 200, ItemID.FishronBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            */
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.BossTrophyOgre, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.BossMaskOgre, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            /* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 100, ItemID.ShrimpyTruffle, 1);
             workingCategories = new List<string>() { mountKeyword };
             working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
             working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
             */

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 20, ItemID.DD2PetGhost, 1);
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.ApprenticeScarf, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(summonerDamageKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.SquireShield, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(summonerDamageKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.HuntressBuckler, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(summonerDamageKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, ItemID.MonkBelt, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(summonerDamageKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, 3852, 1); //Tome of infinite wisdom
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, 3835, 1); //Sleepy Octopod
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, 3823, 1); //Brand of the Inferno
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, 3836, 1); //Ghastly Glaive
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 40, 3854, 1); //Phantom Pheonix
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDarkMageRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe/* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 200, ItemID.FishronBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            */
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 40, ItemID.BossTrophyDarkmage, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 40, ItemID.BossMaskDarkMage, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            /* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 100, ItemID.ShrimpyTruffle, 1);
             workingCategories = new List<string>() { mountKeyword };
             working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
             working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
             */
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 40, ItemID.WarTable, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 10, ItemID.WarTableBanner, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ItemID.DD2PetDragon, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ItemID.DD2PetGato, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMoonLordRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 200, ItemID.MoonLordBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 50, ItemID.MoonLordTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 50, ItemID.BossMaskMoonlord, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 50, ItemID.SuspiciousLookingTentacle, 1);
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 50, ItemID.GravityGlobe, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 2, ItemID.PortalGun, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 1, ItemID.LunarOre, 20);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.Meowmere, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.StarWrath, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.Terrarian, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.SDMG, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, 3546, 1); //celebration
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.LastPrism, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.LunarFlareBook, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, ItemID.RainbowCrystalStaff, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 20, 3569, 1); //lunar portal
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 1, ItemID.CelestialSigil, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLunaticCultistRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe/* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 200, ItemID.FishronBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            */
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 50, ItemID.AncientCultistTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 50, ItemID.BossMaskCultist, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            /* working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 100, ItemID.ShrimpyTruffle, 1);
             workingCategories = new List<string>() { mountKeyword };
             working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
             working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
             */
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 2, ItemID.LunarCraftingStation, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDukeFishronRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 200, ItemID.FishronBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 50, ItemID.DukeFishronTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 50, ItemID.DukeFishronMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 100, ItemID.ShrimpyTruffle, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ItemID.Tsunami, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ItemID.BubbleGun, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ItemID.RazorbladeTyphoon, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ItemID.Flairon, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 1, ItemID.TruffleWorm, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGolemRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 200, ItemID.GolemBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 50, ItemID.GolemTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 50, ItemID.GolemMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 100, ItemID.ShinyStone, 1);
            workingCategories = makeAccessoryCategories(lifeKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.Stynger, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 1, ItemID.StyngerBolt, 20);
            workingCategories = makeAmmoCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.HeatRay, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.Picksaw, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.StaffofEarth, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.PossessedHatchet, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.GolemFist, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.SunStone, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(defenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.EyeoftheGolem, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 1, ItemID.BeetleShell, 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 1, ItemID.LihzahrdPowerCell, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, golemKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePlanteraRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 200, ItemID.PlanteraBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 50, ItemID.PlanteraTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 50, ItemID.PlanteraMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 100, ItemID.SporeSac, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 100, ItemID.Seedling, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 250, ItemID.TheAxe, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, axeWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 25, ItemID.PygmyStaff, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.GrenadeLauncher, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.VenusMagnum, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.LeafBlower, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.WaspGun, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.NettleBurst, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.Seedler, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.FlowerPow, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ItemID.ThornHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 5, ItemID.TempleKey, 1);
            workingCategories = new List<string> { utilityKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSkeletronPrimeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 200, ItemID.SkeletronPrimeBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 50, ItemID.SkeletronPrimeTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 50, ItemID.SkeletronPrimeMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 100, ItemID.MechanicalBatteryPiece, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 1, ItemID.HallowedBar, 6);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 1, ItemID.SoulofFright, 8);
            workingCategories = makeMaterialCategories(SoulsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 1, ItemID.MechanicalSkull, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makeDestroyerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 200, ItemID.DestroyerBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 50, ItemID.DestroyerTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 50, ItemID.DestroyerMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 100, ItemID.MechanicalWagonPiece, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 1, ItemID.HallowedBar, 6);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 1, ItemID.SoulofMight, 8);
            workingCategories = makeMaterialCategories(SoulsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheDestroyerPart>(), 1, ItemID.MechanicalWorm, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeTwinsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 200, ItemID.TwinsBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 50, ItemID.SpazmatismTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 50, ItemID.RetinazerTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 50, ItemID.TwinMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 100, ItemID.MechanicalWheelPiece, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 1, ItemID.HallowedBar, 6);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 1, ItemID.SoulofSight, 8);
            workingCategories = makeMaterialCategories(SoulsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<TheTwinsPart>(), 2, ItemID.MechanicalEye, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWoFRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 200, ItemID.WallOfFleshBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 50, ItemID.WallofFleshTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 50, ItemID.FleshMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.BreakerBlade, 1);
            workingCategories = makeAccessoryCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.ClockworkAssaultRifle, 1);
            workingCategories = makeAccessoryCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.LaserRifle, 1);
            workingCategories = makeAccessoryCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.WarriorEmblem, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, meleeDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.RangerEmblem, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, rangedDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.SorcererEmblem, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, magicDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ItemID.SummonerEmblem, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, summonerDamageKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 5, ItemID.Pwnhammer, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 1, ItemID.GuideVoodooDoll, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);



            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSkeletronRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 200, ItemID.SkeletronBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 50, ItemID.SkeletronTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 50, ItemID.SkeletronMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 100, ItemID.BoneGlove, 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 40, ItemID.SkeletronHand, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 40, ItemID.BookofSkulls, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 1, ItemID.ClothierVoodooDoll, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeQueenBeeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 200, ItemID.QueenBeeBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 50, ItemID.QueenBeeTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 50, ItemID.BeeMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 100, ItemID.HiveBackpack, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 100, ItemID.Nectar, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 100, ItemID.HoneyedGoggles, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 25, ItemID.BeeHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 25, ItemID.BeeShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 25, ItemID.BeePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ItemID.HiveWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ItemID.HoneyComb, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ItemID.BeeGun, 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ItemID.BeeKeeper, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ItemID.BeesKnees, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 1, ItemID.Beenade, 5);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, explosiveWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 1, ItemID.BeeWax, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 1, ItemID.Abeemination, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBoCRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 200, ItemID.BrainOfCthulhuBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 50, ItemID.BrainofCthulhuTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 50, ItemID.BrainMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 100, ItemID.BrainOfConfusion, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            workingCategories.AddRange(makeAccessoryCategories(immunityKeyword, defenseKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 100, ItemID.BoneRattle, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 5, ItemID.TissueSample, 100);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 5, ItemID.CrimtaneOre, 200);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 1, ItemID.BloodySpine, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEoWRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 200, ItemID.EaterOfWorldsBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 50, ItemID.EaterofWorldsTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 50, ItemID.EaterMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 100, ItemID.WormScarf, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 100, ItemID.EatersBone, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 5, ItemID.ShadowScale, 100);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 5, ItemID.DemoniteOre, 200);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 1, ItemID.WormFood, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEoCRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 200, ItemID.EyeOfCthulhuBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 50, ItemID.EyeofCthulhuTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 50, ItemID.EyeMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 100, ItemID.EoCShield, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 100, ItemID.Binoculars, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 5, ItemID.CrimtaneOre, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 5, ItemID.DemoniteOre, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 1, ItemID.SuspiciousLookingEye, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EyeOfCthulhuPart>(), 2000, ItemID.AviatorSunglasses, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeKingSlimeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 200, ItemID.KingSlimeBossBag, 1);
            workingCategories = new List<string>() { TreasureBagKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 50, ItemID.KingSlimeTrophy, 1);
            workingCategories = new List<string>() { TrophyKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 50, ItemID.KingSlimeMask, 1);
            workingCategories = new List<string>() { maskKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 100, ItemID.RoyalGel, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.NinjaHood, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.NinjaShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.NinjaPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.SlimySaddle, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.SlimeHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 20, ItemID.SlimeGun, 1);
            workingCategories = makeWeaponsCategories(trueDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 5, ItemID.Solidifier, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 1, ItemID.SlimeCrown, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        #endregion
    }
}
