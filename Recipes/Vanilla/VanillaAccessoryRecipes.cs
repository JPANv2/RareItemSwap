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
        private void makeAccessoryRecipes()
        {
            makeArmorRecipes();
            makeLifeAccessoriesRecipes();
            makeMovementAccessoriesRecipes();
            makeManaAccessoriesRecipes();
            makeDefenseAccessoryRecipes();
            makeAttackAccessoryRecipes();

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 20, ItemID.GuideVoodooDoll, 1);
            workingCategories = makeAccessoryCategories(otherKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 20, ItemID.DepthMeter, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 15, ItemID.DepthMeter, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 10, ItemID.DepthMeter, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 20, ItemID.Compass, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 10, ItemID.Compass, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.Radar, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.CordageGuide, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.JellyfishNecklace, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, ItemID.JellyfishNecklace, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.TallyCounter, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAttackAccessoryRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.FeralClaws, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 25, ItemID.MoonCharm, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(defenseKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 25, ItemID.MoonStone, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(defenseKeyword, offenseKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.MagicQuiver, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 30, ItemID.MagmaStone, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, debuffsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 30, ItemID.ObsidianRose, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 30, ItemID.SharkToothNecklace, 1);
            workingCategories = makeAccessoryCategories(offenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDefenseAccessoryRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.CobaltShield, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, ItemID.Shackle, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 5, ItemID.Shackle, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.LavaCharm, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.AdhesiveBandage, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.AdhesiveBandage, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 35, ItemID.AdhesiveBandage, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.ArmorPolish, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 30, ItemID.Bezoar, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.Nazar, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 25, ItemID.Nazar, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionUndergroundPart>(), 25, ItemID.Nazar, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, ItemID.Blindfold, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 50, ItemID.Blindfold, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 25, ItemID.FastClock, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, ItemID.FastClock, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 50, ItemID.FastClock, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 50, ItemID.Megaphone, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.Megaphone, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 50, ItemID.Megaphone, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, ItemID.Vitamins, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 25, ItemID.Vitamins, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 25, ItemID.TrifoldMap, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.TrifoldMap, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 25, ItemID.TrifoldMap, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 55, ItemID.FrozenTurtleShell, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 25, ItemID.PanicNecklace, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, buffsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 40, ItemID.PocketMirror, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeAccessoryCategories(defenseKeyword, immunityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeManaAccessoriesRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, ItemID.BandofStarpower, 1);
            workingCategories = makeAccessoryCategories(manaKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.NaturesGift, 1);
            workingCategories = makeAccessoryCategories(manaKeyword);
            workingCategories.AddRange(makeMaterialCategories(plantsMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMovementAccessoriesRecipes()
        {
            List<string> workingCategories;
            List<PartRecipe> recipes = new List<PartRecipe>();

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.CloudinaBottle, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 25, ItemID.CloudinaBottle, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.HermesBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 25, ItemID.RocketBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword, movementFlyingKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword, movementFlyingKeyword, movementBootsKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, GoblinThinkererKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 25, ItemID.LuckyHorseshoe, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 25, ItemID.ShinyRedBalloon, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, ItemID.Flipper, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementSwimmingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.AnkletoftheWind, 1);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, ItemID.DivingHelmet, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementSwimmingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.Aglet, 1);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 15, ItemID.NeptunesShell, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementSwimmingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 20, ItemID.FlurryBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 20, ItemID.IceSkates, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 20, ItemID.BlizzardinaBottle, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 75, ItemID.FlowerBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 20, ItemID.ClimbingClaws, 1);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 20, ItemID.ShoeSpikes, 1);
            workingCategories = makeAccessoryCategories(movementKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.FlyingCarpet, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.SandstorminaBottle, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 25, ItemID.WaterWalkingBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 25, ItemID.MothronWings, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 25);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLifeAccessoriesRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.BandofRegeneration, 1);
            workingCategories = makeAccessoryCategories(lifeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.BandofRegeneration, 1);
            workingCategories = makeAccessoryCategories(lifeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeArmorRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 25, ItemID.VikingHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.AncientIronHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 50, ItemID.AncientGoldHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 100, ItemID.AncientShadowHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 100, ItemID.AncientShadowScalemail, 1);
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 100, ItemID.AncientShadowGreaves, 1);
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 80, ItemID.AncientNecroHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 50, ItemID.AncientCobaltHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 50, ItemID.AncientCobaltBreastplate, 1);
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 50, ItemID.AncientCobaltLeggings, 1);
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteUndergroundPart>(), 40, ItemID.NightVisionHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 40, ItemID.GladiatorHelmet, 1);
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 40, ItemID.GladiatorBreastplate, 1);
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 40, ItemID.GladiatorLeggings, 1);
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
