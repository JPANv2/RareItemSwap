using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts.Thorium.Biomes;
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
        Mod mod;

        #region keywords
        /*classes*/
        public const string bardKeyword = "Bard";
        public const string symphonicKeyword = "Symphonic";
        public const string HealerKeyword = "Healer";
        public const string radiantKeyword = "Radiant";
        public const string transformationKeyword = "Transformation";

        public const string techniqueKeyword = "Technique";

        /*Weapon types*/
        public const string brassInstrumentKeyword = "Brass Instrument";
        public const string stringInstrumentKeyword = "String Instrument";
        public const string windInstrumentKeyword = "Wind Instrument";
        public const string percursionInstrumentKeyword = "Percursion Instrument";
        public const string electronicInstrumentKeyword = "Electronic Instrument";

        /*bosses*/
        public const string GrandThunderBirdKeyword = "Grand Thunder Bird";
        public const string QueenJellyfishKeyword = "Queen Jellyfish";
        public const string ViscountKeyword = "Viscount";
        public const string GraniteEnergyStormKeyword = "Granite Energy Storm";
        public const string BuriedChampionKeyword = "Buried Champion";
        public const string StarScouterKeyword = "Star Scouter";

        public const string BoreanStriderKeyword = "Borean Strider";
        public const string CoznixKeyword = "Coznix";
        public const string LichKeyword = "Lich";
        public const string AbyssionKeyword = "Abyssion";
        public const string RagnarokKeyword = "Primordials";

        /*biomes*/
        public const string aquaticDepthsBiomeKeyword = "Aquatic Depths";

        /*NPCs*/
        public const string BlacksmithKeyword = "Blacksmith";
        public const string CobblerKeyword = "Cobbler";
        public const string ConfusedZombieKeyword = "Confused Zombie";
        public const string CookKeyword = "Cook";
        public const string DesertAcolyteKeyword = "Desesrt Acolyte";
        public const string DivermanKeyword = "Diverman";
        public const string DruidKeyword = "Druid";
        public const string SpiritualistKeyword = "Spiritualist";
        public const string TrackerKeyword = "Tracker";
        public const string WeaponMasterKeyword = "WeaponMaster";
        #endregion

        public override List<int> getBiomePartsDrops(NPC npc, Player p, List<int> parts)
        {
            if (mod != null) {
                ModPlayer pl = p.GetModPlayer(mod, "ThoriumPlayer");
                FieldInfo zone = pl.GetType().GetField("ZoneAqua", BindingFlags.Public | BindingFlags.Instance);
                if(zone != null && (bool)zone.GetValue(pl) == true)
                {
                    parts.Clear();
                    parts.Add(ModContent.ItemType<AquaticDepthsPart>());
                    return new List<int>();
                }
            }
            return base.getBiomePartsDrops(npc, p, parts);
        }

        public override void AddRecipes()
        {
            mod = Terraria.ModLoader.ModLoader.GetMod("ThoriumMod");
            if (mod == null)
                return;
            makeBossRecipes();
            makeShopRecipes();
            makeChestsAndFishingRecipes();
            makeDeveloperRecipes();
            makeMiscRecipes();
        }

        private void makeDeveloperRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;
            List<string> halfArmors = new List<string>() {
                "ThoriumMod:CataclysmicsGarb",
                "ThoriumMod:CataclysmicsHollowMask"
            };
            List<string> armors = new List<string>()
            {
                "ThoriumMod:ChunkyHelmet",
                "ThoriumMod:ChunkyMail",
                "ThoriumMod:ChunkyGreaves",
                "ThoriumMod:DannyLamentMask",
                "ThoriumMod:DannyLamentSuit",
                "ThoriumMod:DannyLamentLeggings",
                "ThoriumMod:GhastlyHood",
                "ThoriumMod:GhastlyGarment",
                "ThoriumMod:GhastlyLeggings",
                "ThoriumMod:GrandThoriumHelmet",
                "ThoriumMod:GrandThoriumBreastPlate",
                "ThoriumMod:GrandThoriumGreaves",
                "ThoriumMod:HalcandranHood",
                "ThoriumMod:HalcandranTabard",
                "ThoriumMod:HalcandranPants",
                "ThoriumMod:MrUniverseMask",
                "ThoriumMod:MrUniverseSuit",
                "ThoriumMod:MrUniversePants",
                "ThoriumMod:OrnateGypsyAntlers",
                "ThoriumMod:OrnateGypsyRobe",
                "ThoriumMod:OrnateGypsyLoincloth",
                "ThoriumMod:RhodiumMask",
                "ThoriumMod:RhodiumBreastplate",
                "ThoriumMod:RhodiumGreaves"
            };

            List<string> wings = new List<string>()
            { "ThoriumMod:PhonicWings"};

            PartRecipe working;
            for (int i = 0; i < armors.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorHeadKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorBodyKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorLegsKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
            }
            for (int i = 0; i < halfArmors.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(halfArmors[i]), 1);
                workingCategories = makeVanityCategories(armorHeadKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(halfArmors[i]), 1);
                workingCategories = makeVanityCategories(armorBodyKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
            }

                for (int i = 0; i < wings.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(wings[i]), 1);
                workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Thorium"));
                PartRecipes.addRecipe(working);
            }
            foreach (PartRecipe pr in recipes)
            {
                PartRecipes.addRecipe(pr);
            }
        }
    }
}
