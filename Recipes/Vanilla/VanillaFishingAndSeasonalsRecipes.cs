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
        private void makeDeveloperRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<int> armors = new List<int>()
            {
                ItemID.AaronsHelmet,
                ItemID.AaronsBreastplate,
                ItemID.AaronsLeggings,
                ItemID.ArkhalisHat,
                ItemID.ArkhalisShirt,
                ItemID.ArkhalisPants,
                ItemID.CenxsTiara,
                ItemID.CenxsBreastplate,
                ItemID.CenxsLeggings,
                ItemID.CenxsTiara,
                ItemID.CenxsDress,
                ItemID.CenxsDressPants,
                ItemID.CrownosMask,
                ItemID.CrownosBreastplate,
                ItemID.CrownosLeggings,
                ItemID.DTownsHelmet,
                ItemID.DTownsBreastplate,
                ItemID.DTownsLeggings,
                ItemID.JimsHelmet,
                ItemID.JimsBreastplate,
                ItemID.JimsLeggings,
                ItemID.LeinforsHat,
                ItemID.LeinforsShirt,
                ItemID.LeinforsPants,
                ItemID.LokisHelm,
                ItemID.LokisShirt,
                ItemID.LokisPants,
                ItemID.RedsHelmet,
                ItemID.RedsBreastplate,
                ItemID.RedsLeggings,
                ItemID.SkiphsHelm,
                ItemID.SkiphsShirt,
                ItemID.SkiphsPants,
                ItemID.WillsHelmet,
                ItemID.WillsBreastplate,
                ItemID.WillsLeggings,
                ItemID.Yoraiz0rHead,
                ItemID.Yoraiz0rShirt,
                ItemID.Yoraiz0rPants
            };

            List<int> wings = new List<int>()
            {
                ItemID.ArkhalisWings,
                ItemID.CenxsWings,
                ItemID.CrownosWings,
                ItemID.DTownsWings,
                ItemID.BejeweledValkyrieWing,
                ItemID.LeinforsWings,
                ItemID.LokisWings,
                ItemID.JimsWings,
                ItemID.RedsWings,
                ItemID.SkiphsWings,
                ItemID.WillsWings,
                ItemID.Yoraiz0rWings
            };

            List<int> accessories = new List<int>()
            {
                ItemID.LeinforsAccessory,
                ItemID.Yoraiz0rDarkness
            };

            List<int> dyes = new List<int>()
            {
                ItemID.LokisDye,
                ItemID.DevDye
            };

            PartRecipe working;
            for (int i = 0; i < armors.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, armors[i], 1);
                workingCategories = makeVanityCategories(armorHeadKeyword); 
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, armors[i], 1);
                workingCategories = makeVanityCategories(armorBodyKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, armors[i], 1);
                workingCategories = makeVanityCategories(armorLegsKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ItemID.BejeweledValkyrieHead, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ItemID.BejeweledValkyrieBody, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);

            for (int i = 0; i < wings.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, wings[i], 1);
                workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            for (int i = 0; i < accessories.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, accessories[i], 1);
                workingCategories = makeVanityCategories(accessoryKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }

            for (int i = 0; i < dyes.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, dyes[i], 1);
                workingCategories = makeVanityCategories(dyeKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                PartRecipes.addRecipe(working);
            }
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ItemID.RedsYoyo, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ItemID.ValkyrieYoyo, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, yoyoWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
            PartRecipes.addRecipe(working);

        }

        private void makeSeasonalRecipes()
        {
            makePresentRecipes();
            makeGoodieBagRecipes();
        }

        private void makeGoodieBagRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 3, ItemID.CatEars, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CreeperMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CreeperShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CreeperPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PumpkinMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PumpkinShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PumpkinPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.SpaceCreatureMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.SpaceCreatureShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.SpaceCreaturePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CatMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CatShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.CatPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.KarateTortoiseMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.KarateTortoiseShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.KarateTortoisePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.FoxMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.FoxShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.FoxPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WitchHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WitchDress, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WitchBoots, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.VampireMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.VampireShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.VampirePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.LeprechaunHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.LeprechaunShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.LeprechaunPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.RobotMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.RobotShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.RobotPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PrincessHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PrincessDressNew, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.TreasureHunterShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.TreasureHunterPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WolfMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WolfShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.WolfPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.UnicornMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.UnicornShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.UnicornPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PixieShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.PixiePants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.BrideofFrankensteinMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.BrideofFrankensteinDress, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.GhostMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.GhostShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.ReaperHood, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.ReaperRobe, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 150, ItemID.BatHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 150, ItemID.UnluckyYarn, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 1, ItemID.RottenEgg, 5);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 3, ItemID.GoodieBag, 1);
            workingCategories = new List<string>() { otherKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 90, ItemID.MagicalPumpkinSeed, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 100, ItemID.BloodyMachete, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GoodieBagPart>(), 100, ItemID.BladedGlove, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, halloweenKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                // pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makePresentRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.CandyCaneBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.GreenCandyCaneBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.PineTreeBlock, 50);
            workingCategories = makeMaterialCategories(blocksMaterialKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.Eggnog, 1);
            workingCategories = new List<string>() { foodKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.StarAnise, 12);
            workingCategories = makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 4, ItemID.SugarCookie, 1);
            workingCategories = new List<string>() { foodKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 4, ItemID.ChristmasPudding, 1);
            workingCategories = new List<string>() { foodKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 4, ItemID.GingerbreadCookie, 1);
            workingCategories = new List<string>() { foodKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 16, ItemID.SnowHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 16, ItemID.UglySweater, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.ParkaHood, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.ParkaCoat, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.ParkaPants, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.TreeMask, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.TreeShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.TreeTrunks, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.MrsClauseHat, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.MrsClauseShirt, 1);
            workingCategories = makeVanityCategories(armorBodyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.MrsClauseHeels, 1);
            workingCategories = makeVanityCategories(armorLegsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 2, ItemID.Holly, 1);
            workingCategories = makeFurnitureCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 7, ItemID.ReindeerAntlers, 1);
            workingCategories = makeVanityCategories(armorHeadKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 5, ItemID.Coal, 1);
            workingCategories = makeMaterialCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.RedRyder, 1);
            workingCategories = makeWeaponsCategories(rangedDamageKeyword, gunWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.FruitcakeChakram, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, boomerangWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.CandyCaneSword, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.CnadyCanePickaxe, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.HandWarmer, 1);
            workingCategories = makeAccessoryCategories(defenseKeyword, buffsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 26, ItemID.CandyCaneHook, 1);
            workingCategories = new List<string>() { utilityKeyword + "/" + hooksKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 54, ItemID.CandyCaneHook, 1);
            workingCategories = makeAccessoryCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 70, ItemID.DogWhistle, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 2, ItemID.SnowGlobe, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<PresentPart>(), 1, ItemID.Present, 1);
            workingCategories = new List<string>() { otherKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByEventCategories(workingCategories, christmasKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                //pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeFishingRecipes()
        {
            makeFishRecipes();
            makeCrateRecipes();
            makeFishToolRecipes();
            makeQuestFishRecipes();
            makeAnglerDropRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 14, ItemID.PinkJellyfish, 1);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 14, ItemID.BlueJellyfish, 1);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 12, ItemID.GreenJellyfish, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.ApprenticeBait, 4);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 2, ItemID.JourneymanBait, 3);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.MasterBait, 1);
            workingCategories = makeFishingCategories(baitKeyword);
            workingCategories.Add(baitKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.OldShoe, 10);
            workingCategories = makeFishingCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.FishingSeaweed, 10);
            workingCategories = makeFishingCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.TinCan, 10);
            workingCategories = makeFishingCategories(otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeAnglerDropRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.FuzzyCarrot, 1);
            workingCategories = makeFishingCategories(mountKeyword);
            workingCategories.Add(mountKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.AnglerHat, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.Add(armorKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.AnglerVest, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.Add(armorKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.AnglerPants, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.Add(armorKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.GoldenFishingRod, 1);
            workingCategories = makeFishingCategories(utilityKeyword);
            workingCategories.Add(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.GoldenBugNet, 1);
            workingCategories = makeFishingCategories(utilityKeyword);
            workingCategories.Add(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.FishHook, 1);
            workingCategories = makeFishingCategories(utilityKeyword +"/" + hooksKeyword);
            workingCategories.Add(utilityKeyword + "/" + hooksKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.HighTestFishingLine, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.AnglerEarring, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.TackleBox, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.FishermansGuide, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            workingCategories.AddRange(makeAccessoryCategories(utilityKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.WeatherRadio, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            workingCategories.AddRange(makeAccessoryCategories(utilityKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.Sextant, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(fishingKeyword));
            workingCategories.AddRange(makeAccessoryCategories(utilityKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.FinWings, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword, movementFlyingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.BottomlessBucket, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.SuperAbsorbantSponge, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 55, ItemID.HotlineFishingHook, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.CoralstoneBlock, 20);
            workingCategories = makeFishingCategories(blocksMaterialKeyword);
            workingCategories.AddRange(makeMaterialCategories(blocksMaterialKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.BunnyfishTrophy, 1);
            workingCategories = makeFishingCategories(TrophyKeyword);
            workingCategories.Add(TrophyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.SharkteethTrophy, 1);
            workingCategories = makeFishingCategories(TrophyKeyword);
            workingCategories.Add(TrophyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.GoldfishTrophy, 1);
            workingCategories = makeFishingCategories(TrophyKeyword);
            workingCategories.Add(TrophyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.SwordfishTrophy, 1);
            workingCategories = makeFishingCategories(TrophyKeyword);
            workingCategories.Add(TrophyKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.TreasureMap, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.SeaweedPlanter, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.CompassRose, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.ShipsWheel, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.LifePreserver, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.WallAnchor, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.ShipInABottle, 1);
            workingCategories = makeFishingCategories(furnitureKeyword);
            workingCategories.AddRange(makeFurnitureCategories(otherKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.SeashellHairpin, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorHeadKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.MermaidAdornment, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorBodyKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.MermaidTail, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorLegsKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.FishCostumeMask, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorHeadKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.FishCostumeShirt, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorBodyKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.FishCostumeFinskirt, 1);
            workingCategories = makeFishingCategories(armorKeyword);
            workingCategories.AddRange(makeVanityCategories(armorLegsKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                //pr.irreversible = true; 
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeQuestFishRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<int> fishes = new List<int>()
            {
                ItemID.AmanitiaFungifin,
                ItemID.Angelfish,
                ItemID.Batfish,
                ItemID.BloodyManowar,
                ItemID.Bonefish,
                ItemID.BumblebeeTuna,
                ItemID.Bunnyfish,
                ItemID.CapnTunabeard,
                ItemID.Catfish,
                ItemID.Cloudfish,
                ItemID.Clownfish,
                ItemID.Cursedfish,
                ItemID.Dirtfish,
                ItemID.Derpfish,
                ItemID.DemonicHellfish,
                ItemID.DynamiteFish,
                ItemID.EaterofPlankton,
                ItemID.FallenStarfish,
                ItemID.TheFishofCthulu,
                ItemID.Fishotron,
                ItemID.Fishron,
                ItemID.GuideVoodooFish,
                ItemID.Harpyfish,
                ItemID.Hungerfish,
                ItemID.Ichorfish,
                ItemID.InfectedScabbardfish,
                ItemID.Jewelfish,
                ItemID.MirageFish,
                ItemID.Mudfish,
                ItemID.MutantFlinxfin,
                ItemID.Pengfish,
                ItemID.Pixiefish,
                ItemID.Slimefish,
                ItemID.Spiderfish,
                ItemID.TropicalBarracuda,
                ItemID.TundraTrout,
                ItemID.UnicornFish,
                ItemID.Wyverntail,
                ItemID.ZombieFish
            };

            foreach (int fish in fishes)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, fish, 1);
                workingCategories = makeFishingCategories(questFishKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria"));
                working.irreversible = true;
                PartRecipes.addRecipe(working);
            }
        }

        private void makeFishToolRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.FrogLeg, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword, movementFlyingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.BalloonPufferfish, 1);
            workingCategories = makeFishingCategories(accessoryKeyword);
            workingCategories.AddRange(makeAccessoryCategories(movementKeyword, movementFlyingKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 150, ItemID.ZephyrFish, 1);
            workingCategories = makeFishingCategories(petsKeyword);
            workingCategories.AddRange(makePetsCategories(normalPetsKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.ReaverShark, 1);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, pickaxeWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.SawtoothShark, 1);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, axeWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.Swordfish, 1);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.Rockfish, 1);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, hammerWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.PurpleClubberfish, 1);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.FrostDaggerfish, 3);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(throwingDamageKeyword, thrownWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.BombFish, 8);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(throwingDamageKeyword, explosiveWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.ObsidianSwordfish, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, spearWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.Bladetongue, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.CrystalSerpent, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(magicDamageKeyword, staffWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.Toxikarp, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories("Weapon");
            workingCategories.AddRange(makeWeaponsCategories(rangedDamageKeyword, staffWeaponKeyword));
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 50, ItemID.ScalyTruffle, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = makeFishingCategories(mountKeyword);
            workingCategories.Add(mountKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                //pr.irreversible = true; 
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeCrateRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.WoodenCrate, 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.SailfishBoots, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementBootsKeyword); 
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.TsunamiInABottle, 1);
            workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword); 
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 25, ItemID.Anchor, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, otherKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 200, ItemID.Sundial, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 1);
            workingCategories = makeFurnitureCategories(utilityKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.IronCrate, 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 40, ItemID.FalconBlade, 1);
            workingCategories = makeWeaponsCategories(meleeDamageKeyword, swordWeaponKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 52, ItemID.TartarSauce, 1);
            workingCategories = makePetsCategories(normalPetsKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 63, ItemID.GingerBeard, 1);
            workingCategories = makeVanityCategories(accessoryKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.GoldenCrate, 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 200, ItemID.HardySaddle, 1);
            workingCategories = new List<string>() { mountKeyword};
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.JungleFishingCrate, 1);
            working.addPart(ModContent.ItemType<JungleSurfacePart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.FloatingIslandFishingCrate, 1);
            working.addPart(ModContent.ItemType<SkySurfacePart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.CorruptFishingCrate, 1);
            working.addPart(ModContent.ItemType<CorruptionSurfacePart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.CrimsonFishingCrate, 1);
            working.addPart(ModContent.ItemType<CrimsonSurfacePart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.HallowedFishingCrate, 1);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 5, ItemID.DungeonFishingCrate, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 1);
            workingCategories = makeFishingCategories(crateKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 30, ItemID.LockBox, 1);
            working.addPart(ModContent.ItemType<DungeonUndergroundPart>(), 6);
            workingCategories = new List<string>() { utilityKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, dungeonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                //pr.irreversible = true; 
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeFishRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.ArmoredCavefish, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);
            
            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Stinkfish, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 20, ItemID.GoldenCarp, 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.AtlanticCod, 4);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Bass, 5);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Hemopiranha, 4);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, crimsonBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Damselfish, 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, skyBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.DoubleCod, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Ebonkoi, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.FrostMinnow, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.CrimsonTigerfish, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, corruptionBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.NeonTetra, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Salmon, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.RedSnapper, 4);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Shrimp, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Trout, 5);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Tuna, 4);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, oceanBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 10, ItemID.ChaosFish, 1);
            working.addPart(ModContent.ItemType<HallowedUndergroundPart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.PrincessFish, 2);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 3, ItemID.Prismite, 1);
            working.addPart(ModContent.ItemType<HallowedSurfacePart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.FlarefinKoi, 3);
            working.addPart(ModContent.ItemType<HellUndergroundPart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Obsidifish, 8);
            working.addPart(ModContent.ItemType<HellUndergroundPart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hellBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.Honeyfin, 8);
            working.addPart(ModContent.ItemType<JungleUndergroundPart>(), 1);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.SpecularFish, 4);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<FishingPart>(), 1, ItemID.VariegatedLardfish, 2);
            workingCategories = makeFishingCategories(fishKeyword);
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                //pr.irreversible = true; 
                PartRecipes.addRecipe(pr);
            }

        }

        private void makeCritterRecipes()
        {
            makeBaitRecipes();
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<RainPart>(), 1, ItemID.Goldfish, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Bird, 5);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.Bird, 8);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.Bird, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GoldBird, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 30, ItemID.GoldBird, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 20, ItemID.GoldBird, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.BlueJay, 7);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.BlueJay, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.BlueJay, 15);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Cardinal, 7);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.Cardinal, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.Cardinal, 15);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Bunny, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GoldBunny, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Duck, 7);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.MallardDuck, 7);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Frog, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 35, ItemID.GoldFrog, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Mouse, 5);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 40, ItemID.GoldMouse, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<IceSurfacePart>(), 1, ItemID.Penguin, 4);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, iceBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Squirrel, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.SquirrelRed, 10);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.SquirrelGold, 1);
            workingCategories = new List<string>() { critterKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);


            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

        private void makeBaitRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Buggy, 10);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Sluggy, 20);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<JungleSurfacePart>(), 1, ItemID.Grubby, 40);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, jungleBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.Scorpion, 5);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DesertSurfacePart>(), 1, ItemID.BlackScorpion, 5);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, desertBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 1, ItemID.GlowingSnail, 5);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<GlowingMushroomUndergroundPart>(), 25, ItemID.TruffleWorm, 1);
            working.addPart(ModContent.ItemType<HardmodePart>(), 5);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, glowshroomBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestUndergroundPart>(), 1, ItemID.Snail, 10);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Worm, 10);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GoldWorm, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Grasshopper, 40);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GoldGrasshopper, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.Firefly, 15);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<HallowedSurfacePart>(), 1, ItemID.LightningBug, 20);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, hallowedBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 40, ItemID.GoldButterfly, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 4, ItemID.TreeNymphButterfly, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 3, ItemID.PurpleEmperorButterfly, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 2, ItemID.RedAdmiralButterfly, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 3, ItemID.JuliaButterfly, 2);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.UlyssesButterfly, 1);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.SulphurButterfly, 4);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.ZebraSwallowtailButterfly, 3);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            working = PartRecipe.SimplePartRecipe(ModContent.ItemType<ForestSurfacePart>(), 1, ItemID.MonarchButterfly, 15);
            workingCategories = new List<string>() { critterKeyword + "/" + baitKeyword, baitKeyword };
            working.addCategoryAndSubcategories(workingCategories);
            working.addCategoryAndSubcategories(makeByBiomeCategories(workingCategories, purityBiomeKeyword));
            working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Terraria")); recipes.Add(working);

            foreach (PartRecipe pr in recipes)
            {
                pr.irreversible = true;
                PartRecipes.addRecipe(pr);
            }
        }

    }
}
