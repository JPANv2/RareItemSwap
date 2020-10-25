using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Events;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using ARareItemSwapJPANs.Parts.Vanilla.Weather;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Vanilla
{
    public partial class VanillaModPartRepository : ModPartRepository
    {
        private void makeMaterialRecipes()
        {
            makeEnemyDropsMaterialRecipe();
            makeFillerBlockRecipes();
            makePlantsRecipes();
            makeWoodRecipes();
            makeOreRecipes();
            makeLifeRecipes();
            makeGemRecipes();
            makeLiquidRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 5, ItemID.FallenStar, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 5, ItemID.FallenStar, 3);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Cobweb, 20);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 1, ItemID.Cobweb, 100);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 5, ItemID.Bacon, 1);
            workingCategories = makeMaterialCategories(foodKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEnemyDropsMaterialRecipe()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Gel, 15);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            //working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, slimeRainKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SlimeRainPart>(), 1, ItemID.Gel, 50);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, slimeRainKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Lens, 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 15, ItemID.BlackLens, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.RottenChunk, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.Vertebrae, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.WormTooth, 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.AntlionMandible, 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Hook, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Hook, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.Bone, 25);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.Stinger, 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.Vine, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.JungleSpores, 25);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.SharkFin, 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.Feather, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ItemID.TatteredCloth, 3);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.PixieDust, 12);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.UnicornHorn, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedUndergroundPart>(), 1, ItemID.SoulofLight, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionUndergroundPart>(), 1, ItemID.SoulofNight, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 1, ItemID.SoulofNight, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ItemID.SoulofFlight, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            working.addPart(ModContent.ItemType<SkySurfacePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionUndergroundPart>(), 1, ItemID.CursedFlame, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonUndergroundPart>(), 1, ItemID.Ichor, 12);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.LightShard, 3);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            working.addPart(ModContent.ItemType<DesertSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.DarkShard, 3);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            working.addPart(ModContent.ItemType<DesertSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.DarkShard, 3);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            working.addPart(ModContent.ItemType<DesertSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 5, ItemID.PurpleMucos, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 5, ItemID.BlackInk, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.RedHusk, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.CyanHusk, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.VioletHusk, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 25, ItemID.BrokenBatWing, 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 40, ItemID.TurtleShell, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 20, ItemID.FireFeather, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 20, ItemID.BoneFeather, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 20, ItemID.GiantHarpyFeather, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 20, ItemID.TatteredBeeWing, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 10);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.Ectoplasm, 3);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 10, ItemID.BrokenHeroSword, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 1, ItemID.SpiderFang, 5);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.LunarTabletFragment, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 2, ItemID.AncientCloth, 1);
            working.addPart(ModContent.ItemType<DesertUndergroundPart>(), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLiquidRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.WaterBucket, 5);
            workingCategories = makeMaterialCategories(liquidsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.WaterBucket, 5);
            workingCategories = makeMaterialCategories(liquidsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.LavaBucket, 5);
            workingCategories = makeMaterialCategories(liquidsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.LavaBucket, 5);
            workingCategories = makeMaterialCategories(liquidsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.HoneyBucket, 5);
            workingCategories = makeMaterialCategories(liquidsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGemRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;


            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Amethyst, 10);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Topaz, 10);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Emerald, 5);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Sapphire, 5);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Ruby, 1);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Diamond, 1);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 5, ItemID.Amber, 1);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedUndergroundPart>(), 1, ItemID.CrystalShard, 50);
            workingCategories = makeMaterialCategories(gemsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLifeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;


            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.LifeCrystal, 1);
            workingCategories = makeMaterialCategories(lifeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 10, ItemID.LifeFruit, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeMaterialCategories(lifeKeyword);
            workingCategories.AddRange(makeMaterialCategories(plantsMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeOreRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.CopperOre, 24);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.TinOre, 24);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.IronOre, 18);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.LeadOre, 18);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.SilverOre, 16);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.TungstenOre, 16);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.GoldOre, 12);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.PlatinumOre, 12);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.DemoniteOre, 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.CrimtaneOre, 3);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 1, ItemID.Meteorite, 15);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.Hellstone, 15);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            //hardmode

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.CobaltOre, 12);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.PalladiumOre, 12);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.MythrilOre, 8);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.OrichalcumOre, 8);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.AdamantiteOre, 5);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.TitaniumOre, 5);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.ChlorophyteOre, 6);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.LunarOre, 4);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.FragmentVortex, 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.FragmentNebula, 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.FragmentSolar, 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.FragmentStardust, 1);
            workingCategories = makeMaterialCategories(oreMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.CopperBar, 8);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.TinBar, 8);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.IronBar, 6);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.LeadBar, 6);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.SilverBar, 4);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.TungstenBar, 4);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.GoldBar, 3);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.PlatinumBar, 3);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.DemoniteBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eowKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.CrimtaneBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, eocKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MeteoriteSurfacePart>(), 1, ItemID.MeteoriteBar, 5);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, meteoriteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.HellstoneBar, 5);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            //hardmode

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.CobaltBar, 4);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.PalladiumBar, 4);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.MythrilBar, 2);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.OrichalcumBar, 2);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.AdamantiteBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HardmodePart>(), 1, ItemID.TitaniumBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.ChlorophyteBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.SpectreBar, 6);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 7);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1, ItemID.ShroomiteBar, 5);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 5);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostMoonLordPart>(), 1, ItemID.LunarBar, 1);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWoodRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Wood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.BorealWood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.RichMahogany, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.PalmWood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.Ebonwood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.Shadewood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.Pearlwood, 100);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePlantsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;


            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Mushroom, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Pumpkin, 50);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Acorn, 10);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(plantsMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.VileMushroom, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.CorruptSeeds, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.ViciousMushroom, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.CrimsonSeeds, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Sunflower, 2);
            working.irreversible = true;
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1, ItemID.GlowingMushroom, 75);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1, ItemID.MushroomGrassSeeds, 5);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.JungleGrassSeeds, 5);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.Coral, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.Seashell, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.Starfish, 10);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.Cactus, 50);
            workingCategories = makeMaterialCategories(woodMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(plantsMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 5, ItemID.HerbBag, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Daybloom, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.DaybloomSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Blinkroot, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.BlinkrootSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Moonglow, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.MoonglowSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.Waterleaf, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.WaterleafSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.Fireblossom, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.FireblossomSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.Deathweed, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.DeathweedSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.Deathweed, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.DeathweedSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.Shiverthorn, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.ShiverthornSeeds, 25);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 5, ItemID.SkyBlueFlower, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 5, ItemID.LimeKelp, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 5, ItemID.PinkPricklyPear, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 5, ItemID.YellowMarigold, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 5, ItemID.BlueBerries, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.TealMushroom, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.GreenMushroom, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.OrangeBloodroot, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.VineRope, 50);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 3, ItemID.StrangePlant1, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 3, ItemID.StrangePlant2, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 3, ItemID.StrangePlant3, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 3, ItemID.StrangePlant4, 1);
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFillerBlockRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.DirtBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.ClayBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.SnowBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.ClayBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.StoneBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 1, ItemID.EbonstoneBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 1, ItemID.CrimstoneBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.PearlstoneBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.IceBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.PurpleIceBlock, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.RedIceBlock, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.PinkIceBlock, 100);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BlueBrick, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BlueBrickWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BlueSlabWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BlueTiledWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BlueBrickPlatform, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GreenBrick, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GreenBrickWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GreenSlabWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GreenTiledWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GreenBrickPlatform, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.PinkBrick, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.PinkBrickWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.PinkSlabWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.PinkTiledWall, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.PinkBrickPlatform, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.DungeonShelf, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.MetalShelf, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.WoodShelf, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.BrassShelf, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.SandBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.SandBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.SandBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.EbonsandBlock, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.EbonsandBlock, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.CrimsandBlock, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.CrimsandBlock, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.PearlsandBlock, 100);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.PearlsandBlock, 100);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.HardenedSand, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.CrimsonHardenedSand, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.CorruptHardenedSand, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.HallowHardenedSand, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.Sandstone, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.CrimsonSandstone, 100);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.CorruptSandstone, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.HallowSandstone, 100);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.DesertFossil, 75);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.FossilOre, 15);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.AshBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 1, ItemID.Obsidian, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Obsidian, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.MudBlock, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.Hive, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.Book, 15);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.SlushBlock, 75);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, snowBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.SiltBlock, 75);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.Cloud, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.RainCloud, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 1, ItemID.LihzahrdBrick, 25);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.LivingFireBlock, 25);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 1, ItemID.MartianConduitPlating, 25);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 1, ItemID.Marble, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteUndergroundPart>(), 1, ItemID.Granite, 100);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
