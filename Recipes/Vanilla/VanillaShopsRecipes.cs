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
        private void makeShopRecipes()
        {
            makeAmmoRecipes();

            makeMerchantRecipes();
            makeDyeTraderRecipes();
            makeDryadRecipes();
            makeArmsDealerRecipes();
            makePainterRecipes();
            makeGoblinTinkererRecipes();
            makeWitchDoctorRecipes();
            makeClothierRecipes();
            makeMechanicRecipes();
            makePartyGirlRecipes();

            makeWizardRecipes();
            makeTruffleRecipes();
            makeSteampunkerRecipes();
            makePirateRecipes();
            makeCyborgRecipes();
            makeSantaRecipes();

            makeTravelingMerchantRecipes();
            makeSkeletonMerchantRecipes();

            makeTavernkeepRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.ExplosivePowder, makeMaterialCategories(otherKeyword), DemolitionistKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.StylistKilLaKillScissorsIWish, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), StylistKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSkeletonMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            recipes.AddRange(buildCommonShopRecipe(ItemID.StrangeBrew, new List<string>() { potionKeyword}, SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LesserHealingPotion, new List<string>() { potionKeyword }, SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SpelunkerGlowstick, new List<string>() { utilityKeyword + "/" + lightSourceKeyword}, SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Glowstick, new List<string>() { utilityKeyword + "/" + lightSourceKeyword }, SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BoneTorch, makeFurnitureCategories(lightSourceKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Torch, makeFurnitureCategories(lightSourceKeyword), SkeletonMerchantKeyword));


            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PurpleCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Rope, new List<string>() { utilityKeyword }, SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Gradient, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), SkeletonMerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FormatC, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), SkeletonMerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.YoYoGlove, makeAccessoryCategories(yoyoWeaponKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SlapHand, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), SkeletonMerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MagicLantern, makePetsCategories(lightPetsKeyword), SkeletonMerchantKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeTravelingMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Stopwatch, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LifeformAnalyzer, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DPSMeter, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockRed, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockRedPlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockBlue, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockBluePlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockGreen, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockGreenPlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockYellow, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockYellowPlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockWhite, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockWhitePlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockPink, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TeamBlockPinkPlatform, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            
            recipes.AddRange(buildCommonShopRecipe(ItemID.DynastyWood, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueDynastyShingles, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedDynastyShingles, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.FancyDishes, makeFurnitureCategories(decorativeKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkCup, makeFurnitureCategories(stationKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.ZebraSkin, makeFurnitureCategories(decorativeKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TigerSkin, makeFurnitureCategories(decorativeKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LeopardSkin, makeFurnitureCategories(decorativeKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.Pho, new List<string>() { foodKeyword }, TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PadThai, new List<string>() { foodKeyword }, TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Sake, new List<string>() { potionKeyword }, TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.UltrabrightTorch, makeFurnitureCategories(lightSourceKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Katana, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ActuationAccessory, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PortableCementMixer, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PaintSprayer, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ExtendoGrip, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BrickLayer, makeAccessoryCategories(utilityKeyword), TravelingMerchantKeyword));


            recipes.AddRange(buildCommonShopRecipe(ItemID.Code1, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), TravelingMerchantKeyword, () =>  NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Code2, makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword), TravelingMerchantKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Gi, makeArmorCategories(armorBodyKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GypsyRobe, makeArmorCategories(armorBodyKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MagicHat, makeArmorCategories(armorHeadKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Fez, makeVanityCategories(armorHeadKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.AmmoBox, makeFurnitureCategories(stationKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Revolver, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.CompanionCube, makePetsCategories(normalPetsKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SittingDucksFishingRod, makeFishingCategories(utilityKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedCape, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WinterCape, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MysteriousCape, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CrimsonCloak, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DiamondRing, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CelestialMagnet, makeAccessoryCategories(manaKeyword), TravelingMerchantKeyword));
            workingCategories = new List<string>() { utilityKeyword + "/" + gunWeaponKeyword };
            workingCategories.AddRange(makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WaterGun,workingCategories , TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PulseBow, makeWeaponsCategories(rangedDamageKeyword, bowWeaponKeyword), TravelingMerchantKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.YellowCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.ArcaneRuneWall, makeMaterialCategories(blocksMaterialKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Kimono, makeVanityCategories(armorBodyKeyword), TravelingMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Gatligator, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), TravelingMerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlackCounterweight, makeAccessoryCategories(yoyoWeaponKeyword), TravelingMerchantKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.AngelHalo, makeVanityCategories(accessoryKeyword), TravelingMerchantKeyword));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeSantaRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.SantaHat, makeVanityCategories(armorHeadKeyword), SantaKeyword, () => NPC.downedFrost && (!ModContent.GetInstance<Config>().forceSeasonal || Main.xMas)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SantaShirt, makeVanityCategories(armorBodyKeyword), SantaKeyword, () => NPC.downedFrost && (!ModContent.GetInstance<Config>().forceSeasonal || Main.xMas)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SantaPants, makeVanityCategories(armorLegsKeyword), SantaKeyword, () => NPC.downedFrost && (!ModContent.GetInstance<Config>().forceSeasonal || Main.xMas)));

            recipes.AddRange(buildCommonShopRecipe(ItemID.ChristmasTree, makeFurnitureCategories(decorativeKeyword), SantaKeyword, () => NPC.downedFrost && (!ModContent.GetInstance<Config>().forceSeasonal || Main.xMas)));
            for (int i = ItemID.StarTopper1; i <= ItemID.BlueAndYellowLights; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeFurnitureCategories(lightSourceKeyword), SantaKeyword, () => NPC.downedFrost && (!ModContent.GetInstance<Config>().forceSeasonal || Main.xMas)));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCyborgRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.ProximityMineLauncher, makeWeaponsCategories( rangedDamageKeyword, launcherWeaponKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Nanites, makeMaterialCategories(otherKeyword), CyborgKeyword, () => NPC.downedPlantBoss));

            recipes.AddRange(buildCommonShopRecipe(ItemID.CyborgHelmet, makeVanityCategories(armorHeadKeyword), CyborgKeyword, () => NPC.downedPlantBoss && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CyborgShirt, makeVanityCategories(armorBodyKeyword), CyborgKeyword, () => NPC.downedPlantBoss && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CyborgPants, makeVanityCategories(armorLegsKeyword), CyborgKeyword, () => NPC.downedPlantBoss && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));

            recipes.AddRange(buildCommonShopRecipe(ItemID.HiTekSunglasses, makeVanityCategories(armorHeadKeyword), CyborgKeyword, () => NPC.downedPlantBoss && NPC.downedMartians));
            recipes.AddRange(buildCommonShopRecipe(ItemID.NightVisionHelmet, makeArmorCategories(armorHeadKeyword), CyborgKeyword, () => NPC.downedPlantBoss && NPC.downedMartians));

            recipes.AddRange(buildCommonShopRecipe(ItemID.PortalGunStation, makeFurnitureCategories(stationKeyword), CyborgKeyword, () => NPC.downedPlantBoss && NPC.downedMoonlord));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
           
        }

        private void makePirateRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Cannon, makeFurnitureCategories(trapWeaponKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PirateHat, makeVanityCategories(armorHeadKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PirateShirt, makeVanityCategories(armorBodyKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PiratePants, makeVanityCategories(armorLegsKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Sail, makeMaterialCategories(blocksMaterialKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ParrotCracker, makePetsCategories(normalPetsKeyword), PirateKeyword, () => NPC.downedPirates));

            recipes.AddRange(buildCommonShopRecipe(ItemID.BunnyCannon, makeFurnitureCategories(trapWeaponKeyword), PirateKeyword, () => NPC.downedPirates));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
           
        }

        private void makeSteampunkerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Teleporter, makeFurnitureCategories(utilityKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Clentaminator, new List<string>() { utilityKeyword }, SteampunkerKeyword, () => NPC.downedMechBossAny));

            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkHat, makeVanityCategories(armorHeadKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkShirt, makeVanityCategories(armorBodyKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkPants, makeVanityCategories(armorHeadKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Jetpack, makeAccessoryCategories(movementKeyword, movementFlyingKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));

            recipes.AddRange(buildCommonShopRecipe(ItemID.Solidifier, makeFurnitureCategories(stationKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlendOMatic, makeFurnitureCategories(stationKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FleshCloningVaat, makeFurnitureCategories(stationKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkBoiler, makeFurnitureCategories(stationKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny && NPC.downedBoss1 && NPC.downedBoss2 && NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe(ItemID.Cog, makeMaterialCategories(otherKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny ));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkGoggles, makeVanityCategories(armorHeadKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SteampunkWings, makeAccessoryCategories(movementKeyword, movementFlyingKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny && NPC.downedGolemBoss));

            recipes.AddRange(buildCommonShopRecipe(ItemID.StaticHook, new List<string>() { utilityKeyword + "/" + hooksKeyword}, SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LogicGateLamp_On, makeFurnitureCategories(trapWeaponKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LogicGateLamp_Faulty, makeFurnitureCategories(trapWeaponKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            for (int i = ItemID.LogicGateLamp_Off; i <= ItemID.ConveyorBeltRight; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeFurnitureCategories(trapWeaponKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            }
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeTruffleRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.MushroomCap, makeVanityCategories(armorHeadKeyword), TruffleKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.StrangeGlowingMushroom, makePetsCategories(normalPetsKeyword), TruffleKeyword, () => Main.hardMode));
            

            recipes.AddRange(buildCommonShopRecipe(ItemID.MushroomSpear, makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword), TruffleKeyword, () => Main.hardMode && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Hammush, makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword), TruffleKeyword, () => Main.hardMode && NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Autohammer, makeFurnitureCategories(stationKeyword), TruffleKeyword, () => Main.hardMode && NPC.downedPlantBoss));
            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWizardRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.IceRod, makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SpellTome, makeMaterialCategories(bookWeaponKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreaterManaPotion, new List<string>() { potionKeyword }, WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Bell, makeMaterialCategories(otherKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Harp, makeMaterialCategories(otherKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CrystalBall, makeFurnitureCategories(stationKeyword), WizardKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WizardsHat, makeVanityCategories(armorHeadKeyword), WizardKeyword, () => Main.hardMode && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.EmptyDropper, new List<string>() { utilityKeyword }, WizardKeyword, () => Main.hardMode));
            
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePartyGirlRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
           
            recipes.AddRange(buildCommonShopRecipe(ItemID.ConfettiGun, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BubbleMachine, makeFurnitureCategories(functionalStatueKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BubbleWand, new List<string>() { utilityKeyword }, PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BeachBall, new List<string>() { utilityKeyword }, PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LavaLamp, makeFurnitureCategories(lightSourceKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FireworksBox, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedRocket, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword, ()=> Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenRocket, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueRocket, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.YellowRocket, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ConfettiCannon, makeFurnitureCategories(trapWeaponKeyword), PartyGirlKeyword, () => Main.hardMode && NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Bubble, makeMaterialCategories(blocksMaterialKeyword), PartyGirlKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SmokeBlock, makeMaterialCategories(blocksMaterialKeyword), PartyGirlKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyMonolith, makeFurnitureCategories(otherKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyHat, makeVanityCategories(armorHeadKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Pigronata, makeFurnitureCategories(otherKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SillyBalloonMachine, makeFurnitureCategories(otherKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyPresent, makeFurnitureCategories(otherKeyword), PartyGirlKeyword));

            for (int i = ItemID.SillyStreamerBlue; i <= ItemID.SillyStreamerPink; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, new List<string>() { utilityKeyword }, PartyGirlKeyword));
            }
            for (int i = ItemID.SillyBalloonPink; i <= ItemID.SillyBalloonGreen; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeMaterialCategories(blocksMaterialKeyword), PartyGirlKeyword));
            }
            for (int i = ItemID.SillyBalloonTiedPink; i <= ItemID.SillyBalloonTiedGreen; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeFurnitureCategories(otherKeyword), PartyGirlKeyword));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMechanicRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Wrench, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueWrench, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenWrench, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.YellowWrench, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WireCutter, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Wire, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Lever, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Switch, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BluePressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedPressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenPressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GrayPressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BrownPressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.YellowPressurePlate, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ProjectilePressurePad, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BoosterTrack, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Actuator, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WirePipe, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WireBulb, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Timer1Second, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Timer3Second, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Timer5Second, makeFurnitureCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MechanicalLens, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LaserRuler, new List<string>() { utilityKeyword }, MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.EngineeringHelmet, makeArmorCategories(armorHeadKeyword), MechanicKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MechanicsRod, makeFishingCategories(utilityKeyword), MechanicKeyword, () => NPC.downedBoss3));


            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeClothierRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.PinkThread, makeMaterialCategories(otherKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenThread, makeMaterialCategories(otherKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlackThread, makeMaterialCategories(otherKeyword), ClothierKeyword, () => NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe(ItemID.FamiliarWig, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FamiliarShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FamiliarPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Beanie, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SummerHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PlumbersShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PlumbersPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WhiteTuxedoShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WhiteTuxedoPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TheDoctorsShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TheDoctorsPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MimeMask, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FallenTuxedoShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FallenTuxedoPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GuyFawkesMask, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ClothierJacket, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ClothierPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3 &&( !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyBundleOfBalloonsAccessory, makeVanityCategories(accessoryKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyBalloonAnimal, makeVanityCategories(accessoryKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FlowerBoyHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FlowerBoyShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FlowerBoyPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3));

            recipes.AddRange(buildCommonShopRecipe(ItemID.ClownHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 &&Main.hardMode && NPC.downedClown));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ClownShirt, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode && NPC.downedClown));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ClownPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode && NPC.downedClown));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Tiara, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PrincessDress, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CowboyHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CowboyJacket, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CowboyPants, makeMaterialCategories(armorLegsKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TamOShanter, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BallaHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedFrost));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GangstaHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedFrost));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WhiteLunaticHood, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedAncientCultist));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WhiteLunaticRobe, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedAncientCultist));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueLunaticHood, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedAncientCultist));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueLunaticRobe, makeMaterialCategories(armorBodyKeyword), ClothierKeyword, () => NPC.downedBoss3 && NPC.downedAncientCultist));

            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorHat, makeVanityCategories(armorHeadKeyword), ClothierKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorSuit, makeVanityCategories(armorBodyKeyword), ClothierKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorPants, makeVanityCategories(armorLegsKeyword), ClothierKeyword, () => Main.hardMode));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeWitchDoctorRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Blowgun, makeWeaponsCategories(rangedDamageKeyword, dartsWeaponKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ImbuingStation, makeFurnitureCategories(stationKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Cauldron, makeFurnitureCategories(stationKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && (!ModContent.GetInstance<Config>().forceSeasonal || Main.halloween)));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LeafWings, makeAccessoryCategories(movementKeyword, movementFlyingKeyword), WitchDoctorKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TikiTotem, makePetsCategories(normalPetsKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.VialofVenom, makeMaterialCategories(otherKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TikiMask, makeArmorCategories(armorHeadKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TikiShirt, makeArmorCategories(armorBodyKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TikiPants, makeArmorCategories(armorLegsKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PygmyNecklace, makeAccessoryCategories(offenseKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.HerculesBeetle, makeAccessoryCategories(offenseKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee && NPC.downedPlantBoss));

            recipes.AddRange(buildCommonShopRecipe(ItemID.PureWaterFountain, makeFurnitureCategories(functionalStatueKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DesertWaterFountain, makeFurnitureCategories(functionalStatueKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            for (int i = ItemID.JungleWaterFountain; i <= ItemID.BloodWaterFountain; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeFurnitureCategories(functionalStatueKeyword), WitchDoctorKeyword, () => NPC.downedQueenBee));
            }

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeGoblinTinkererRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword, movementFlyingKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword, movementFlyingKeyword, movementBootsKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RocketBoots, workingCategories, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Ruler, new List<string>() { utilityKeyword }, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TinkerersWorkshop,  makeFurnitureCategories(stationKeyword), GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GrapplingHook, new List<string>() { utilityKeyword +"/" + hooksKeyword}, GoblinThinkererKeyword, () => NPC.downedGoblins));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Toolbelt, makeAccessoryCategories( utilityKeyword ), GoblinThinkererKeyword, () => NPC.downedGoblins));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePainterRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            for (int i = ItemID.Paintbrush; i <= ItemID.PaintScraper; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, new List<string>() { utilityKeyword + "/" + paintKeyword }, PainterKeyword));
            }
            recipes.AddRange(buildCommonShopRecipe(ItemID.BrownPaint, new List<string>() { utilityKeyword + "/" + paintKeyword }, PainterKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.NegativePaint, new List<string>() { utilityKeyword + "/" + paintKeyword }, PainterKeyword, ()=> Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ShadowPaint, new List<string>() { utilityKeyword + "/" + paintKeyword }, PainterKeyword, () => Main.hardMode));

            for (int i = ItemID.BubbleWallpaper; i <= ItemID.DuckyWallpaper; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeMaterialCategories(blocksMaterialKeyword), PainterKeyword));
            }
            for (int i = ItemID.FancyGreyWallpaper; i <= ItemID.StarlitHeavenWallpaper; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeMaterialCategories(blocksMaterialKeyword), PainterKeyword));
            }

            for (int i = ItemID.ChristmasTreeWallpaper; i <= ItemID.GrinchFingerWallpaper; i++)
            {
                recipes.AddRange(buildCommonShopRecipe(i, makeMaterialCategories(blocksMaterialKeyword), PainterKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.xMas));
            }

            recipes.AddRange(buildCommonShopRecipe(ItemID.PainterPaintballGun, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), PainterKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeArmsDealerRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.FlintlockPistol, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Minishark, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.IllegalGunParts, makeMaterialCategories(otherKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Shotgun, makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword), ArmsDealerKeyword, ()=>Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.EmptyBullet, makeMaterialCategories(otherKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.NurseHat, makeVanityCategories(armorHeadKeyword), ArmsDealerKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            recipes.AddRange(buildCommonShopRecipe(ItemID.NurseShirt, makeVanityCategories(armorBodyKeyword), ArmsDealerKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            recipes.AddRange(buildCommonShopRecipe(ItemID.NursePants, makeVanityCategories(armorLegsKeyword), ArmsDealerKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDryadRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            recipes.AddRange(buildCommonShopRecipe(ItemID.PurificationPowder, new List<string>() { utilityKeyword }, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.VilePowder, new List<string>() { utilityKeyword }, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ViciousPowder, new List<string>() { utilityKeyword }, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GrassSeeds,makeMaterialCategories(plantsMaterialKeyword), DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CorruptSeeds, makeMaterialCategories(plantsMaterialKeyword), DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CrimsonSeeds, makeMaterialCategories(plantsMaterialKeyword), DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Sunflower, makeMaterialCategories(plantsMaterialKeyword), DryadKeyword));
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(woodMaterialKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Acorn, workingCategories, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DirtRod, new List<string>() { utilityKeyword }, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PumpkinSeed, makeMaterialCategories(plantsMaterialKeyword), DryadKeyword));
            workingCategories = makeMaterialCategories(plantsMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(blocksMaterialKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GrassWall, workingCategories, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FlowerWall, workingCategories, DryadKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.JungleWall, workingCategories, DryadKeyword, ()=>Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.HallowedSeeds, makeMaterialCategories(plantsMaterialKeyword), DryadKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DryadCoverings, makeVanityCategories(armorBodyKeyword), DryadKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DryadLoincloth, makeVanityCategories(armorLegsKeyword), DryadKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));

            recipes.AddRange(buildCommonShopRecipe(ItemID.DayBloomPlanterBox, workingCategories, DryadKeyword, () => NPC.downedSlimeKing));
            recipes.AddRange(buildCommonShopRecipe(ItemID.MoonglowPlanterBox, workingCategories, DryadKeyword, () => NPC.downedQueenBee));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlinkrootPlanterBox, workingCategories, DryadKeyword, () => NPC.downedBoss1));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CrimsonPlanterBox, workingCategories, DryadKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CorruptPlanterBox, workingCategories, DryadKeyword, () => NPC.downedBoss2));
            recipes.AddRange(buildCommonShopRecipe(ItemID.WaterleafPlanterBox, workingCategories, DryadKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ShiverthornPlanterBox, workingCategories, DryadKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.FireBlossomPlanterBox, workingCategories, DryadKeyword, () => Main.hardMode));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeDyeTraderRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.DyeVat, makeFurnitureCategories(stationKeyword), DyeTraderKeyword));

            recipes.AddRange(buildCommonShopRecipe(ItemID.DyeTraderTurban, makeVanityCategories(armorHeadKeyword), DyeTraderKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DyeTraderRobe, makeVanityCategories(armorBodyKeyword), DyeTraderKeyword, () => !ModContent.GetInstance<Config>().forceSeasonal || Main.halloween));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DyeTradersScimitar, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), DyeTraderKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeMerchantRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.MiningHelmet, makeArmorCategories(armorHeadKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PiggyBank, makeFurnitureCategories(chestKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.IronAnvil, makeFurnitureCategories(stationKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BugNet, new List<string>() { utilityKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Sickle, new List<string>() { utilityKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Torch, makeFurnitureCategories(lightSourceKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LesserHealingPotion, new List<string>() { potionKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LesserManaPotion, new List<string>() { potionKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Rope, new List<string>() { utilityKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Marshmallow, new List<string>() { foodKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Glowstick, new List<string>() { utilityKeyword + "/" + lightSourceKeyword }, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Safe, makeFurnitureCategories(chestKeyword), MerchantKeyword, () => NPC.downedBoss3));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DiscoBall, makeFurnitureCategories(lightSourceKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.GoldDust, makeMaterialCategories(otherKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorHat, makeVanityCategories(armorHeadKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorSuit, makeVanityCategories(armorBodyKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorPants, makeVanityCategories(armorLegsKeyword), MerchantKeyword, () => Main.hardMode));
            recipes.AddRange(buildCommonShopRecipe(ItemID.TaxCollectorsStickOfDoom, makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword), MerchantKeyword, () => Main.hardMode));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeAmmoRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            //merchant
            recipes.AddRange(buildCommonShopRecipe(ItemID.WoodenArrow, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), MerchantKeyword));
            workingCategories = makeAmmoCategories(thrownWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(thrownWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Shuriken, workingCategories, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ThrowingKnife, workingCategories, MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Flare, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueFlare, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), MerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Nail, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), MerchantKeyword, () => NPC.downedPlantBoss));

            //demolitionist
            workingCategories = makeAmmoCategories(explosiveWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(explosiveWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Grenade, workingCategories, DemolitionistKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Bomb, workingCategories, DemolitionistKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Dynamite, workingCategories, DemolitionistKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.HellfireArrow, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), DemolitionistKeyword, () => Main.hardMode));
            workingCategories.AddRange(makeFurnitureCategories(trapWeaponKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.LandMine, workingCategories, DemolitionistKeyword, () => NPC.downedPlantBoss && NPC.downedPirates));

            //ArmsDealer
            recipes.AddRange(buildCommonShopRecipe(ItemID.MusketBall, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SilverBullet, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.UnholyArrow, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.StyngerBolt, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword, () => NPC.downedGolemBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Stake, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword, () => NPC.downedHalloweenTree));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Nail, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.CandyCorn, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword, () => NPC.downedHalloweenKing));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ExplosiveJackOLantern, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), ArmsDealerKeyword, () => NPC.downedHalloweenKing));

            //goblin tinkerer
            workingCategories = makeAmmoCategories(thrownWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(thrownWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SpikyBall, workingCategories, GoblinThinkererKeyword, () => NPC.downedGoblins));

            //witch doctor
            recipes.AddRange(buildCommonShopRecipe(ItemID.StyngerBolt, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), WitchDoctorKeyword, () => NPC.downedGolemBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Stake, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), WitchDoctorKeyword, () => NPC.downedHalloweenTree));

            //party girl
            workingCategories = makeAmmoCategories(explosiveWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(explosiveWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PartyGirlGrenade, workingCategories, PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Confetti, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), PartyGirlKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.SmokeBomb, workingCategories, PartyGirlKeyword));

            //Truffle
            recipes.AddRange(buildCommonShopRecipe(ItemID.DarkBlueSolution, makeAmmoCategories(solutionKeyword, utilityKeyword), TruffleKeyword, () => Main.hardMode));

            //Steampunker
            recipes.AddRange(buildCommonShopRecipe(ItemID.GreenSolution, makeAmmoCategories(solutionKeyword, utilityKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.PurpleSolution, makeAmmoCategories(solutionKeyword, utilityKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RedSolution, makeAmmoCategories(solutionKeyword, utilityKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BlueSolution, makeAmmoCategories(solutionKeyword, utilityKeyword), SteampunkerKeyword, () => NPC.downedMechBossAny));

            //pirate
            recipes.AddRange(buildCommonShopRecipe(ItemID.Cannonball, makeAmmoCategories(gunWeaponKeyword, rangedDamageKeyword), PirateKeyword, () => NPC.downedPirates));
            recipes.AddRange(buildCommonShopRecipe(ItemID.ExplosiveBunny, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), PirateKeyword, () => NPC.downedPirates));

            //cyborg
            recipes.AddRange(buildCommonShopRecipe(ItemID.RocketI, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RocketII, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RocketIII, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), CyborgKeyword, () => NPC.downedPlantBoss));
            recipes.AddRange(buildCommonShopRecipe(ItemID.RocketIV, makeAmmoCategories(launcherWeaponKeyword, rangedDamageKeyword), CyborgKeyword, () => NPC.downedPlantBoss));

            //skeleton merchant
            recipes.AddRange(buildCommonShopRecipe(ItemID.WoodenArrow, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), SkeletonMerchantKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.BoneArrow, makeAmmoCategories(bowWeaponKeyword, rangedDamageKeyword), SkeletonMerchantKeyword));
            workingCategories = makeAmmoCategories(explosiveWeaponKeyword, throwingDamageKeyword);
            workingCategories.AddRange(makeWeaponsCategories(explosiveWeaponKeyword, throwingDamageKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.Bomb, workingCategories, SkeletonMerchantKeyword));

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
        private void makeTavernkeepRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            recipes.AddRange(buildCommonShopRecipe(ItemID.Ale, new List<string>() { potionKeyword }, TavernkeepKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DD2ElderCrystalStand, makeFurnitureCategories(stationKeyword), TavernkeepKeyword));
            recipes.AddRange(buildCommonShopRecipe(ItemID.DD2ElderCrystal, new List<string>() { utilityKeyword }, TavernkeepKeyword));

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.DefendersForge, 1);
            workingCategories = makeFurnitureCategories(chestKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 1, ItemID.DD2FlameburstTowerT1Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.DD2FlameburstTowerT2Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 20, ItemID.DD2FlameburstTowerT3Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 1, ItemID.DD2BallistraTowerT1Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.DD2BallistraTowerT2Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 20, ItemID.DD2BallistraTowerT3Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 1, ItemID.DD2ExplosiveTrapT1Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.DD2ExplosiveTrapT2Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 20, ItemID.DD2ExplosiveTrapT3Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 1, ItemID.DD2LightningAuraT1Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.DD2LightningAuraT2Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 20, ItemID.DD2LightningAuraT3Popper, 1);
            workingCategories = makeWeaponsCategories(summonerDamageKeyword, staffWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.MonkBrows, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.MonkShirt, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.MonkPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.SquireGreatHelm, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.SquirePlating, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.SquireGreaves, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.HuntressWig, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.HuntressJerkin, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.HuntressPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.ApprenticeHat, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.ApprenticeRobe, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 5, ItemID.ApprenticeTrousers, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.MonkAltHead, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.MonkAltShirt, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.MonkAltPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.SquireAltHead, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.SquireAltShirt, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.SquireAltPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.HuntressAltHead, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.HuntressAltShirt, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.HuntressAltPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.ApprenticeAltHead, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.ApprenticeAltShirt, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DefenderShopPart>(), 15, ItemID.ApprenticeAltPants, 1);
            working.available = () => NPC.downedMechBossAny;
            workingCategories = makeArmorCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, TavernkeepKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
