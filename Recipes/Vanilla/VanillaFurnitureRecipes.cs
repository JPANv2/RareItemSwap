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
        private void makeFurnitureRecipes()
        {
            makePaintingRecipes();
            makeMusicBoxRecipes();
            makeStatueRecipes();
            makeChestRecipes();
            makeStationRecipes();
            makeBannerRecipes();
            makeDungeonFurnitureRecipes();
            makeHellFurnitureRecipes();
            makeGoldenFurnitureRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.WaterCandle, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 80, ItemID.SnowballLauncher, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.DartTrap, 1);
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 8, ItemID.GeyserTrap, 1);
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.SuperDartTrap, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.FlameTrap, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.SpikyBallTrap, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.SpearTrap, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.Spike, 15);
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.WoodenSpike, 15);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 1, ItemID.LihzahrdPressurePlate, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(trapWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.ChainLantern, 1);
            workingCategories = makeFurnitureCategories(lightSourceKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            for (int i = 1390; i <= 1395; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, i, 1);
                workingCategories = makeFurnitureCategories(lightSourceKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            }

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.ObsidianLantern, 1);
            workingCategories = makeFurnitureCategories(lightSourceKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 1, ItemID.GoldenLantern, 1);
            workingCategories = makeFurnitureCategories(lightSourceKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 10, ItemID.DjinnLamp, 1);
            workingCategories = makeFurnitureCategories("");
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGoldenFurnitureRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 1, ItemID.GoldenPlatform, 1);
            workingCategories = makeFurnitureCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);
            
            List<int> furnitures = new List<int> {
                ItemID.GoldenDoor,

                ItemID.GoldenBathtub,
                ItemID.GoldenBed,
                ItemID.GoldenClock,
                ItemID.GoldenPiano,
                ItemID.GoldenSink,
                ItemID.GoldenSofa,
                ItemID.GoldenToilet
            };

            List<int> chests = new List<int>()
            {
                ItemID. GoldenChest,
                ItemID. GoldenDresser,
            };

            List<int> lights = new List<int>()
            {
                ItemID.GoldenCandelabra,
                ItemID.GoldenCandle,
                ItemID.GoldenChandelier,
                ItemID.GoldenLamp
            };

            List<int> stations = new List<int>()
            {
                ItemID.GoldenBookcase,
                ItemID.GoldenChair,
                ItemID.GoldenTable,
                ItemID.GoldenWorkbench
            };

            foreach (int furn in furnitures)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 3, furn, 1);
                workingCategories = makeFurnitureCategories("");
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in lights)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 3, furn, 1);
                workingCategories = makeFurnitureCategories(lightSourceKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in chests)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 3, furn, 1);
                workingCategories = makeFurnitureCategories(chestKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            foreach (int furn in stations)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PirateInvasionPart>(), 3, furn, 1);
                workingCategories = makeFurnitureCategories(stationKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

           

        }

        private void makeHellFurnitureRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<int> furnitures = new List<int> {
                ItemID.ObsidianDoor,

                ItemID.ObsidianBathtub,
                ItemID.ObsidianBed,
                ItemID.ObsidianClock,
                ItemID.ObsidianPiano,
                ItemID.ObsidianSink,
                ItemID.ObsidianSofa,
                ItemID.ObsidianVase,
            };

            List<int> chests = new List<int>()
            {
                ItemID. ObsidianChest,
                ItemID. ObsidianDresser,
            };

            List<int> lights = new List<int>()
            {
                ItemID.ObsidianCandelabra,
                ItemID.ObsidianCandle,
                ItemID.ObsidianChandelier,
                ItemID.ObsidianLamp,
                ItemID.DemonTorch
            };

            List<int> stations = new List<int>()
            {
                ItemID.ObsidianBookcase,
                ItemID.ObsidianChair,
                ItemID.ObsidianTable,
                ItemID.ObsidianWorkBench
            };

            foreach (int furn in furnitures)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories("");
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in lights)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(lightSourceKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in chests)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(chestKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            foreach (int furn in stations)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(stationKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

        }

        private void makeDungeonFurnitureRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<int> furnitures = new List<int> { 
                ItemID.DungeonDoor,

                ItemID.BlueDungeonBathtub,
                ItemID.BlueDungeonBed,
                ItemID.DungeonClockBlue,
                ItemID.BlueDungeonDoor,
                ItemID.BlueDungeonPiano,
                ItemID.BlueDungeonSink,
                ItemID.BlueDungeonSofa,
                ItemID.BlueDungeonVase,
                
                ItemID.GreenDungeonBathtub,
                ItemID.GreenDungeonBed,
                ItemID.DungeonClockGreen,
                ItemID.GreenDungeonDoor,
                ItemID.GreenDungeonPiano,
                ItemID.GreenDungeonSink,
                ItemID.GreenDungeonSofa,
                ItemID.GreenDungeonVase,

                ItemID.PinkDungeonBathtub,
                ItemID.PinkDungeonBed,
                ItemID.DungeonClockPink,
                ItemID.PinkDungeonDoor,
                ItemID.PinkDungeonPiano,
                ItemID.PinkDungeonSink,
                ItemID.PinkDungeonSofa,
                ItemID.PinkDungeonVase
            };

            List<int> chests = new List<int>()
            {
                ItemID. BlueDungeonChest,
                ItemID. BlueDungeonDresser,

                ItemID. GreenDungeonChest,
                ItemID. GreenDungeonDresser,

                ItemID. PinkDungeonChest,
                ItemID. PinkDungeonDresser
                
            };

            List<int> lights = new List<int>()
            {
                ItemID. BlueDungeonCandelabra,
                ItemID. BlueDungeonCandle,
                ItemID. BlueDungeonChandelier,
                ItemID. BlueDungeonLamp,
                
                ItemID. GreenDungeonCandelabra,
                ItemID. GreenDungeonCandle,
                ItemID. GreenDungeonChandelier,
                ItemID. GreenDungeonLamp,
                
                ItemID. PinkDungeonCandelabra,
                ItemID. PinkDungeonCandle,
                ItemID. PinkDungeonChandelier,
                ItemID. PinkDungeonLamp
                
            };

            List<int> stations = new List<int>()
            {
                ItemID.BlueDungeonBookcase,
                ItemID.BlueDungeonChair,
                ItemID.BlueDungeonTable,
                ItemID.BlueDungeonWorkBench,

                ItemID.GreenDungeonBookcase,
                ItemID.GreenDungeonChair,
                ItemID.GreenDungeonTable,
                ItemID.GreenDungeonWorkBench,
                
                ItemID.PinkDungeonBookcase,
                ItemID.PinkDungeonChair,
                ItemID.PinkDungeonTable,
                ItemID.PinkDungeonWorkBench,

                ItemID.GothicBookcase,
                ItemID.GothicChair,
                ItemID.GothicTable,
                ItemID.GothicWorkBench
            };

            foreach(int furn in furnitures)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories("");
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); 
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in lights)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(lightSourceKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            foreach (int furn in chests)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(chestKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            foreach (int furn in stations)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, furn, 1);
                workingCategories = makeFurnitureCategories(stationKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
        }

        private void makeBannerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            //Dungeon Banners
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.MarchingBonesBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.NecromanticSign, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.RustedCompanyStandard, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.RaggedBrotherhoodSigil, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.MoltenLegionFlag, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 5, ItemID.DiabolicSigil, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            //hell
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.HellboundBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.HellHammerBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.HelltowerBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.LostHopesofManBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.ObsidianWatcherBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.LavaEruptsBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            //sky
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.WorldBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.SunBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 1, ItemID.GravityBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            //desert pyramid
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 8, ItemID.AnkhBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 8, ItemID.SnakeBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 8, ItemID.OmegaBanner, 1);
            workingCategories = makeFurnitureCategories(bannerKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeStationRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 5, ItemID.Hellforge, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinArmyPart>(), 25, ItemID.TinkerersWorkshop, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, GoblinThinkererKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(),25, ItemID.IceMachine, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 50, ItemID.Extractinator, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertUndergroundPart>(), 40, ItemID.Extractinator, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 60, ItemID.Extractinator, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 25, ItemID.HoneyDispenser, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 25, ItemID.SkyMill, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 25, ItemID.LivingLoom, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CrimsonSurfacePart>(), 50, ItemID.MeatGrinder, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GolemPart>(), 20, ItemID.LihzahrdAltar, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 30, ItemID.AlchemyTable, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 30, ItemID.BewitchingTable, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 25, ItemID.BoneWelder, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 5, ItemID.LihzahrdFurnace, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 20);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 30, ItemID.SharpeningStation, 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeChestRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DungeonUndergroundPart>(), 1, ItemID.GoldChest, 1);
            working.available = () => NPC.downedBoss3;
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 3, ItemID.GoldChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellUndergroundPart>(), 3, ItemID.ShadowChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 3, ItemID.IceChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 3, ItemID.IvyChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PostPlanteraPart>(), 3, ItemID.LihzahrdChest, 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 3, ItemID.LivingWoodChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 1, ItemID.WebCoveredChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 1, ItemID.WaterChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 3, ItemID.SkywareChest, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeStatueRecipes()
        {
            makeFunctionalStatueRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;


            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.AngelStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.AnvilStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ArmorStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.AxeStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BoomerangStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BootStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BowStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.CorruptStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.CrossStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.EyeballStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.GargoyleStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.GloomStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.GoblinStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.HammerStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.HornetStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ImpStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.MushroomStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.PickaxeStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.PillarStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.PotStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.PotionStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ReaperStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ShieldStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.SpearStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.SunflowerStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.SwordStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.TreeStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.WomanStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 5, ItemID.LihzahrdStatue, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 5, ItemID.LihzahrdGuardianStatue, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 5, ItemID.LihzahrdWatcherStatue, 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.available = () => NPC.downedPlantBoss;
            workingCategories = makeFurnitureCategories(statueKeyword, decorativeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFunctionalStatueRecipes()
        {
            makeEnemySpawnStatueRecipes();
            makeCritterSpawnStatueRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.KingStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.QueenStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.BombStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.HeartStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, lifeKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 25, ItemID.StarStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, manaKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCritterSpawnStatueRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;


            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BirdStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BuggyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 5, ItemID.BuggyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.BunnyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ButterflyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.DuckStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.FireflyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.FishStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.FrogStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 5, ItemID.FrogStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.GrasshopperStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.MouseStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.PenguinStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.ScorpionStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.SnailStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.SquirrelStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 5, ItemID.WormStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, critterKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEnemySpawnStatueRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.ZombieArmStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.BatStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.BloodZombieStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 5, ItemID.BloodZombieStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.BoneSkeletonStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.ChestStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ItemID.ChestStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.CrabStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 10, ItemID.CrabStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.DripplerStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BloodMoonPart>(), 5, ItemID.DripplerStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, bloodMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.GraniteGolemStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteUndergroundPart>(), 5, ItemID.GraniteGolemStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, graniteBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.HarpyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkySurfacePart>(), 5, ItemID.HarpyStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.HopliteStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 5, ItemID.HopliteStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.JellyfishStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 10, ItemID.JellyfishStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.MedusaStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MarbleUndergroundPart>(), 5, ItemID.MedusaStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, marbleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.PigronStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.PiranhaStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleUndergroundPart>(), 10, ItemID.PiranhaStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.SharkStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OceanSurfacePart>(), 10, ItemID.SharkStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.SlimeStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, slimeRainKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SlimeRainPart>(), 5, ItemID.SlimeStatue, 1);
            workingCategories = makeFurnitureCategories(statueKeyword, functionalStatueKeyword, enemyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, slimeRainKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.UndeadVikingStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceUndergroundPart>(), 10, ItemID.UndeadVikingStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.UnicornStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 5, ItemID.UnicornStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.WallCreeperStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SpiderCaveUndergroundPart>(), 5, ItemID.WallCreeperStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, spiderCaveBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 15, ItemID.WraithStatue, 1);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePaintingRecipes()
        {

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            PartRecipe working;
            List<int> paintings = new List<int>()
            {
                //painter
                ItemID.Daylight,
                ItemID.ColdWatersintheWhiteLand,
                ItemID.DeadlandComesAlive,
                ItemID.DoNotStepontheGrass,
                ItemID.EvilPresence,
                ItemID.FirstEncounter,
                ItemID.GoodMorning,
                ItemID.TheLandofDeceivingLooks,
                ItemID.LightlessChasms,
                ItemID.PlaceAbovetheClouds,
                ItemID.SecretoftheSands,
                ItemID.SkyGuardian,
                ItemID.ThroughtheWindow,
                ItemID.UndergroundReward,
                //travelling merchant
                ItemID.PaintingAcorns,
                ItemID.PaintingCastleMarsberg,
                ItemID.PaintingColdSnap,
                ItemID.PaintingCursedSaint,
                ItemID.PaintingMartiaLisa,
                ItemID.MoonLordPainting,
                ItemID.PaintingTheSeason,
                ItemID.PaintingSnowfellas,
                ItemID.PaintingTheTruthIsUpThere,
                //underground cabin
                ItemID.AmericanExplosive,
                ItemID.CrownoDevoursHisLunch,
                ItemID.Discover,
                ItemID.FatherofSomeone,
                ItemID.FindingGold,
                ItemID.GloriousNight,
                ItemID.GuidePicasso,
                ItemID.Land,
                ItemID.TheMerchant,
                ItemID.NurseLisa,
                ItemID.OldMiner,
                ItemID.RareEnchantment,
                ItemID.Sunflowers,
                ItemID.TerrarianGothic,
                ItemID.Waldo,
                //dungeon
                ItemID.BloodMoonRising,
                ItemID.BoneWarp,
                ItemID.TheCreationoftheGuide,
                ItemID.TheCursedMan,
                ItemID.TheDestroyer,
                ItemID.Dryadisque,
                ItemID.TheEyeSeestheEnd,
                ItemID.FacingtheCerebralMastermind,
                ItemID.GloryoftheFire,
                ItemID.GoblinsPlayingPoker,
                ItemID.GreatWave,
                ItemID.TheGuardiansGaze,
                ItemID.TheHangedMan,
                ItemID.Impact,
                ItemID.ThePersistencyofEyes,
                ItemID.PoweredbyBirds,
                ItemID.TheScreamer,
                ItemID.SkellingtonJSkellingsworth,
                ItemID.SparkyPainting,
                ItemID.SomethingEvilisWatchingYou,
                ItemID.StarryNight,
                ItemID.TrioSuperHeroes,
                ItemID.TheTwinsHaveAwoken,
                ItemID.UnicornCrossingtheHallows,
                //hell
                ItemID.DarkSoulReaper,
                ItemID.Darkness,
                ItemID.DemonsEye,
                ItemID.FlowingMagma,
                ItemID.HandEarth,
                ItemID.ImpFace,
                ItemID.LakeofFire,
                ItemID.LivingGore,
                ItemID.OminousPresence,
                ItemID.ShiningMoon,
                ItemID.Skelehead,
                ItemID.TrappedGhost,
                //goodie bags
                ItemID.BitterHarvest,
                ItemID.BloodMoonCountess,
                ItemID.HallowsEve,
                ItemID.JackingSkeletron,
                ItemID.MorbidCuriosity,
                //angler
                ItemID.PillaginMePixels,
            };

            foreach (int paint in paintings)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PaintingPart>(), 1, paint, 1);
                workingCategories = makeFurnitureCategories(paintingKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PaintingPart>(), 1, ItemID.Catacomb, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeFurnitureCategories(paintingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PaintingPart>(), 1, ItemID.HangingSkeleton, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeFurnitureCategories(paintingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PaintingPart>(), 1, ItemID.WallSkeleton, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 5);
            workingCategories = makeFurnitureCategories(paintingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);
        }

        private void makeMusicBoxRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<int> boxes = new List<int>()
            {
                ItemID.MusicBox,
                ItemID.MusicBoxAltOverworldDay,
                ItemID.MusicBoxAltUnderground,
                ItemID.MusicBoxBoss1,
                ItemID.MusicBoxBoss2,
                ItemID.MusicBoxBoss3,
                ItemID.MusicBoxBoss4,
                ItemID.MusicBoxBoss5,
                ItemID.MusicBoxCorruption,
                ItemID.MusicBoxCrimson,
                ItemID.MusicBoxDD2,
                ItemID.MusicBoxDesert,
                ItemID.MusicBoxDungeon,
                ItemID.MusicBoxEclipse,
                ItemID.MusicBoxEerie,
                ItemID.MusicBoxFrostMoon,
                ItemID.MusicBoxGoblins,
                ItemID.MusicBoxHell,
                ItemID.MusicBoxIce,
                ItemID.MusicBoxJungle,
                ItemID.MusicBoxLunarBoss,
                ItemID.MusicBoxMartians,
                ItemID.MusicBoxNight,
                ItemID.MusicBoxOcean,
                ItemID.MusicBoxOverworldDay,
                ItemID.MusicBoxPirates,
                ItemID.MusicBoxPlantera,
                ItemID.MusicBoxPumpkinMoon,
                ItemID.MusicBoxRain,
                ItemID.MusicBoxSandstorm,
                ItemID.MusicBoxSnow,
                ItemID.MusicBoxSpace,
                ItemID.MusicBoxTemple,
                ItemID.MusicBoxTheHallow,
                ItemID.MusicBoxTowers,
                ItemID.MusicBoxUnderground,
                ItemID.MusicBoxUndergroundCorruption,
                ItemID.MusicBoxUndergroundCrimson,
                ItemID.MusicBoxUndergroundHallow
            };

            foreach (int box in boxes)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MusicBoxPart>(), 1, box, 1);
                workingCategories = makeFurnitureCategories(musicBoxKeyword);
                workingCategories.AddRange(makeAccessoryCategories(musicBoxKeyword));
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
        }

    }
}
