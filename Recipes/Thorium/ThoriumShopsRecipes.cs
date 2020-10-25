using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts.Thorium;
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

namespace ARareItemSwapJPANs.Recipes.Thorium
{
    public partial class ThoriumModPartRepository : ModPartRepository
    {
        private void makeShopRecipes()
        {
            makeBlacksmithRecipes();
            makeCobblerRecipes();
            makeConfusedZombieRecipes();
            makeCookRecipes();
            makeDesertAcolyteRecipes();
            makeDiverRecipes();
            makeDruidRecipes();
            makeSpiritualistRecipes();
            makeWeaponMasterRecipes();

            makeTrackerRecipes();

            makeVanillaShopRecipes();
        }

        

        private void makeBlacksmithRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlackHammer", makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlacksmithApron", makeVanityCategories(armorBodyKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ArcaneArmorFabricator", makeFurnitureCategories(stationKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlacksmithsBarrier", makeAccessoryCategories(defenseKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WarForger", makeWeaponsCategories(HealerKeyword, hammerWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelPickaxe", makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelAxe", makeWeaponsCategories(meleeDamageKeyword, axeWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelMallet", makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelBlade", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelBow", makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelArrow", makeAmmoCategories(bowWeaponKeyword,rangedDamageKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelBattleAxe", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelHelmet", makeArmorCategories(armorHeadKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelChestplate", makeArmorCategories(armorBodyKeyword), BlacksmithKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelGreaves", makeArmorCategories(armorLegsKeyword), BlacksmithKeyword, () => NPC.downedBoss1));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SuperAnvil", new List<string>() { mountKeyword }, BlacksmithKeyword, () => NPC.downedBoss1 && NPC.downedQueenBee));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelDrill", makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelChainsaw", makeWeaponsCategories(meleeDamageKeyword, axeWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelJackhammer", makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelBlade", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelRepeater", makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelArrow", makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelJavelin", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelHelmet", makeArmorCategories(armorHeadKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelChestplate", makeArmorCategories(armorBodyKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DurasteelGreaves", makeArmorCategories(armorLegsKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ImpactDrill", makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword), BlacksmithKeyword, () => NPC.downedBoss1 && NPC.downedPlantBoss));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCobblerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Boots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteelToedBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HoverBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TurboBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HealthyBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WizardShoes", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MarchingBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SlowFallBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.Aglet, makeAccessoryCategories(movementKeyword), CobblerKeyword, () => NPC.downedBoss2));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CrashBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SlagStompers", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.HermesBoots, makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () => NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BeeBoots", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () => NPC.downedQueenBee));

            recipes.AddRange(buildCommonShopRecipe(ItemID.WaterWalkingBoots, makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedJelly = (bool)world.GetField("downedJelly", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedJelly;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SpartanSandles", makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedJelly = (bool)world.GetField("downedChampion", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedJelly;
            }));

            recipes.AddRange(buildCommonShopRecipe(ItemID.IceSkates, makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedStrider = (bool)world.GetField("downedStrider", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedStrider;
            }));

