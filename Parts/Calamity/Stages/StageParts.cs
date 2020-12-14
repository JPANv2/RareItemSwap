using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla.Stages;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts.Calamity.Stages
{
    public class PostProvidencePart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Stages/PostProvidencePart_World";
            base.DisplayName.SetDefault("Post Providence Part");
            base.Tooltip.SetDefault("From defeating enemies after Providence was defeated");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartRecipes.addRecipe(PartRecipe.SimplePartRecipe(this.item.type, 1, ModContent.ItemType<PostMoonLordPart>(), 1));
        }
    }

    public class PostDevourerOfGodsPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Stages/PostDevourerOfGodsPart_World";
            base.DisplayName.SetDefault("Post Devourer Of Gods Part");
            base.Tooltip.SetDefault("From defeating enemies after Devourer Of Gods was defeated");
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            PartRecipes.addRecipe(PartRecipe.SimplePartRecipe(this.item.type, 1, ModContent.ItemType<PostProvidencePart>(), 1));
        }
    }

    public class PostYharonPart : ItemPart
    {
        public override void SetStaticDefaults()
        {
            base.worldDisplay = "ARareItemSwapJPANs/Parts/Calamity/Stages/PostYharonPart_World";
            base.DisplayName.SetDefault("Post Yharon Part");
            base.Tooltip.SetDefault("From defeating enemies after Yharon was defeated for the first time");
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
            PartRecipes.addRecipe(PartRecipe.SimplePartRecipe(this.item.type, 1, ModContent.ItemType<PostDevourerOfGodsPart>(), 1));
        }
    }


}
