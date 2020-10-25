using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Common.Globals;
using ARareItemSwapJPANs.Parts.Thorium.Biomes;
using ARareItemSwapJPANs.Parts.Thorium.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Biomes;
using ARareItemSwapJPANs.Parts.Vanilla.Bosses;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.Thorium
{
    public partial class ThoriumModPartRepository : ModPartRepository
    {
        private void makeBossRecipes()
        {
            makeGrandThunderBirdRecipes();
            makeQueenJellyfishRecipes();
            makeViscountRecipes();
            makeGraniteEnergyStormRecipes();
            makeBuriedChampionRecipes();
            makeStarScouterRecipes();
            makeBoreanStriderRecipes();
            makeCoznixRecipes();
            makeLichRecipes();
            makeAbyssionRecipes();
            makeRagnarokRecipes();

            addToVanillaBossRecipes();
        }

      

        private void makeGrandThunderBirdRecipes() {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ThunderBirdBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ThunderBirdTrophy"),  1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BirdMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientBirdMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Zephyr"), 1);
            workingCategories = makeAccessoryCategories(movementKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ThunderTalon"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TalonBurst"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Didgeridoo"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HatchlingStaff"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SandStone"), 3);
            workingCategories = makeMaterialCategories(barsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GrandThunderBirdPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StormFlare"), 1); 
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GrandThunderBirdKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeQueenJellyfishRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:JellyFishBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:QueenJellyfishTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:JellyfishHat"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SeaBreezePendant"), 1);
            workingCategories = makeAccessoryCategories(movementKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SparkingJellyBall"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GiantGlowstick"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BlunderBuss"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ConchShell"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:JellyPondWand"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 25, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:QueensGlowstick"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 1, ItemID.PinkGel, 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JellyfishQueenPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:JellyfishResonator"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, QueenJellyfishKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeViscountRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CountBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ViscountTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ViscountMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VampireCatalyst"), 1);
            workingCategories = new List<string>() { mountKeyword + "/"+ transformationKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BatWing"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BatScythe"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GuanoGunner"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SonarCannon"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VampireScepter"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ViscountCane"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DraculaFang"), 50);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BloodAltar"), 1);
            workingCategories = makeFurnitureCategories("");
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ViscountPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:UnholyShards"), 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ViscountKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGraniteEnergyStormRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GraniteBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EnergyStormTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EnergyMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EyeoftheStorm"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EnergyStormPartisan"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EnergyStormBolter"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EnergyProjector"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BoulderProbe"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ShockAbsorber"), 1);
            workingCategories = makeAccessoryCategories(bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GraniteEnergyStormPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:UnstableCore"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, GraniteEnergyStormKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBuriedChampionRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HeroBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionHelmet"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionWing"), 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionBlade"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HeroTripleBow"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionBomberStaff"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionsGodHand"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChampionsBarrier"), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BuriedChampionPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientBlade"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BuriedChampionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeStarScouterRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ScouterBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ScouterTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StarMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OmegaDrive"), 1);
            workingCategories = makePetsCategories(lightPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StarTrail"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HitScanner"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GaussSpark"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StarRod"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GaussKnife"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DistressCaller"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Roboboe"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<StarScouterPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StarCaller"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, StarScouterKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBoreanStriderRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BoreanBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BoreanTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TundraLordCrown"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:IceBoundStriderHide"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GlacierFang"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GlacialSting"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:FreezeRay"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:FrostFang"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CryoFang"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

        

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BoreanStriderPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StriderTear"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, BoreanStriderKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCoznixRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BeholderBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BeholderTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BeholderMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BeholderStaff"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ThermogenicImpaler"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Obliterator"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DemonFireBlastWand"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VoidPlanter"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DevilPauldron"), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 25, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CarKey"), 1);
            workingCategories = makeAccessoryCategories(otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EyeofBeholder"), 1);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<CoznixPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VoidLens"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, CoznixKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLichRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LichBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LichTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LichHood"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LichGaze"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SoulRender"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, scytheWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SoulCleaver"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CadaverCornet"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WitherStaff"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CryptWand"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SpiritBand"), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TheLostCross"), 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SoulBomb"), 50);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword);
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CursedCloth"), 5);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

           

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LichPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LichCatalyst"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, LichKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAbyssionRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbyssionBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbyssionTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbyssionMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbyssalShell"), 1);
            workingCategories = makeAccessoryCategories(defenseKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MantisPunch"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TrenchSpitter"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OldGodGrasp"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TheIncubator"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SirensAllure"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, stringInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WhisperingHood"), 1);
            workingCategories = makeArmorCategories(armorHeadKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WhisperingTabard"), 1);
            workingCategories = makeArmorCategories(armorBodyKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WhisperingLeggings"), 1);
            workingCategories = makeArmorCategories(armorLegsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 25, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:RlyehLostRod"), 1);
            workingCategories = makeFishingCategories(utilityKeyword);
            workingCategories.Add(utilityKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
           
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<AbyssionPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbyssalShadow2"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, AbyssionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeRagnarokRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 400, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:RagBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:RagTrophy"), 1);
            workingCategories = new List<string>() { TrophyKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AquaMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OmniMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SlagMask"), 1);
            workingCategories = new List<string>() { maskKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DormantHammer"), 1);
            workingCategories = makeWeaponsCategories(trueDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WarpCore"), 1);
            workingCategories = makeAccessoryCategories(movementKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 4000, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BowofLight"), 1);
            workingCategories = makeWeaponsCategories(trueDamageKeyword,bowWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:InfernoEssence"), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DeathEssence"), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OceanEssence"), 2);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RagnarokPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:RagSymbol"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, RagnarokKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void addToVanillaBossRecipes()
        {
            makeKingSlimeRecipes();
            //makeEoCRecipes();
            makeEoWRecipes();
            makeBoCRecipes();
            makeQueenBeeRecipes();
            makeSkeletronRecipes();
            makeWoFRecipes();

            /*makeTwinsRecipes();
            makeDestroyerRecipes();
            makeSkeletronPrimeRecipes();*/
            makeMechanicalBossesRecipes();
            makePlanteraRecipes();
            //makeGolemRecipes();
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
            RareEnemyPart rare = ModContent.GetModItem(ModContent.ItemType<RareEnemyPart>()) as RareEnemyPart;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:CoinBagCopper")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:CoinBagSilver")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:CoinBagGold")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:FlamekinCaster")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Globee")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:Illusionist")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:LifeCrystalMimic")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:RagingMinotaur")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:GildedBat")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:GildedLycan")] = rare;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:GildedSlime")] = rare;
            PartsGlobalNPC.npcParts[NPCID.WyvernHead] = rare;

            makeMimicRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CloudyChewToy"), 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            working.addPart(ModContent.ItemType<SkySurfacePart>(), 5);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LaunchJumper"), 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 8);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 15);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ProximityMine"), 20);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, explosiveWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 4, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MinotaurSkull"), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 20);
            workingCategories = makeAccessoryCategories(summonerDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ElephantGun"), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 20);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MageHand"), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 25);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ScryingGlass"), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 25);
            workingCategories = makeAccessoryCategories(summonerDamageKeyword);
            workingCategories.AddRange(makeAccessoryCategories(utilityKeyword)); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AnglerBulb"), 1);
            working.addPart(ModContent.ItemType<AquaticDepthsPart>(), 15);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MoltenScale"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 5);
            workingCategories = makeAccessoryCategories(defenseKeyword);
            workingCategories.AddRange(makeAccessoryCategories(debuffsKeyword)); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CorrodlingStaff"), 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 10);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:WeedEater"), 1);
            working.addPart(ModContent.ItemType<JungleUndergroundPart>(), 25);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TechniqueShadowClone"), 1);
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 20);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 20);
            workingCategories = new List<string>() { utilityKeyword + "/" + techniqueKeyword };  working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientDrachma"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 100);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, forestBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GlitteringHelmet"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 10);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
            PartRecipes.addRecipe(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GlitteringChestplate"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 10);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
            PartRecipes.addRecipe(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RareEnemyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GlitteringGreaves"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 10);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
            PartRecipes.addRecipe(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMimicRecipes()
        {
            MimicPart mimic = ModContent.GetModItem(ModContent.ItemType<MimicPart>()) as MimicPart;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:LihzardMimic")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:LihzardPotMimic1")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:LihzardPotMimic2")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:NecroPot")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:UnderworldPotMimic1")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:UnderworldPotMimic2")] = mimic;

            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:DesertBoulderMimic")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:IceBoulderMimic")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:JungleBoulderMimic")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:MoltenBoulderMimic")] = mimic;
            PartsGlobalNPC.npcParts[ARareItemSwapJPANs.getNPCTypeFromTag("ThoriumMod:RockBoulderMimic")] = mimic;


            List <PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 150, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ProofAvarice"), 1);
            workingCategories = makeArmorCategories(armorHeadKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LargeCoin"), 1);
            workingCategories = new List<string>() { mountKeyword + "/" + transformationKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:RejectsBlowpipe"), 1); 
            working.addPart(ModContent.ItemType<PostPlanteraPart>(), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Glacieor"), 1);
            working.addPart(ModContent.ItemType<IceUndergroundPart>(), 50);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AbsintheFury"), 1);
            working.addPart(ModContent.ItemType<JungleUndergroundPart>(), 50);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SurtrsSword"), 1);
            working.addPart(ModContent.ItemType<HellUndergroundPart>(), 50);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StoneSledge"), 1);
            working.addPart(ModContent.ItemType<ForestUndergroundPart>(), 50);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 30, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GhostlyGrapple"), 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 30);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HotPot"), 1);
            working.addPart(ModContent.ItemType<HellUndergroundPart>(), 20);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellBringerMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DevilsReach"), 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellBringerMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DevilDagger"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellBringerMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Scorn"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HellBringerMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Schmelze"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MyceliumMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:FungalHook"), 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MyceliumMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MyceliumWhip"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MyceliumMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Funggat"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MyceliumMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MushymenStaff"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SubmergedMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:NeptuneGrasp"), 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SubmergedMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:PoseidonCharge"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SubmergedMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SharkStormMK"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SubmergedMimicPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HydromancerCatalyst"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, aquaticDepthsBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeIceQueenRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Cryotherapy"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceQueenPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SoftServeSunderer"), 35);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, iceQueenKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSantaNK1Recipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SantaNK1Part>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:JingleBells"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, percursionInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, santaNK1Keyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEverscreamRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EverscreamPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ChristmasCheer"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, everscreamKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, frostMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePumpkingRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:FlyingBroom"), 1);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Witchblade"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SnackLantern"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PumpkingPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HauntingBassDrum"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, percursionInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, pumpkingKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMourningWoodRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 30, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CharonsBeacon"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 30, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:PaganGrasp"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MourningWoodPart>(), 30, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Effigy"), 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, mourningWoodKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pumpkinMoonKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMartianSaucerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LivewireCrasher"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CosmicDagger"), 1);
            workingCategories = makeWeaponsCategories(thrownWeaponKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SuperPlasmaCannon"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MoleculeStabilizer"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Kinetoscythe"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Triangle"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, percursionInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MartianSaucerPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Turntable"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, martianSaucerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, martianInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeGoblinSummonerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinSummonerPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ShadowTippedJavelin"), 10);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, goblinSummonerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoblinSummonerPart>(), 25, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SummonerWarhorn"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, goblinSummonerKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, goblinArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFlyingDutchmanRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 50, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GreedyMagnet"), 1);
            workingCategories = new List<string>() { utilityKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Tuba"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword,brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TheJuggernaut"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ShipsHelm"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HandCannon"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FlyingDutchmanPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CannonBall"), 20);
            working.irreversible = true;
            workingCategories = makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, flyingDutchmanKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, pirateInvasionKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBetsyRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BetsysBellow") , 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DragonFang"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DragonHeartWand"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ValhallasDescent"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BetsyPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MediumRareSteak"), 1);
            workingCategories = new List<string>() { mountKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, betsyKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeOgreRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OgreBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OgreSnotGun"), 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:OgreSandal"), 1);
            workingCategories = makeAccessoryCategories(movementBootsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GrogBlueprint"), 1);
            workingCategories = new List<string>() { otherKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Hippocraticrossbow"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, bowWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<OgrePart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SnotBall"), 30);
            working.irreversible = true;
            workingCategories = makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, ogreKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDarkMageRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkMageBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkTome"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TabooWand"), 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkMageStaff"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DarkMagePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ArcaneAnelace"), 1);
            workingCategories = makeWeaponsCategories(thrownWeaponKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, darkMageKeyword));
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, oldOnesArmyKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMoonLordRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AngelsEnd"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, spearWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LifeAndDeath"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MoonLordPart>(), 40, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SonicAmplifier"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, moonLordKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeLunaticCultistRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 200, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CultistBag"), 1);
            workingCategories = new List<string>() { TreasureBagKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 100, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientLight"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientSpark"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientFrost"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AncientFlame"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CelestialNova"), 1);
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AstralFang"), 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LunaticsHood"), 1);
            workingCategories = makeArmorCategories(armorHeadKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LunaticsRobe"), 1);
            workingCategories = makeArmorCategories(armorBodyKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<LunaticCultistPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LunaticsLeggings"), 1);
            workingCategories = makeArmorCategories(armorLegsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, cultistKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

        

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        private void makeDukeFishronRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DukesRegalCarnyx"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, brassInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DukeFishronPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Brinefang"), 1);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, dukeFishronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        private void makePlanteraRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VuvuzelaBlue"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword,windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VuvuzelaGreen"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VuvuzelaRed"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 5, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VuvuzelaYellow"), 1);
            workingCategories = makeWeaponsCategories(bardKeyword, windInstrumentKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BudBomb"), 40);
            working.irreversible = true;
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, explosiveWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VerdantOrnament"), 1);
            workingCategories = makeAccessoryCategories(HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BloomWeave"), 6);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PlanteraPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:PlantBulb"), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.irreversible = true;
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, planteraKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMechanicalBossesRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:LifeCell"), 1);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPrimePart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StrangePlating"), 4);
            workingCategories = makeMaterialCategories(enemyDropsMaterialKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronPrimeKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, twinsKeyword));
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, destroyerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
      

        private void makeWoFRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ClericEmblem"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, HealerKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BardEmblem"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, bardKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<WallOfFleshPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:NinjaEmblem"), 1);
            workingCategories = makeAccessoryCategories(offenseKeyword, throwingDamageKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, wofKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSkeletronRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<SkeletronPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:GuildsStaff"), 1);
            workingCategories = makePetsCategories(normalPetsKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, skeletronKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeQueenBeeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
             
            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<QueenBeePart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:SweetHeart"), 1);
            workingCategories = makeAccessoryCategories(HealerKeyword, lifeKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, queenBeeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBoCRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<BrainOfCthulhuPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TheStalker"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, staffWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeEoWRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<EaterOfWorldsPart>(), 20, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:EaterOfPain"), 1);
            workingCategories = makeWeaponsCategories(HealerKeyword, flailWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, bocKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);
            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeKingSlimeRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 10, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:TechniqueHiddenBlade"), 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + techniqueKeyword }; working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<KingSlimePart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ShinobiSlicer"), 40);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword); working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBossCategories(workingCategories, KingSlimeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        
    }
}
