using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Booth;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts.Thorium
{
        public class VanquisherPart : ItemPart
        {
           
            public override void SetStaticDefaults()
            {
                base.worldDisplay = "ARareItemSwapJPANs/Parts/Thorium/VanquisherPart_World";
                base.DisplayName.SetDefault("Vanquisher Part");
                base.Tooltip.SetDefault("Alternative shopping method. Worth 1 Vanquisher Medal.");
            }

            public override void AddRecipes()
            {
                base.AddRecipes();
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ARareItemSwapJPANs.getItemTypeFromTag("ThoriumMod:VanquisherMedal"));
                recipe.AddTile(ModContent.GetInstance<PartBoothTile>());
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    
}