            recipes.AddRange(buildCommonShopRecipe(ItemID.LavaWaders, makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated;
            }));

            recipes.AddRange(buildCommonShopRecipe(ItemID.FlowerBoots, makeAccessoryCategories(movementKeyword, movementBootsKeyword), CobblerKeyword, () => NPC.downedPlantBoss));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeConfusedZombieRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Vertebrae, makeMaterialCategories(enemyDropsMaterialKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RottenChunk, makeMaterialCategories(enemyDropsMaterialKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Lens, makeMaterialCategories(enemyDropsMaterialKeyword), ConfusedZombieKeyword, () => downedPatchwerk() && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Bone, makeMaterialCategories(enemyDropsMaterialKeyword), ConfusedZombieKeyword, () => downedPatchwerk() && NPC.downedMechBossAny));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SoulLink", makeWeaponsCategories(transformationKeyword, transformationKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GrimPointer", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RustySword", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BentZombieArm", makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GraveBuster", makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GoodBook", makeWeaponsCategories(HealerKeyword, bookWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LeechBolt", makeWeaponsCategories(HealerKeyword, bookWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ViciousMockery", makeWeaponsCategories(HealerKeyword, bookWeaponKeyword), ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:NecromancersHeart", makeAccessoryCategories(HealerKeyword), ConfusedZombieKeyword, downedPatchwerk));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DraculaFang", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), ConfusedZombieKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedBat = (bool)world.GetField("downedBat", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedBat && downedPatchwerk();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SacrificialDagger", makeWeaponsCategories(summonerDamageKeyword, swordWeaponKeyword), ConfusedZombieKeyword, () => downedPatchwerk() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GrimFlayer", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), ConfusedZombieKeyword, () => downedPatchwerk() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SuspiciousLookingEye, new List<string>() { utilityKeyword }, ConfusedZombieKeyword, () => downedPatchwerk() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WormFood, new List<string>() { utilityKeyword }, ConfusedZombieKeyword, () => downedPatchwerk() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BloodySpine, new List<string>() { utilityKeyword }, ConfusedZombieKeyword, () => downedPatchwerk() && Main.hardMode));
            
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DeathMirror", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedPatchwerk();
            }));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:VoidHeart", makeMaterialCategories(otherKeyword), ConfusedZombieKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedPatchwerk();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SnotBall", makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), ConfusedZombieKeyword, () => downedPatchwerk() && DD2Event.DownedInvasionT2));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SoulBomb", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), ConfusedZombieKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedLich = (bool)world.GetField("downedLich", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedLich && downedPatchwerk();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BatRepellent", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BugRepellent", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:FishRepellent", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SkeletonRepellent", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ZombieRepellent", new List<string>() { utilityKeyword }, ConfusedZombieKeyword, downedPatchwerk));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedPatchwerk()
        {
                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                return (bool)world.GetField("downedPatchwerk", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
        }

        private void makeCookRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories = new List<string>() { foodKeyword };

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ApplePie", workingCategories, CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SliceofCake", workingCategories, CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:IceCream", workingCategories, CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Hamburger", workingCategories, CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CarrotSalad", workingCategories, CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CalciumShake", workingCategories, CookKeyword));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ChefHat", makeVanityCategories(armorHeadKeyword), CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CooksApron", makeVanityCategories(armorBodyKeyword), CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:AromaticBiscuit", makePetsCategories(normalPetsKeyword), CookKeyword));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:FreshPickle", makePetsCategories(normalPetsKeyword), CookKeyword));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Fork", makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword), CookKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Spoon", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), CookKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Knife", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), CookKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SpudBomber", makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword), CookKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Spud", makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), CookKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PotionChaser", makeAccessoryCategories(lifeKeyword), CookKeyword, () => NPC.downedBoss1));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LargePopcorn", makeWeaponsCategories(HealerKeyword, foodKeyword), CookKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:JarOMayo", makeWeaponsCategories(bardKeyword, percursionInstrumentKeyword), CookKeyword, () => NPC.downedBoss2));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:FlanPlatter", makeWeaponsCategories(HealerKeyword, foodKeyword), CookKeyword, () => Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:FruitSalad", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook1", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SauteedShroom", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook2", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PricklyJam", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook3", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MistakeStew", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook4", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 8;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:QuestionableRack", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook5", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 8;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MeanGreenStew", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook6", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SeaSpaghetti", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook7", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SunnyLemonade", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook8", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SkyBloomCocktail", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook9", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BloodRootGoop", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook10", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GlowingSouffle", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook11", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 10;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LifeFruitPlatter", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook12", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 3;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ManaDelight", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook13", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 10;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe(3532, workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook14", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >=1;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:EtherianGrog", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook15", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 1;
                return foodDone;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ChiTea", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook16", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 10;
                return foodDone;
            }));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HotChocolate", workingCategories, CookKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool foodDone = (int)world.GetField("cook17", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null) >= 10;
                return foodDone;
            }));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        private void makeDesertAcolyteRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WindGust", makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword), DesertAcolyteKeyword, downedThunderBird));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:EighthPlagueStaff", makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword), DesertAcolyteKeyword, downedThunderBird));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Scorpain", makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), DesertAcolyteKeyword, downedThunderBird));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CactusFruit", new List<string>() { potionKeyword }, DesertAcolyteKeyword, downedThunderBird));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PotentExtract", new List<string>() { potionKeyword }, DesertAcolyteKeyword, downedThunderBird));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ThiefsWallet", makeAccessoryCategories(throwingDamageKeyword), DesertAcolyteKeyword, downedThunderBird));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PaddedGrip", makeAccessoryCategories(throwingDamageKeyword), DesertAcolyteKeyword, downedThunderBird));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TechniqueBlankScroll", makeMaterialCategories(techniqueKeyword), DesertAcolyteKeyword, downedThunderBird));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ThrowingGuide", makeAccessoryCategories(throwingDamageKeyword), DesertAcolyteKeyword,() => downedThunderBird() && NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:NightShadePetal", makeAccessoryCategories(debuffsKeyword), DesertAcolyteKeyword, () => downedThunderBird() && NPC.downedBoss1));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Canteen", makeAccessoryCategories(throwingDamageKeyword), DesertAcolyteKeyword, () => downedThunderBird() && NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:NinjaRack", makeFurnitureCategories(stationKeyword), DesertAcolyteKeyword, () => downedThunderBird() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SandweaversTiara", makeAccessoryCategories(offenseKeyword), DesertAcolyteKeyword, () => downedThunderBird() && Main.hardMode));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedThunderBird()
        {
            Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
            return (bool)world.GetField("downedThunderBird", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
        }

        private void makeDiverRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ThoriumCube", makeVanityCategories(armorKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Coral, makeMaterialCategories(enemyDropsMaterialKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SharkFin, makeMaterialCategories(enemyDropsMaterialKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:JellyFishIdol", makeFurnitureCategories(decorativeKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MarineCatcher", new List<string>() { utilityKeyword + "/" + fishingKeyword }, DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CrabClaw", new List<string>() { mountKeyword }, DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DiverSuit", makeArmorCategories(armorBodyKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DiverLeggings", makeArmorCategories(armorLegsKeyword), DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:EmergencyAirTank", new List<string>() { utilityKeyword }, DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:EmergencyAirTankEmpty", new List<string>() { utilityKeyword }, DivermanKeyword, downedQueenJelly));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Chum", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword ), DivermanKeyword, downedQueenJelly));
       
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WhirlpoolSaber", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), DivermanKeyword, () => downedQueenJelly() && NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Eelrod", makeWeaponsCategories(magicDamageKeyword,staffWeaponKeyword), DivermanKeyword, () => downedQueenJelly() && NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MarineLauncher", makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword), DivermanKeyword, () => downedQueenJelly() && NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LilTorpedo", makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), DivermanKeyword, () => downedQueenJelly() && NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LilTorpedo", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), DivermanKeyword, () => downedQueenJelly() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SeaMine", makeWeaponsCategories(meleeDamageKeyword,flailWeaponKeyword), DivermanKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedQueenJelly();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WhirlPool", makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), DivermanKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedDepthBoss = (bool)world.GetField("downedDepthBoss", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedDepthBoss && downedQueenJelly();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HydroPump", makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), DivermanKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool downedDepthBoss = (bool)world.GetField("downedDepthBoss", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return downedDepthBoss && downedQueenJelly();
            }));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedQueenJelly()
        {
            Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
            return (bool)world.GetField("downedJelly", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
        }

        private void makeDruidRecipes()
        {
           
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            for(int i = 307; i <= 312; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeMaterialCategories(plantsMaterialKeyword), DruidKeyword, downedCorpseBloom));
            }
            recipes.AddRange(buildCommonShopRecipe(ItemID.ShiverthornSeeds, makeMaterialCategories(plantsMaterialKeyword), DruidKeyword, downedCorpseBloom));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MarineKelpSeeds", makeMaterialCategories(plantsMaterialKeyword), DruidKeyword, downedCorpseBloom));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Fertilizer", makeMaterialCategories(plantsMaterialKeyword), DruidKeyword, downedCorpseBloom));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RangersCowl", makeVanityCategories(armorHeadKeyword), DruidKeyword, downedCorpseBloom));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BloomGuard", makeWeaponsCategories(HealerKeyword,staffWeaponKeyword), DruidKeyword, downedCorpseBloom));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LifeDisperser", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), DruidKeyword, downedCorpseBloom));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HexWand", makeWeaponsCategories(trueDamageKeyword, staffWeaponKeyword), DruidKeyword, () => downedCorpseBloom() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MagicJungleBag", new List<string>() { utilityKeyword }, DruidKeyword, () => downedCorpseBloom() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MushroomBag", new List<string>() { utilityKeyword }, DruidKeyword, () => downedCorpseBloom() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MarshyAstroturf", makeMaterialCategories(blocksMaterialKeyword), DruidKeyword, () => downedCorpseBloom() && NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CherryAstroturf", makeMaterialCategories(blocksMaterialKeyword), DruidKeyword, () => downedCorpseBloom() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SpookyAstroturf", makeMaterialCategories(blocksMaterialKeyword), DruidKeyword, () => downedCorpseBloom() && NPC.downedPlantBoss));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BudBomb", makeWeaponsCategories(throwingDamageKeyword, explosiveWeaponKeyword), DruidKeyword, () => downedCorpseBloom() && NPC.downedPlantBoss));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedCorpseBloom()
        {
            Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
            return (bool)world.GetField("downedBloom", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
        }

        private void makeSpiritualistRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LesserLifeWater", new List<string>() { potionKeyword } , SpiritualistKeyword, downedChampion));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LifeWater", new List<string>() { potionKeyword }, SpiritualistKeyword, () => downedChampion() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Guaze", makeWeaponsCategories(HealerKeyword, thrownWeaponKeyword), SpiritualistKeyword, downedChampion));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Syringe", makeWeaponsCategories(HealerKeyword, thrownWeaponKeyword), SpiritualistKeyword, downedChampion));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Altar", makeFurnitureCategories(stationKeyword), SpiritualistKeyword, downedChampion));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SentinelWand", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, downedChampion));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RedeemerStaff", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, downedChampion));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RichLeaf", makePetsCategories(lightPetsKeyword), SpiritualistKeyword, downedChampion));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TranquilLyre", makeWeaponsCategories(HealerKeyword, stringInstrumentKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HealingRain", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RebirthStatuette", makeAccessoryCategories(HealerKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WarlockHood", makeArmorCategories(armorHeadKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WarlockGarb", makeArmorCategories(armorBodyKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WarlockLeggings", makeArmorCategories(armorLegsKeyword), SpiritualistKeyword, () => downedChampion() && Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Recuperate", makeWeaponsCategories(HealerKeyword, bookWeaponKeyword), SpiritualistKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedChampion();
            }));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:AngelStaff", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword,() =>
                {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedChampion();
            }));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CrossNecklace, makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, () => 
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedChampion();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DevilStaff", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated && downedChampion();
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LifePulseStaff", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, () => downedChampion() && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:HerdingStaff", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), SpiritualistKeyword, () => downedChampion() && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:AscensionStatuette", makeAccessoryCategories(HealerKeyword), SpiritualistKeyword, () => downedChampion() && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SpiritArrow", makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), SpiritualistKeyword, () => downedChampion() && NPC.downedMechBossAny));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedChampion()
        {
            Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
            return (bool)world.GetField("downedChampion", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
        }

        private void makeWeaponMasterRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ExileHelmet", makeVanityCategories(armorHeadKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ExileBelt", makeVanityCategories(armorBodyKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Kunai", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:KineticKnife", makeWeaponsCategories(magicDamageKeyword, otherKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ArmorBane", makeWeaponsCategories(rangedDamageKeyword,gunWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BulletStorm", makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ThiefDagger", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WarpSlicer", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Scalper", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Executioner", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RapierBadge", makeAccessoryCategories(offenseKeyword), WeaponMasterKeyword, downedCoznix)); 
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Rapier", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, downedCoznix));


            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlastShield", makeAccessoryCategories(defenseKeyword), WeaponMasterKeyword, () => downedCoznix() && NPC.downedGolemBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GutWrenchersGauntlet", makeAccessoryCategories(offenseKeyword), WeaponMasterKeyword, () => downedCoznix() && NPC.downedGolemBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WyvernSlayer", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), WeaponMasterKeyword, () => downedCoznix() && NPC.downedGolemBoss));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlueKnightHelmet", makeVanityCategories(armorHeadKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlueKnightArmor", makeVanityCategories(armorBodyKeyword), WeaponMasterKeyword, downedCoznix));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BlueKnightGreaves", makeVanityCategories(armorLegsKeyword), WeaponMasterKeyword, downedCoznix));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedCoznix()
        {
            Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
            bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
            return coznixDefeated;
        }

        private void makeVanillaShopRecipes()
        {
            makeMerchantRecipes();
            makeDryadRecipes();
            makeStylistRecipes();
            makeArmsDealerRecipes();
            makeGoblinTinkererRecipes();
            makeWitchDoctorRecipes();
            makeClothierRecipes();
            makeMechanicRecipes();
            makePartyGirlRecipes();

            makeWizardRecipes();
            makeSteampunkerRecipes();
            makePirateRecipes();
            makeCyborgRecipes();
            

            makeTravelingMerchantRecipes();
            makeSkeletonMerchantRecipes();

        }

        private void makeSkeletonMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Trapper", makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword), SkeletonMerchantKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeTravelingMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ChiLantern", makeWeaponsCategories(HealerKeyword, staffWeaponKeyword), TravelingMerchantKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DivineLotus", makeWeaponsCategories(HealerKeyword, otherKeyword), TravelingMerchantKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SamsaraLotus", makeWeaponsCategories(HealerKeyword, otherKeyword), TravelingMerchantKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DivineLotus", makeWeaponsCategories(HealerKeyword, otherKeyword), TravelingMerchantKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TechniqueSmokeBomb", new List<string>() { utilityKeyword + "/" + techniqueKeyword }, TravelingMerchantKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:RocketCartItem", new List<string>() { utilityKeyword + "/" + minecartKeyword }, TravelingMerchantKeyword, () => NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));
            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        

        private void makeCyborgRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:AlienSphere", new List<string>() { mountKeyword + "/" + transformationKeyword }, CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PhaseLauncher", makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:KillCounter", makeWeaponsCategories(rangedDamageKeyword, launcherWeaponKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:PLG", makeWeaponsCategories(magicDamageKeyword, launcherWeaponKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:LethalInjection", makeWeaponsCategories(HealerKeyword, gunWeaponKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TheBopper", makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:TheNuclearOption", makeAccessoryCategories(offenseKeyword, buffsKeyword), CyborgKeyword, () => NPC.downedPlantBoss));

            List<string> sets = new List<string>()
            {
                "ThoriumMod:ProtogenMask",
                "ThoriumMod:ProtogenSuit",
                "ThoriumMod:ProtogenLeggings",
                "ThoriumMod:CephalopodHelmet",
                "ThoriumMod:CephalopodSuit",
                "ThoriumMod:CephalopodLeggings"
            };

            for (int i = 0; i < sets.Count; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(sets[i], makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
                i++;
                recipes.AddRange(buildCommonShopRecipe(sets[i], makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
                i++;
                recipes.AddRange(buildCommonShopRecipe(sets[i], makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
           
        }

        private void makePirateRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CannonBall", makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MidasMallet", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:CaptainsPoniard", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), PirateKeyword, () => NPC.downedPirates));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
           
        }

        private void makeSteampunkerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Battery", makeAmmoCategories(rangedDamageKeyword, otherKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Teslanator", makeWeaponsCategories(rangedDamageKeyword, otherKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:SteamgunnerController", makeWeaponsCategories(summonerDamageKeyword, otherKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:AutoTuner", makeAccessoryCategories(bardKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWizardRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ScholarsHarp", makeWeaponsCategories(bardKeyword, stringInstrumentKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:GemBottle", makeFurnitureCategories(decorativeKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:DecorativePotion", makeFurnitureCategories(decorativeKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:StrangeDecorativePotion", makeFurnitureCategories(decorativeKeyword), WizardKeyword, () => Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:FragmentedRune", makePetsCategories(normalPetsKeyword), WizardKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated;
            }));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePartyGirlRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:ConcertTickets", makeAccessoryCategories(bardKeyword), PartyGirlKeyword));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:BenignBalloon", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), PartyGirlKeyword, () => Main.hardMode));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Kazoo", makeWeaponsCategories(bardKeyword,windInstrumentKeyword ), PartyGirlKeyword, () =>
            {

                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool coznixDefeated = (bool)world.GetField("downedFallenBeholder", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).GetValue(null);
                return coznixDefeated;
            }));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MagicCard", makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword), PartyGirlKeyword, () => NPC.downedMechBoss1 && NPC.downedMechBoss2&& NPC.downedMechBoss3));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMechanicRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Subwoofer", makeAccessoryCategories(bardKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Microphone", makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword), MechanicKeyword, () => NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:WackWrench", makeWeaponsCategories(throwingDamageKeyword,thrownWeaponKeyword), MechanicKeyword, () => NPC.downedBoss3));
            

            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:MusicPlayerNotActivated", makeAccessoryCategories(bardKeyword), MechanicKeyword, () =>
            {
                
                Type world = mod.GetType().Assembly.GetType("ThoriumMod.ThoriumWorld");
                bool starCallerDefeated = (bool) world.GetField("downedScout", System.Reflection.BindingFlags.Static| System.Reflection.BindingFlags.Public).GetValue(null);
                return NPC.downedBoss3 && starCallerDefeated;
            }));
            recipes.AddRange(buildCommonShopRecipe("ThoriumMod:Headset", makeAccessoryCategories(bardKeyword), MechanicKeyword, () => NPC.downedBoss3 && Main.hardMode));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeClothierRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<string> sets = new List<string>()
            {
                "ThoriumMod:UselessWig",
                "ThoriumMod:UselessVest",
                "ThoriumMod:UselessBoots",
                "ThoriumMod:ExplosionCap",
                "ThoriumMod:ExplosionCloak",
                "ThoriumMod:ExplosionBooties",
                "ThoriumMod:ProtectorsWig",
                "ThoriumMod:ProtectorsVest",
                "ThoriumMod:ProtectorsBoots",
                "ThoriumMod:FeralSkinHead",
                "ThoriumMod:FeralSkinChest",
                "ThoriumMod:FeralSkinLegs"
            };

            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HokeMask"), makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:HokeGarb"), makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));

            for(int i = 0; i < sets.Count; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag(sets[i]), makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
                i++;
                recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag(sets[i]), makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
                i++;
                recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag(sets[i]), makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            }
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkNexusMask"), makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.eclipse));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkNexusRobe"), makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.eclipse));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DarkNexusLeggings"), makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.eclipse));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWitchDoctorRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MantisCane"), makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DartPouch"), makeAccessoryCategories(rangedDamageKeyword,dartsWeaponKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGoblinTinkererRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            workingCategories = makeAccessoryCategories(bardKeyword);
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:CorkGrease"), workingCategories, GoblinThinkererKeyword, () => NPC.downedGoblins));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeStylistRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:DaawnsWig"), makeVanityCategories(armorHeadKeyword), StylistKeyword));
            workingCategories = makeVanityCategories(armorHeadKeyword);
            workingCategories.Add(dyeKeyword);
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:InspirationHairDye"),workingCategories, StylistKeyword));


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }


        private void makeArmsDealerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StealthBandanna"), makeVanityCategories(armorHeadKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StealthShirt"), makeVanityCategories(armorBodyKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:StealthPants"), makeVanityCategories(armorLegsKeyword), ArmsDealerKeyword));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDryadRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(blocksMaterialKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MarineKelpPlanterBox"), workingCategories, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:AmphibianEgg"), new List<string>() { mountKeyword + "/" + transformationKeyword }, DryadKeyword));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makeMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            workingCategories = makeAmmoCategories(thrownWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(thrownWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:Baseball"), workingCategories, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:BaseballBat"), makeWeaponsCategories(throwingDamageKeyword, otherKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ConductorsStand"), makeFurnitureCategories(stationKeyword), MerchantKeyword,() => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:YarnBall"), makeWeaponsCategories(summonerDamageKeyword, otherKeyword), MerchantKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:ConductorsBaton"), makeAccessoryCategories(bardKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:MusiciansHandbook"), makeAccessoryCategories(bardKeyword, utilityKeyword), MerchantKeyword, () => Main.hardMode));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        //not accurate until I figure out how to check contracts
        private void makeTrackerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:TrackerBoard", 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 2, "ThoriumMod:TrackerBlade", 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 2, "ThoriumMod:ShinyObject", 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 3, "ThoriumMod:RosySlimeStaff", 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:GrimPedestal", 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:GrimPedestalCrimson", 1);
            workingCategories = makeFurnitureCategories(stationKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 3, "ThoriumMod:MalignantThread", 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:Whip", 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 10, "ThoriumMod:TheseusThread", 1);
            working.available = () => NPC.downedBoss3;
            workingCategories = new List<string> { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:HagTotemCaller", 1);
            working.available = () => NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 2, "ThoriumMod:MimicKey", 1);
            working.available = () => Main.hardMode;
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 5, "ThoriumMod:BaconRecipe", 1);
            working.available = () => Main.hardMode;
            workingCategories = new List<string> { otherKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 6, "ThoriumMod:CursedHammer", 1);
            working.available = () => Main.hardMode;
            workingCategories = makeWeaponsCategories(magicDamageKeyword, hammerWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 10, "ThoriumMod:Chrysalis", 1);
            working.available = () => Main.hardMode;
            workingCategories = makeAccessoryCategories(defenseKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 10, "ThoriumMod:JonesLockBox", 1);
            working.available = () => Main.hardMode && NPC.downedPirates;
            workingCategories = makePetsCategories(lightPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 8, "ThoriumMod:DridersGrace", 1);
            working.available = () => Main.hardMode;
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 8, "ThoriumMod:SandBag", 1);
            working.available = () => Main.hardMode;
            workingCategories = new List<string> { utilityKeyword }; 
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 8, "ThoriumMod:IcyGaze", 1);
            working.available = () => Main.hardMode;
            workingCategories = makeWeaponsCategories(trueDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 12, "ThoriumMod:WormHoleMirror", 1);
            working.available = () => Main.hardMode;
            workingCategories = new List<string> { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 15, "ThoriumMod:Nimbus", 1);
            working.available = () => Main.hardMode;
            workingCategories = new List<string> { mountKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 15, "ThoriumMod:GodKiller", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3;
            workingCategories = makeWeaponsCategories(magicDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackStaff", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackBlade", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackBow", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackCane", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackDagger", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackScythe", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(HealerKeyword, scytheWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<VanquisherPart>(), 25, "ThoriumMod:BlackOtamatone", 1);
            working.available = () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3 && NPC.downedPlantBoss && NPC.downedPirates && NPC.downedBoss3 && NPC.downedBoss2;
            workingCategories = makeWeaponsCategories(bardKeyword, electronicInstrumentKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TrackerKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }
    }
}
