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

namespace ARareItemSwapJPANs.Recipes.Thorium
{
    public partial class ThoriumModPartRepository : ModPartRepository
    {
        private void makeChestsAndFishingRecipes()
        {
            makeChestRecipes();
            makeFishingRecipes();
        }

        private void makeFishingRecipes()
        {

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 8, "ThoriumMod:StrangeCrate", 1);
            workingCategories = makeFishingCategories(crateKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, "ThoriumMod:AquaticDepthsCrate", 1);
            working.addPart(ModContent.ItemType<AquaticDepthsPart>());
            workingCategories = makeFishingCategories(crateKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, "ThoriumMod:ScarletCrate", 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>());
            workingCategories = makeFishingCategories(crateKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, "ThoriumMod:ScarletCrate", 1);
            working.addPart(ModContent.ItemType<HellUndergroundPart>());
            workingCategories = makeFishingCategories(crateKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);



            //crate drops
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 500, "ThoriumMod:AquaticSonarDevice", 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 120, "ThoriumMod:DrownedDoubloon", 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //quest fish
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, "ThoriumMod:Guppy", 1);
            workingCategories = makeFishingCategories(questFishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
            working.irreversible = true;
            PartRecipes.addRecipe(working);

            //trash
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, "ThoriumMod:IgneousRock", 10);
            workingCategories = makeFishingCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, "ThoriumMod:ScorchedBone", 10);
            workingCategories = makeFishingCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //fish
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, "ThoriumMod:MagmaGill", 5);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, "ThoriumMod:FlamingCrackGut", 5);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, "ThoriumMod:BrainCoral", 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(HealerKeyword, staffWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, "ThoriumMod:RottenCod", 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(HealerKeyword, staffWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, "ThoriumMod:RivetingTadpole", 1);
            working.addPart(ModContent.ItemType<JungleSurfacePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(bardKeyword, windInstrumentKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, "ThoriumMod:SpittingFish", 1);
            working.addPart(ModContent.ItemType<OceanSurfacePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(summonerDamageKeyword, fishKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeChestRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            //wooden chest
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, "ThoriumMod:FortifyingWand", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, "ThoriumMod:Flute", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //web chest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 25, "ThoriumMod:Webgun", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //gold chest (underground)
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, "ThoriumMod:EnchantedArmor", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, "ThoriumMod:EnchantedKnife", 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 100, "ThoriumMod:EnchantedPickaxe", 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //living wood
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, "ThoriumMod:LivingWoodSap", 1);
            workingCategories = makeAccessoryCategories(summonerDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //ivy
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, "ThoriumMod:ForestOcarina", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, "ThoriumMod:TheDigester", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //water chest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:BubbleMagnet", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, "ThoriumMod:BubbleMagnet", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //locked chest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:NaiadShiv", 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:StreamSting", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:HighTide", 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:StrongestLink", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, flailWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:BoneReaper", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, "ThoriumMod:BoneReaper", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //shadowChest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:Nocturne", 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //depth chest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:MagicConch", 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, brassInstrumentKeyword);  working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:SteelDrum", 1);
            workingCategories = makeWeaponsCategories(bardKeyword, percursionInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:AnglerBowl", 1);
            workingCategories =makeAccessoryCategories(lightSourceKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:SeaTurtlesBulwark", 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 25, "ThoriumMod:RainStone", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //scarlet chest
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:MixTape", 1);
            workingCategories = makeAccessoryCategories(bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 45, "ThoriumMod:MixTape", 1);
            workingCategories = makeAccessoryCategories(bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:MaggotItem", 1);
            workingCategories = new List<string>() { mountKeyword + "/" + transformationKeyword}; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 45, "ThoriumMod:MaggotItem", 1);
            workingCategories = new List<string>() { mountKeyword + "/" + transformationKeyword };  working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:LootRang", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 45, "ThoriumMod:LootRang", 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:SpringSteps", 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 45, "ThoriumMod:SpringSteps", 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 25, "ThoriumMod:DeepStaff", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 45, "ThoriumMod:DeepStaff", 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 30, "ThoriumMod:RingofUnity", 1);
            workingCategories = makeAccessoryCategories(lifeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 50, "ThoriumMod:RingofUnity", 1);
            workingCategories = makeAccessoryCategories(lifeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 50, "ThoriumMod:MagmaBoundFishingLine", 1);
            workingCategories = makeAccessoryCategories(fishingKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 90, "ThoriumMod:MagmaBoundFishingLine", 1);
            workingCategories = makeAccessoryCategories(fishingKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //Biome Chests
            //depths
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 250, "ThoriumMod:AquaticDepthsBiomeKey", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 250, "ThoriumMod:Fishbone", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AquaticDepthsPart>(), 3, "ThoriumMod:AquaticDepthsBiomeChest", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

           //desert
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 250, "ThoriumMod:DesertBiomeKey", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 250, "ThoriumMod:PharaohsSlab", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 3, "ThoriumMod:DesertBiomeChest", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories,desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            //hell
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 250, "ThoriumMod:UnderworldBiomeKey", 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 200);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 250, "ThoriumMod:PheonixStaff", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 200);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 3, "ThoriumMod:UnderworldBiomeChest", 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }
    }
}
