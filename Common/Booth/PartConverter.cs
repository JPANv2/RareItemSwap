using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Common.Booth
{
    public class PartConverter : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Part Converter");
            Tooltip.SetDefault("Equipping this will turn all items you pick up that can be converted into parts into their equivalent Parts.\nIf more than one recipe is available, it will select the one which require the least amount of the picked item, and randomly beteen the remainder after that.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.GetInstance<PartBooth>(), 1);
            recipe.SetResult(this, 1);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(ModContent.GetInstance<PartBooth>(), 1);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.AddRecipe();
        }

        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<PartsPlayer>().autoDestroy = true;
        }
    }
}
