using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes
{
    public abstract class ModPartRepository
    {

        /*keywords*/
        public const string otherKeyword = "Other";
        /*equip slots*/
        public const string accessoryKeyword = "Accessory";
        public const string armorKeyword = "Armor";
        public const string armorHeadKeyword = "Head";
        public const string armorBodyKeyword = "Body";
        public const string armorLegsKeyword = "Legs";
        public const string armorSetKeyword = "Set";
        public const string dyeKeyword = "Dye";

        /*events*/
        public const string bloodMoonKeyword = "Blood Moon";
        public const string slimeRainKeyword = "Slime Rain";
        public const string goblinArmyKeyword = "Goblin Army";
        public const string frostLegionKeyword = "Frost Legion";
        public const string oldOnesArmyKeyword = "Old Ones Army";
        public const string pirateInvasionKeyword = "Pirate Invasion";
        public const string solarEclipseKeyword = "Solar Eclipse";
        public const string pumpkinMoonKeyword = "Pumpkin Moon";
        public const string frostMoonKeyword = "Frost Moon";
        public const string martianInvasionKeyword = "Martian Invasion";

        public const string christmasKeyword = "Christmas";
        public const string halloweenKeyword = "Halloween";

        /*Biomes*/
        public const string forestBiomeKeyword = "Purity";
        public const string purityBiomeKeyword = "Purity";
        public const string corruptionBiomeKeyword = "Corruption";
        public const string crimsonBiomeKeyword = "Crimson";
        public const string dungeonBiomeKeyword = "Dungeon";
        public const string snowBiomeKeyword = "Snow (Ice)";
        public const string iceBiomeKeyword = "Snow (Ice)";
        public const string oceanBiomeKeyword = "Ocean";
        public const string beachBiomeKeyword = "Ocean";
        public const string jungleBiomeKeyword = "Jungle";
        public const string templeBiomeKeyword = "Temple";
        public const string hellBiomeKeyword = "Hell";
        public const string desertBiomeKeyword = "Desert";
        public const string meteoriteBiomeKeyword = "Meteorite";
        public const string skyBiomeKeyword = "Sky (Space)";
        public const string hallowedBiomeKeyword = "Hallowed";
        public const string spiderCaveBiomeKeyword = "Spider Cave";
        public const string glowshroomBiomeKeyword = "Glowing Mushroom";
        public const string graniteBiomeKeyword = "Granite";
        public const string marbleBiomeKeyword = "Marble";

        public const string solutionKeyword = "Solution";

        /*damageTypes*/
        public const string meleeDamageKeyword = "Melee";
        public const string rangedDamageKeyword = "Ranged";
        public const string magicDamageKeyword = "Magic";
        public const string summonerDamageKeyword = "Summoner";
        public const string throwingDamageKeyword = "Throwing";
        public const string trueDamageKeyword = "True Damage";
        /*weapon types*/
        
        public const string swordWeaponKeyword = "Sword";
        public const string spearWeaponKeyword = "Spear";
        public const string flailWeaponKeyword = "Flail";
        public const string boomerangWeaponKeyword = "Boomerang";
        public const string yoyoWeaponKeyword = "Yo-yo";
        public const string pickaxeWeaponKeyword = "Pickaxe";
        public const string axeWeaponKeyword = "Axe";
        public const string hammerWeaponKeyword = "Hammer";
        public const string bowWeaponKeyword = "Bow";
        public const string gunWeaponKeyword = "Gun";
        public const string launcherWeaponKeyword = "Launcher";
        public const string flamethrowerWeaponKeyword = "Flamethrower";
        public const string dartsWeaponKeyword = "Darts";
        public const string staffWeaponKeyword = "Staff";
        public const string bookWeaponKeyword = "Book";
        public const string thrownWeaponKeyword = "Thrown";
        public const string explosiveWeaponKeyword = "Explosive";

        public const string trapWeaponKeyword = "Trap";

        /*Accessory types */
        public const string movementKeyword = "Movement";
        public const string movementSwimmingKeyword = "Swimming";
        public const string movementBootsKeyword = "Boots";
        public const string movementFlyingKeyword = "Jump and Flight";
        public const string defenseKeyword = "Defense";
        public const string offenseKeyword = "Offense";
        public const string debuffsKeyword = "Debuffs";
        public const string buffsKeyword = "Buffs";
        public const string immunityKeyword = "Immunity";

        public const string lifeKeyword = "Life";
        public const string manaKeyword = "Mana";

        /*Utility*/
        public const string utilityKeyword = "Utility";
        public const string hooksKeyword = "Hooks";
        /*Materials*/
        public const string materialKeyword = "Material";
        public const string gemsMaterialKeyword = "Gems";
        public const string oreMaterialKeyword = "Ores";
        public const string barsMaterialKeyword = "Bars";
        public const string blocksMaterialKeyword = "Blocks and Walls";
        public const string paintKeyword = "Paint";
        public const string plantsMaterialKeyword = "Plants";
        public const string woodMaterialKeyword = "Wood";
        public const string enemyDropsMaterialKeyword = "Enemy Drops";
        public const string SoulsMaterialKeyword = "Souls";
        public const string fragmentsMaterialKeyword = "Fragments";
        public const string liquidsMaterialKeyword = "Liquids";

        /*furniture*/
        public const string furnitureKeyword = "Furniture";
        public const string stationKeyword = "Station";
        public const string chestKeyword = "Chest";
        public const string statueKeyword = "Statue";
        public const string functionalStatueKeyword = "Functional";
        public const string decorativeKeyword = "Decorative";
        public const string musicBoxKeyword = "Music Box";
        public const string bannerKeyword = "Banner";
        public const string lightSourceKeyword = "Light Source";

        public const string critterKeyword = "Critter";
        
        public const string enemyKeyword = "Enemy";

        public const string paintingKeyword = "Painting";

        /*fishing*/
        public const string fishingKeyword = "Fishing";
        public const string fishKeyword = "Fish";
        public const string questFishKeyword = "Quest Fish";
        public const string baitKeyword = "Bait";
        public const string crateKeyword = "Crate";

        public const string potionKeyword = "Potion";
        public const string foodKeyword = "Food";
        /*pets*/
        public const string petsKeyword = "Pets";
        public const string lightPetsKeyword = "Light Pets";
        public const string normalPetsKeyword = "Normal Pets";
        public const string mountKeyword = "Mounts";
        /*NPC shops*/
        public const string MerchantKeyword = "Merchant";
        public const string DemolitionistKeyword = "Demolitionist";
        public const string DyeTraderKeyword = "Dye Trader";
        public const string DryadKeyword = "Dryad";
        public const string ArmsDealerKeyword = "Arms Dealer";
        public const string StylistKeyword = "Stylist";
        public const string PainterKeyword = "Painter";
        public const string GoblinThinkererKeyword = "Goblin Tinkerer";
        public const string WitchDoctorKeyword = "Witch Doctor";
        public const string ClothierKeyword = "Clothier";
        public const string MechanicKeyword = "Mechanic";
        public const string PartyGirlKeyword = "Party Girl";
        public const string TavernkeepKeyword = "Tavernkeep";
        public const string WizardKeyword = "Wizard";
        public const string TruffleKeyword = "Truffle";
        public const string PirateKeyword = "Pirate";
        public const string SteampunkerKeyword = "Steampunker";
        public const string CyborgKeyword = "Cyborg";
        public const string SantaKeyword = "Santa Claus";
        public const string TravelingMerchantKeyword = "Traveling Merchant";
        public const string SkeletonMerchantKeyword = "Skeleton Merchant";

        /*bosses*/
        public const string TreasureBagKeyword = "Treasure Bag";
        public const string TrophyKeyword = "Trophy";
        public const string maskKeyword = "Mask";

        public const string KingSlimeKeyword = "King Slime";
        public const string eocKeyword = "Eye of Cthulhu";
        public const string eowKeyword = "Eater of Worlds";
        public const string bocKeyword = "Brain of Cthulhu";
        public const string queenBeeKeyword = "Queen Bee";
        public const string skeletronKeyword = "Skeletron";
        public const string wofKeyword = "Wall of Flesh";
        public const string twinsKeyword = "The Twins";
        public const string destroyerKeyword = "The Destroyer";
        public const string skeletronPrimeKeyword = "Skeletron Prime";
        public const string planteraKeyword = "Plantera";
        public const string golemKeyword = "Golem";
        public const string dukeFishronKeyword = "Duke Fishron";
        public const string cultistKeyword = "Ancient (Lunatic) Cultist";
        public const string moonLordKeyword = "Moon Lord";

        public const string darkMageKeyword = "Dark Mage";
        public const string ogreKeyword = "Ogre";
        public const string betsyKeyword = "Betsy";
        public const string flyingDutchmanKeyword = "Flying Dutchman";
        public const string goblinSummonerKeyword = "Goblin Summoner";
        public const string mourningWoodKeyword = "Mourning Wood";
        public const string pumpkingKeyword = "Pumpking";
        public const string everscreamKeyword = "Everscream";
        public const string santaNK1Keyword = "Santa-NK1";
        public const string iceQueenKeyword = "Ice Queen";
        public const string martianSaucerKeyword = "Martian Saucer";


        public virtual List<int> getEventPartsDrops(NPC npc, Player p)
        {
            return new List<int>();
        }

        public virtual List<int> getBiomePartsDrops(NPC npc, Player p)
        {
            return new List<int>();
        }

        public virtual List<int> getWeatherPartsDrops(NPC npc, Player p)
        {
            return new List<int>();
        }

        public virtual List<int> getStagePartsDrops(NPC npc, Player p)
        {
            return new List<int>();
        }

        public abstract void AddRecipes();

        public static List<String> makeVanityCategories(string slot)
        {
            if (slot == null || slot.Length == 0)
            {
                return new List<String>()
                {
                    "Vanity"
                };
            }

            if (slot.Equals(accessoryKeyword))
            {
                return new List<String>()
                {
                    "Vanity/Accessory",
                    "Accessory/Vanity"
                };
            }
            if (slot.Equals(armorKeyword))
            {
                return new List<String>()
                {
                    "Vanity/Armor",
                    "Armor/Vanity"
                };
            }
            if (slot.Equals(dyeKeyword))
            {
                return new List<String>()
                {
                    "Vanity/Dye",
                    "Dye/Vanity"
                };
            }
            return new List<String>()
                {
                    "Vanity/Armor/"+slot,
                    "Armor/"+slot+"/Vanity",
                    "Armor/Vanity" + slot
                };
        }

        public static List<String> makeArmorCategories(string slot)
        {
            if (slot == null || slot.Length == 0)
            {
                return new List<String>()
                {
                    armorKeyword
                };
            }

            
            return new List<String>()
                {
                    armorKeyword + "/" + slot
                };
        }

        public static List<String> makeWeaponsCategories(string damageType, string weaponType)
        {
            if (damageType == null || damageType.Length == 0)
                damageType = trueDamageKeyword;

            if (weaponType == null || weaponType.Length == 0)
                weaponType = otherKeyword;

            return new List<String>()
                {
                    "Weapon/By Weapon Type/" +weaponType+"/"+damageType,
                    "Weapon/By Damage Type/"+damageType+"/"+weaponType,
                };
        }

        public static List<String> makeAccessoryCategories(string accType, string accTypeType = null, string accTypeTypeType = null)
        {
            if (accType == null || accType.Length == 0)
                accType = otherKeyword;

            if (accTypeType == null || accTypeType.Length == 0)
            {
                return new List<String>()
                {
                    accessoryKeyword + "/" + accType
                };
            }
            if (accTypeTypeType == null || accTypeTypeType.Length == 0)
            {
                return new List<String>()
                {
                    accessoryKeyword + "/" + accType + "/" + accTypeType
                };
            }
            return new List<String>()
            {
                    accessoryKeyword + "/" + accType + "/" + accTypeType + "/" + accTypeTypeType
            };
        }

        public static List<String> makeAmmoCategories(string ammoType, string damageType)
        {
            if (ammoType == null || ammoType.Length == 0)
                ammoType = otherKeyword;

            if (damageType == null || damageType.Length == 0)
            {
                return new List<String>()
                {
                    "Ammo/By Ammo Type/" +ammoType
                };

            }
            return new List<String>()
                {
                    "Ammo/By Ammo Type/" +ammoType+"/"+damageType,
                    "Weapon/By Damage Type/"+damageType+"/"+ammoType
                };
        }

        public static List<String> makeMaterialCategories(string materialType, string materialSubType = null)
        {
            if (materialType == null || materialType.Length == 0)
                materialType = otherKeyword;

            if (materialSubType == null || materialSubType.Length == 0)
            {
                return new List<String>()
                {
                    materialKeyword +"/"+materialType
                };

            }
            return new List<String>()
                {
                    materialKeyword +"/"+materialType+"/"+materialSubType
                };
        }

        public static List<String> makeFurnitureCategories(string furnitureType, string statueType = null, string statueTypeType = null)
        {
            if (furnitureType == null || furnitureType.Length == 0)
            {
                return new List<String>()
                {
                    furnitureKeyword
                };
            }

            if (furnitureType.Equals(statueKeyword)){
                return new List<String>()
                {
                   furnitureKeyword +"/"+ furnitureType + ((statueType == null || statueType.Length == 0)? "" : ("/"+ statueType + ((statueTypeType == null || statueTypeType.Length == 0)? "" :("/"+ statueTypeType))))
                };

            }

            return new List<String>()
                {
                   furnitureKeyword +"/"+ furnitureType
                };
        }
        

            public static List<String> makePetsCategories(string petType)
        {
            if (petType == null || petType.Length == 0)
            {
                return new List<String>()
                {
                    petsKeyword
                };
            }
            return new List<String>()
                {
                    petsKeyword +"/"+ petType
                };
        }
        public static List<String> makeFishingCategories(string fishedType)
        {
            if (fishedType == null || fishedType.Length == 0)
            {
                return new List<String>()
                {
                    fishingKeyword
                };
            }
            return new List<String>()
                {
                    fishingKeyword +"/"+ fishedType
                };
        }
        public static List<String> makeByModCategories(List<String> categories, String modName)
        {
            List<String> replies = new List<string>() { "By Mod/" + modName };
            foreach (String c in categories)
            {
                replies.Add("By Mod/" + modName + "/" + c);
            }
            return replies;
        }

        public static List<String> makeByBiomeCategories(List<String> categories, String biomeName)
        {
            List<String> replies = new List<string>() { "By Biome/" + biomeName };
            foreach (String c in categories)
            {
                replies.Add("By Biome/" + biomeName + "/" + c);
            }
            return replies;
        }

        public static List<String> makeByEventCategories(List<String> categories, String eventName)
        {
            List<String> replies = new List<string>() { "By Event/" + eventName };
            foreach (String c in categories)
            {
                replies.Add("By Event/" + eventName + "/" + c);
            }
            return replies;
        }

        public static List<String> makeByShopCategories(List<String> categories, String shopName)
        {
            List<String> replies = new List<string>() { "By Shop/" + shopName };
            foreach (String c in categories)
            {
                replies.Add("By Shop/" + shopName + "/" + c);
            }
            return replies;
        }

        public static List<String> makeByBossCategories(List<String> categories, String bossName)
        {
            List<String> replies = new List<string>() { "By Boss/" + bossName };
            foreach (String c in categories)
            {
                replies.Add("By Boss/" + bossName + "/" + c);
            }
            return replies;
        }

        public static List<PartRecipe> buildCommonShopRecipe(int ItemId, List<string> workingCategories, string shopKey, Func<bool> available = null)
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            Item itm = new Item();
            itm.SetDefaults(ItemId, true);
            if (itm.value < 1)
                itm.value = 1;

            int minorStack = 1;
            int stack = 1;
            int majorStack = 1;

            int minorPartCost = itm.value;
            int partCost = itm.value;
            int majorPartCost = itm.value;

            while (minorPartCost % 5 != 0)
            {
                minorPartCost += itm.value;
                minorStack += 1;
            }
            minorPartCost /= 5;
            if (minorStack > itm.maxStack)
                minorStack = 0;

            while (partCost % 500 != 0)
            {
                partCost += itm.value;
                stack++;
            }
            partCost /= 500;
            if (stack > itm.maxStack)
                stack = 0;

            while (majorPartCost % 50000 != 0)
            {
                majorPartCost += itm.value;
                majorStack++;
            }
            majorPartCost /= 50000;
            if (majorStack > itm.maxStack)
                majorStack = 0;
            PartRecipe working;
            if (minorStack == 0)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MinorShopPart>(), itm.value / 5 + 1, ItemId, 1);
                if (available != null)
                    working.setAvailableFunction(available);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, shopKey));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            }
            else
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MinorShopPart>(), minorPartCost, ItemId, minorStack);
                if (available != null)
                    working.setAvailableFunction(available);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, shopKey));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            }
            if (stack != 0)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ShopPart>(), partCost, ItemId, stack);
                if (available != null)
                    working.setAvailableFunction(available);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, shopKey));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            }
            if (majorStack != 0)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MajorShopPart>(), majorPartCost, ItemId, majorStack);
                if (available != null)
                    working.setAvailableFunction(available);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByShopCategories(workingCategories, shopKey));
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            }
            return recipes;
        }


        
    }
}
