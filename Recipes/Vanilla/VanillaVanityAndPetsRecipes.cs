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
        private void makeVanityRecipes()
        {
            makeVanityHeadRecipes();
            makeVanityBodyRecipes();
            makeVanityLegsRecipes();
            makeVanityAccessoryRecipes();
            makeDyeRecipes();
        }

        private void makeDyeRecipes()
        {
            List<int> dyes = new List<int>()
            {
                ItemID.TeamDye,
                ItemID.TeamHairDye,
                ItemID.HairDyeRemover,
                ItemID.MartianHairDye,
                ItemID.MartianArmorDye,
                ItemID.ReflectiveDye,
                ItemID.TwilightHairDye,
                3597,
                3598,
                3600
            };

            for(int i = 1007; i <= 1070; i++)
            {
                dyes.Add(i);
            }

            for (int i = 1977; i <= 1986; i++)
            {
                dyes.Add(i);
            }
            for (int i = 2869; i <= 2879; i++)
            {
                dyes.Add(i);
            }
            for (int i = 2883; i <= 2885; i++)
            {
                dyes.Add(i);
            }
            for (int i = 3025; i <= 3028; i++)
            {
                dyes.Add(i);
            }
            for (int i = 3038; i <= 3042; i++)
            {
                dyes.Add(i);
            }
            for (int i = 3526; i <= 3530; i++)
            {
                dyes.Add(i);
            }
            for (int i = 3533; i <= 3535; i++)
            {
                dyes.Add(i);
            }
            for (int i = 3550; i <= 3562; i++)
            {
                dyes.Add(i);
            }

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            foreach (int dye in dyes)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DyePart>(), 1, dye, 1);
                workingCategories = makeVanityCategories(dyeKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); PartRecipes.addRecipe(working);
            }
        }

        private void makeVanityLegsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 80, ItemID.EskimoPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.MummyPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.SailorPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.BuccaneerPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkinMoonPart>(), 15, ItemID.ScarecrowPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 50, ItemID.LamiaPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianCostumePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianUniformPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinPants, 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinPants, 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 20, ItemID.DjinnsCurse, 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 20);
            working.addPart(ModContent.ItemType<HardmodePart>(), 20);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 20, ItemID.DjinnsCurse, 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 20);
            working.addPart(ModContent.ItemType<HardmodePart>(), 20);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeVanityBodyRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 25, ItemID.TheBrideDress, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, ItemID.TheBrideDress, 1);
            working.addPart(ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.PharaohsRobe, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 80, ItemID.EskimoCoat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.MummyShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RainPart>(), 25, ItemID.RainCoat, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.SailorShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.BuccaneerShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkinMoonPart>(), 15, ItemID.ScarecrowShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 50, ItemID.LamiaShirt, 1);           
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianCostumeShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianUniformTorso, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinShirt, 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinShirt, 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        

        private void makeVanityHeadRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.JungleRose, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            workingCategories.AddRange(makeMaterialCategories(plantsMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 5, ItemID.BunnyHood, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 25, ItemID.TopHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, ItemID.TopHat, 1);
            working.addPart(ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.ArchaeologistsHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 40, ItemID.PlumbersHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 40, ItemID.RobotHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 25, ItemID.TheBrideHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 1, ItemID.TheBrideHat, 1);
            working.addPart(ModContent.ItemType<RareEnemyPart>(), 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.PharaohsMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 80, ItemID.EskimoHood, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GreenCap, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 40, ItemID.MummyMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 100, ItemID.Skull, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RainPart>(), 25, ItemID.RainHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RainPart>(), 25, ItemID.UmbrellaHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.EyePatch, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.SailorHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 25, ItemID.BuccaneerBandana, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkinMoonPart>(), 15, ItemID.ScarecrowHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 20, ItemID.MoonMask, 1);
            working.addPart(ModContent.ItemType<CorruptionUndergroundPart>(), 10);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 20, ItemID.MoonMask, 1);
            working.addPart(ModContent.ItemType<CrimsonUndergroundPart>(), 10);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 30, ItemID.SunMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 50, ItemID.LamiaHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianCostumeMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianInvasionPart>(), 30, ItemID.MartianUniformHelmet, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinHat, 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 20, ItemID.PedguinHat, 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 20);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.GiantBow, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkinMoonPart>(), 10, ItemID.JackOLanternMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeVanityAccessoryRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 50, ItemID.WhoopieCushion, 1);
            workingCategories = makeVanityCategories(accessoryKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePetsRecipes()
        {
            makeLightPetsRecipes();
            makeNormalPetsRecipes();
        }

        private void makeNormalPetsRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 30, ItemID.Fish, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(),100, ItemID.Seaweed, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
           
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonGuardianPart>(), 5, ItemID.BoneKey, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 100, ItemID.LizardEgg, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 50);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 300, ItemID.AmberMosquito, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SolarEclipsePart>(), 50, ItemID.EyeSpring, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, solarEclipseKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLightPetsRecipes()
        {

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CorruptionSurfacePart>(), 25, ItemID.ShadowOrb, 1);
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 25, ItemID.CrimsonHeart, 1);
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 50, ItemID.WispinaBottle, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 10);
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }
    }
}
