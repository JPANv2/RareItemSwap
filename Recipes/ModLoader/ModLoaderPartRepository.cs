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

namespace ARareItemSwapJPANs.Recipes.ModLoader
{
    public partial class ModLoaderPartRepository : ModPartRepository
    {
        public override void AddRecipes()
        {
            makeDeveloperRecipes();
        }

        private void makeDeveloperRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<string> armors = new List<string>()
            {
                "ModLoader:toplayz_Head",
                "ModLoader:toplayz_Body",
                "ModLoader:toplayz_Legs",
                "ModLoader:KittyKitCatCat_Head",
                "ModLoader:KittyKitCatCat_Body",
                "ModLoader:KittyKitCatCat_Legs",
                "ModLoader:Polyblank_Head",
                "ModLoader:Polyblank_Body",
                "ModLoader:Polyblank_Legs",
                "ModLoader:dinidini_Head",
                "ModLoader:dinidini_Body",
                "ModLoader:dinidini_Legs",

                "ModLoader:Remeus_Head",
                "ModLoader:Remeus_Body",
                "ModLoader:Remeus_Legs",
                "ModLoader:Saethar_Head",
                "ModLoader:Saethar_Body",
                "ModLoader:Saethar_Legs",

                "ModLoader:Orian_Head",
                "ModLoader:Orian_Body",
                "ModLoader:Orian_Legs",
                "ModLoader:Glory_Head",
                "ModLoader:Glory_Body",
                "ModLoader:Glory_Legs",
                "ModLoader:POCKETS_Head",
                "ModLoader:POCKETS_Body",
                "ModLoader:POCKETS_Legs",

                "ModLoader:PowerRanger_Head",
                "ModLoader:PowerRanger_Body",
                "ModLoader:PowerRanger_Legs"
            };

            List<string> wings = new List<string>()
            {
               "ModLoader:dinidini_Wings",
                "ModLoader:Saethar_Wings",
                "ModLoader:POCKETS_Wings"
            };

            PartRecipe working;
            for (int i = 0; i < armors.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorHeadKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "ModLoader"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorBodyKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "ModLoader"));
                PartRecipes.addRecipe(working);
                i++;
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(armors[i]), 1);
                workingCategories = makeVanityCategories(armorLegsKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "ModLoader"));
                PartRecipes.addRecipe(working);
            }

            for (int i = 0; i < wings.Count; i++)
            {
                working = PartRecipe.SimplePartRecipe(ModContent.ItemType<DeveloperPart>(), 1, ARareItemSwapJPANs.getItemTypeFromTag(wings[i]), 1);
                workingCategories = makeAccessoryCategories(movementKeyword, movementFlyingKeyword);
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "ModLoader"));
                PartRecipes.addRecipe(working);
            }

        }
    }
}
