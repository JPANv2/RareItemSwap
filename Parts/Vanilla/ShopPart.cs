using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Booth;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts.Vanilla
{
    public class MajorShopPart : ItemPart
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            this.item.value = Item.sellPrice(0, 5, 0, 0);
        }
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/MajorShopPart_World";
            base.DisplayName.SetDefault("Major Shop Part");
            base.Tooltip.SetDefault("Alternative shopping method. Worth 5 Gold coins.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 5);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumCoin, 1);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }
    public class ShopPart : ItemPart
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            this.item.value = Item.sellPrice(0, 0, 5, 0);
        }
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/ShopPart_World";
            base.DisplayName.SetDefault("Shop Part");
            base.Tooltip.SetDefault("Alternative shopping method. Worth 5 Silver coins.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverCoin, 5);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 1);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }

    }
    public class MinorShopPart : ItemPart
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            this.item.value = Item.sellPrice(0, 0, 0, 5);
        }

        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/MinorShopPart_World";
            base.DisplayName.SetDefault("Minor Shop Part");
            base.Tooltip.SetDefault("Alternative shopping method. Worth 5 Copper coins.");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperCoin, 5);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverCoin, 1);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }

    public class DefenderShopPart : ItemPart
    {        

        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Vanilla/DefenderShopPart_World";
            base.DisplayName.SetDefault("Defender Shop Part");
            base.Tooltip.SetDefault("Alternative shopping method. Worth 5 Defender Tokens.");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DefenderMedal, 5);
            recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
