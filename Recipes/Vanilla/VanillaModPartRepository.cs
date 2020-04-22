using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using ARareItemSwapJPANs.Parts.Vanilla.Weather;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Vanilla
{
    public partial class VanillaModPartRepository : ModPartRepository
    {

        

        public override void AddRecipes()
        {
            makePartExchangeRecipes();
            makeMaterialRecipes();
            makeAccessoryRecipes();
            makeUtilityRecipes();
            makeWeaponRecipes();
            makePetsRecipes();
            makeFurnitureRecipes();
            makeVanityRecipes();
            makeBiomeKeysAndChestsRecipes();

            makeCritterRecipes();

            makeBossDropRecipes();
            makeFishingRecipes();
            makeSeasonalRecipes();
            makeDeveloperRecipes();

            makeShopRecipes();

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 40, ItemID.BrainScrambler, 1);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 50, ItemID.AncientHorn, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 25);
            workingCategories = new List<string>() { mountKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBiomeKeysAndChestsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 250, ItemID.JungleKey, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 250, ItemID.PiranhaGun, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 3, ItemID.JungleChest, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 250, ItemID.CorruptionKey, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 250, ItemID.ScourgeoftheCorruptor, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 3, ItemID.CorruptionChest, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 250, ItemID.CrimsonKey, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 250, ItemID.VampireKnives, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 3, ItemID.CrimsonChest, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 250, ItemID.HallowedKey, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 250, ItemID.RainbowGun, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 3, ItemID.HallowedChest, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 250, ItemID.FrozenKey, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 250, ItemID.StaffoftheFrostHydra, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 3, ItemID.FrozenChest, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeUtilityRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.MagicMirror, 1);
            workingCategories = new List<string>() { utilityKeyword};
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 25, ItemID.IceMirror, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, ItemID.BreathingReed, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.ShadowKey, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 3, ItemID.GoldenKey, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GoldenKey, 3);
            working.addPart(ModContent.ItemType<RareEnemyPart>(),1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 80, ItemID.FiberglassFishingPole,1);
            workingCategories = new List<string>() { utilityKeyword };
            workingCategories.AddRange(makeFishingCategories(utilityKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 20, ItemID.LivingMahoganyWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 20, ItemID.LivingMahoganyLeafWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 20, ItemID.BoneWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.LivingWoodWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.LeafWand, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, ItemID.Umbrella, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 40, ItemID.UnicornonaStick, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 20, ItemID.WebSlinger, 1);
            workingCategories = new List<string>() { utilityKeyword  + "/" + hooksKeyword};
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 5, ItemID.LihzahrdPowerCell, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 5, ItemID.PirateMap, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 2);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedUndergroundPart>(), 80, ItemID.RodofDiscord, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 20);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 75, ItemID.MoneyTrough, 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePartExchangeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionUndergroundPart>(), 1, ModContent.ItemType<CrimsonUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 1, ModContent.ItemType<CorruptionUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 1, ModContent.ItemType<CrimsonMimicPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 1, ModContent.ItemType<CorruptionMimicPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionUndergroundPart>(),1,ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));            
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 1, ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 1, ModContent.ItemType<DesertSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonSurfacePart>(), 1, ModContent.ItemType<DungeonUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ModContent.ItemType<ForestSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomSurfacePart>(), 1, ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteSurfacePart>(), 1, ModContent.ItemType<GraniteUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedUndergroundPart>(), 1, ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellSurfacePart>(), 1, ModContent.ItemType<HellUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.available = () => Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().parts.ContainsKey(ARareItemSwapJPANs.ItemIDToTag(ModContent.ItemType<HellSurfacePart>())); 
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 1, ModContent.ItemType<IceSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ModContent.ItemType<JungleSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleSurfacePart>(), 1, ModContent.ItemType<MarbleUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteUndergroundPart>(), 1, ModContent.ItemType<MeteoriteSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanUndergroundPart>(), 1, ModContent.ItemType<OceanSurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkyUndergroundPart>(), 1, ModContent.ItemType<SkySurfacePart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working.available = () => Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().parts.ContainsKey(ARareItemSwapJPANs.ItemIDToTag(ModContent.ItemType<SkyUndergroundPart>()));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveSurfacePart>(), 1, ModContent.ItemType<SpiderCaveUndergroundPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

          
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionMimicPart>(), 1, ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.irreversible = true;
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonMimicPart>(), 1, ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.irreversible = true;
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedMimicPart>(), 1, ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.irreversible = true;
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleMimicPart>(), 1, ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.irreversible = true;
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 1, ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.irreversible = true;
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MinorShopPart>(), 100, ModContent.ItemType<ShopPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MinorShopPart>(), 10000, ModContent.ItemType<MajorShopPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ShopPart>(), 100, ModContent.ItemType<MajorShopPart>(), 1);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ShopPart>(), 1, ModContent.ItemType<MinorShopPart>(), 100);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MajorShopPart>(), 1, ModContent.ItemType<ShopPart>(), 100);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MajorShopPart>(), 1, ModContent.ItemType<MinorShopPart>(), 10000);
            workingCategories = new List<string>() { "Parts" };
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        public override List<int> getEventPartsDrops(NPC npc, Player p)
        {
            //Config c = ModContent.GetInstance<Config>();
            List<int> parts = new List<int>();
            if (Main.bloodMoon)
                parts.Add(ModContent.ItemType<BloodMoonPart>());
            if (Main.eclipse)
                parts.Add(ModContent.ItemType<SolarEclipsePart>());
            if (Main.pumpkinMoon)
                parts.Add(ModContent.ItemType<PumpkinMoonPart>());
            if (Main.snowMoon)
                parts.Add(ModContent.ItemType<FrostMoonPart>());
            if(Main.slimeRain)
                parts.Add(ModContent.ItemType<SlimeRainPart>());
            switch (Main.invasionType)
            {
                case InvasionID.GoblinArmy:
                    parts.Add(ModContent.ItemType<GoblinArmyPart>());
                    break;
                case InvasionID.SnowLegion:
                    parts.Add(ModContent.ItemType<FrostLegionPart>());
                    break;
                case InvasionID.MartianMadness:
                    parts.Add(ModContent.ItemType<MartianInvasionPart>());
                    break;
                case InvasionID.PirateInvasion:
                    parts.Add(ModContent.ItemType<PirateInvasionPart>());
                    break;
            }
            return parts;
        }

        public override List<int> getBiomePartsDrops(NPC npc, Player p)
        {
            List<int> parts = new List<int>();
            PartsPlayer plr = p.GetModPlayer<PartsPlayer>();
            
            if (p.ZoneSkyHeight)
                parts.Add(ModContent.ItemType<SkySurfacePart>());
            if(p.ZoneUnderworldHeight)
                parts.Add(ModContent.ItemType<HellUndergroundPart>());
            if (plr.ZoneGranite)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<GraniteSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<GraniteSurfacePart>());
                    parts.Add(ModContent.ItemType<GraniteUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<GraniteUndergroundPart>());
            }
            if (plr.ZoneMarble)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<MarbleSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<MarbleSurfacePart>());
                    parts.Add(ModContent.ItemType<MarbleUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<MarbleUndergroundPart>());
            }
            if (plr.ZoneSpiderCave)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<SpiderCaveSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<SpiderCaveSurfacePart>());
                    parts.Add(ModContent.ItemType<SpiderCaveUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<SpiderCaveUndergroundPart>());
            }
            bool notPurity = false;
            if (p.ZoneCorrupt)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<CorruptionSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<CorruptionSurfacePart>());
                    parts.Add(ModContent.ItemType<CorruptionUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<CorruptionUndergroundPart>());
            }
            if (p.ZoneCrimson)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<CrimsonSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<CrimsonSurfacePart>());
                    parts.Add(ModContent.ItemType<CrimsonUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<CrimsonUndergroundPart>());
            }
            if (p.ZoneHoly)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<HallowedSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<HallowedSurfacePart>());
                    parts.Add(ModContent.ItemType<HallowedUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<HallowedUndergroundPart>());
            }
            if (p.ZoneDesert || p.ZoneUndergroundDesert)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<DesertSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<DesertSurfacePart>());
                    parts.Add(ModContent.ItemType<DesertUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<DesertUndergroundPart>());
            }

            if (p.ZoneDungeon)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<DungeonSurfacePart>());
                else
                    parts.Add(ModContent.ItemType<DungeonUndergroundPart>());
            }
            if (p.ZoneJungle)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<JungleSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<JungleSurfacePart>());
                    parts.Add(ModContent.ItemType<JungleUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<JungleUndergroundPart>());
            }

            if (p.ZoneMeteor)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<MeteoriteSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<MeteoriteSurfacePart>());
                    parts.Add(ModContent.ItemType<MeteoriteUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<MeteoriteUndergroundPart>());
            }
            if (p.ZoneSnow)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<IceSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<IceSurfacePart>());
                    parts.Add(ModContent.ItemType<IceUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<IceUndergroundPart>());
            }
            if (p.ZoneBeach)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<OceanSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<OceanSurfacePart>());
                    parts.Add(ModContent.ItemType<OceanUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<OceanUndergroundPart>());
            }

            if (p.ZoneGlowshroom)
            {
                notPurity = true;
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<GlowingMushroomSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<GlowingMushroomSurfacePart>());
                    parts.Add(ModContent.ItemType<GlowingMushroomUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<GlowingMushroomUndergroundPart>());
            }

            if (!notPurity)
            {
                if (p.ZoneSkyHeight || p.ZoneOverworldHeight)
                    parts.Add(ModContent.ItemType<ForestSurfacePart>());
                else if (p.ZoneDirtLayerHeight)
                {
                    parts.Add(ModContent.ItemType<ForestSurfacePart>());
                    parts.Add(ModContent.ItemType<ForestUndergroundPart>());
                }
                else
                    parts.Add(ModContent.ItemType<ForestUndergroundPart>());
            }

            return parts;
        }

        public override List<int> getWeatherPartsDrops(NPC npc, Player p)
        {
            List<int> parts = new List<int>();
            if (Main.raining && !p.ZoneDesert && !p.ZoneDirtLayerHeight && !p.ZoneRockLayerHeight && !p.ZoneUnderworldHeight)
                parts.Add(ModContent.ItemType<RainPart>());
            if((p.ZoneDesert || p.ZoneUndergroundDesert) && Sandstorm.Happening)
                parts.Add(ModContent.ItemType<SandstormPart>());

            return parts;
        }

        public override List<int> getStagePartsDrops(NPC npc, Player p)
        {
            List<int> parts = new List<int>();
            if (Main.hardMode)
                parts.Add(ModContent.ItemType<HardmodePart>());
            if (NPC.downedPlantBoss)
                parts.Add(ModContent.ItemType<PostPlanteraPart>());
            if(NPC.downedMoonlord)
                parts.Add(ModContent.ItemType<PostMoonLordPart>());
            return parts;
        }

    }
}
