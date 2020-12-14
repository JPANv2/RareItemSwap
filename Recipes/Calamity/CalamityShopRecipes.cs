using System;
using System.Collections.Generic;
using ARareItemSwapJPANs.Common;
using Terraria;
using Terraria.ID;

namespace ARareItemSwapJPANs.Recipes.Calamity
{
    public partial class CalamityModPartRepository : ModPartRepository
    {

        private void makeShopRecipes()
        {
            makeVanillaShopRecipes();
            makeSeaKingRecipes();
            makeBanditRecipes();
            makeArchmageRecipes();
            makeDrunkPrincessRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> ammo = new List<String>()
            {
                //"GodSlayerSlug",
                 "ExplosiveShells",
                "GrenadeRounds",
                "MagnumRounds"
            };

            foreach(string s in ammo)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + s, makeAmmoCategories(trueDamageKeyword, otherKeyword), ArmsDealerKeyword));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeDrunkPrincessRecipes()
        {

            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            string shopName = DrunkPrincess;
            List<string> drinks = new List<String>()
            {
                "GrapeBeer",
                "RedWine",
                "Whiskey",
                "Rum",
                "Tequila",
                "Fireball",
                "FabsolsVodka",
                "OddMushroom"
            };

            foreach(String itm in drinks)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + itm, new List<string>() { utilityKeyword + "/" + potionKeyword }, shopName, () => Main.hardMode));
            }

            drinks = new List<String>()
            {
                "Vodka",
                "Screwdriver",
                "WhiteWine"
            };

            foreach (String itm in drinks)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + itm, new List<string>() { utilityKeyword + "/" + potionKeyword }, shopName, () => Main.hardMode && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));
            }
            drinks = new List<String>()
            {
                "EvergreenGin",
                "CaribbeanRum",
                "Margarita",
                "Everclear",
                "BloodyMary",
                "StarBeamRye"
            };

            foreach (String itm in drinks)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + itm, new List<string>() { utilityKeyword + "/" + potionKeyword }, shopName, () => Main.hardMode && NPC.downedPlantBoss));
            }

            drinks = new List<String>()
            {
                "Moonshine",
                "MoscowMule",
                "CinnamonRoll",
                "TequilaSunrise"
            };

            foreach (String itm in drinks)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + itm, new List<string>() { utilityKeyword + "/" + potionKeyword }, shopName, () => Main.hardMode && NPC.downedGolemBoss));
            }

            drinks = new List<String>()
            {
                "BlueCandle",
                "PinkCandle",
                "PurpleCandle",
                "YellowCandle"
            };

            foreach (String itm in drinks)
            {
                recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + itm, makeFurnitureCategories(functionalStatueKeyword), shopName, () => Main.hardMode));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeArchmageRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            string shopName = Archmage;

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "ColdheartIcicle", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "FrostbiteBlaster", makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "IcicleTrident", makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "IceStar", makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "PermafrostsConcoction", makeAccessoryCategories(defenseKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "DeliciousMeat", new List<string>() { utilityKeyword + "/" + foodKeyword }, shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "EnchantedMetal", makeMaterialCategories(enemyDropsMaterialKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Popo", makeAccessoryCategories(buffsKeyword), shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "CryoKey", new List<string>() { utilityKeyword}, shopName, downedCryogen));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "ArcticBearPaw", makeWeaponsCategories(magicDamageKeyword, otherKeyword), shopName, ()=> downedCryogen() && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "CryogenicStaff", makeWeaponsCategories(summonerDamageKeyword,staffWeaponKeyword), shopName, () => downedCryogen() && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "FrostyFlare", makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword), shopName, () => downedCryogen() && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AbsoluteZero", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), shopName,()=> downedCryogen() && NPC.downedChristmasIceQueen && NPC.downedChristmasTree && NPC.downedChristmasSantank));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "EternalBlizzard", makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword), shopName, () => downedCryogen() && NPC.downedChristmasIceQueen && NPC.downedChristmasTree && NPC.downedChristmasSantank));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "WintersFury", makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword), shopName, () => downedCryogen() && NPC.downedChristmasIceQueen && NPC.downedChristmasTree && NPC.downedChristmasSantank));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "IcyBullet", makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), shopName, () => downedCryogen() && NPC.downedChristmasIceQueen && NPC.downedChristmasTree && NPC.downedChristmasSantank));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "IcicleArrow", makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), shopName, () => downedCryogen() && NPC.downedChristmasIceQueen && NPC.downedChristmasTree && NPC.downedChristmasSantank));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BloodRune", makeAmmoCategories(otherKeyword, magicDamageKeyword), shopName, downedCryogen));
           
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private bool downedCryogen()
        {
            return (bool)mod.Call(new object[] { "GetBossDowned", "cryogen" });
        }
        private void makeBanditRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            string shopName = Bandit;

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Cinquedea", makeWeaponsCategories(rougeKeyword, otherKeyword), shopName, ()=> NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Glaive", makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword), shopName, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Kylie", makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword), shopName, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "OldDie", makeAccessoryCategories(otherKeyword), shopName, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BearEye", makePetsCategories(normalPetsKeyword), shopName, () => NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GelDart", makeWeaponsCategories(rougeKeyword, thrownWeaponKeyword), shopName, () => NPC.downedBoss3 && (bool)mod.Call(new object[] { "GetBossDowned", "slimegod" })));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SlickCane", makeWeaponsCategories(rougeKeyword, otherKeyword), shopName, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "ThiefsDime", makeAccessoryCategories(debuffsKeyword), shopName, () => NPC.downedBoss3 && NPC.downedPirates));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BouncingBetty", makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword), shopName, () => NPC.downedBoss3 && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "LatcherMine", makeWeaponsCategories(rougeKeyword, explosiveWeaponKeyword), shopName, () => NPC.downedBoss3 && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "MomentumCapacitor", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "DeepWounder", makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword), shopName, () => NPC.downedBoss3 && (bool)mod.Call(new object[] { "GetBossDowned", "calamitas" })));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "MonkeyDarts", makeWeaponsCategories(rougeKeyword, otherKeyword), shopName, () => NPC.downedBoss3 && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GloveOfPrecision", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GloveOfRecklessness", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "EtherealExtorter", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && NPC.downedGolemBoss));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "CelestialReaper", makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword), shopName, () => NPC.downedBoss3&& NPC.downedMoonlord));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SylvanSlasher", makeWeaponsCategories(rougeKeyword, swordWeaponKeyword), shopName, () => NPC.downedBoss3 && (bool)mod.Call(new object[] { "GetBossDowned", "providence" })));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "VeneratedLocket", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && (bool)mod.Call(new object[] { "GetBossDowned", "devourerofgods" })));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "DragonScales", makeAccessoryCategories(offenseKeyword), shopName, () => NPC.downedBoss3 && (bool)mod.Call(new object[] { "GetBossDowned", "buffedeclipse" })));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSeaKingRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            string shopName = SeaKing;
            
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Shellshooter", makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SnapClam", makeWeaponsCategories(rougeKeyword, otherKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SandDollar", makeWeaponsCategories(rougeKeyword, boomerangWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "Waywasher", makeWeaponsCategories(magicDamageKeyword, bookWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "CoralCannon", makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "UrchinFlail", makeWeaponsCategories(meleeDamageKeyword, flailWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AmidiasTrident", makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword), shopName, downedClam));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "MagicalConch", makeWeaponsCategories(summonerDamageKeyword, otherKeyword), shopName, downedClam));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private bool downedClam()
        {
            return (bool)mod.Call(new object[] { "GetBossDowned", "giantclam" });
        }

        private void makeVanillaShopRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            /*Merchant*/
            recipes.AddRange(buildCommonShopRecipe(ItemID.ApprenticeBait, makeFishingCategories(baitKeyword), MerchantKeyword, ()=> NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe(ItemID.JourneymanBait, makeFishingCategories(baitKeyword), MerchantKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MasterBait, makeFishingCategories(baitKeyword), MerchantKeyword, () => NPC.downedPlantBoss));

            /*Dryad*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "RomajedaOrchid", makePetsCategories(normalPetsKeyword), DryadKeyword, () => NPC.downedBoss1));

            /*Stylist and dye trader (dyes)*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "StealthHairDye", new List<string>() { dyeKeyword }, StylistKeyword));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "WingTimeHairDye", new List<string>() { dyeKeyword }, StylistKeyword));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AdrenalineHairDye", new List<string>() { dyeKeyword }, StylistKeyword));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "RageHairDye", new List<string>() { dyeKeyword }, StylistKeyword));

            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "DefiledFlameDye", new List<string>() { dyeKeyword }, DyeTraderKeyword));

            /*Goblin*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "MeleeLevelMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, ()=> NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "RangedLevelMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "MagicLevelMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SummonLevelMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "RogueLevelMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "StatMeter", new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));

            /*witch doctor*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SunkenSeaFountain", makeFurnitureCategories(decorativeKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "SulphurousFountainItem", makeFurnitureCategories(decorativeKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AbyssFountainItem", makeFurnitureCategories(decorativeKeyword), WitchDoctorKeyword, ()=> NPC.downedQueenBee && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AstralFountainItem", makeFurnitureCategories(decorativeKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BulbofDoom",new List<string>() { utilityKeyword}, WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            //recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GypsyPowder", makeMaterialCategories(enemyDropsMaterialKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedGolemBoss));

            /*Clothier*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BlueBrickWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BlueSlabWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "BlueTiledWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GreenBrickWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GreenSlabWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "GreenTiledWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "PinkBrickWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "PinkSlabWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "PinkTiledWallUnsafe", makeMaterialCategories(blocksMaterialKeyword), ClothierKeyword, () => NPC.downedBoss3));

            /*wizard*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "HowlsHeart", makePetsCategories(normalPetsKeyword), WizardKeyword, () => Main.hardMode));

            /*steampunker*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "AstralSolution", new List<string>() { utilityKeyword }, SteampunkerKeyword, () => NPC.downedMechBossAny));

            /*Cyborg*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "LionHeart", makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), CyborgKeyword, () => (bool)mod.Call(new object[] { "GetBossDowned", "polterghast" })));

            /*Travelling merchant*/
            recipes.AddRange(buildCommonShopRecipe(modClassKeyword + ":" + "FrostBarrier", makeAccessoryCategories(defenseKeyword), TravelingMerchantKeyword));
            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
