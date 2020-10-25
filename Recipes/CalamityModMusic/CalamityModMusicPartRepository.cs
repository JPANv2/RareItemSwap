using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common;
using ARareItemSwapJPANs.Parts.Vanilla;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Recipes.CalamityModMusic
{
    public class CalamityModMusicPartRepository : ModPartRepository
    {
        public override void AddRecipes()
        {
            List<PartRecipe> recipes = new List<PartRecipe>();
            List<string> workingCategories;

            List<string> boxes = new List<string>()
            {
                "CalamityModMusic:AbyssLowerMusicbox",
"CalamityModMusic:AcidRain2Musicbox",
"CalamityModMusic:AquaticScourgeMusicbox",
"CalamityModMusic:AstrageldonMusicbox",
"CalamityModMusic:AstralMusicbox",
"CalamityModMusic:AstralUndergroundMusicbox",
"CalamityModMusic:AstrumDeusMusicbox",
"CalamityModMusic:BoomerDukeMusicbox",
"CalamityModMusic:BrimmyMusicbox",
"CalamityModMusic:BumblebirbMusicbox",
"CalamityModMusic:CalamitasMusicbox",
"CalamityModMusic:CeaselessVoidMusicbox",
"CalamityModMusic:CrabulonMusicbox",
"CalamityModMusic:CragMusicbox",
"CalamityModMusic:CryogenMusicbox",
"CalamityModMusic:DesertScourgeMusicbox",
"CalamityModMusic:DoGMusicbox",
"CalamityModMusic:DoGP2Musicbox",
"CalamityModMusic:HigherAbyssMusicbox",
"CalamityModMusic:HiveMindMusicbox",
"CalamityModMusic:LeviathanMusicbox",
"CalamityModMusic:PerforatorMusicbox",
"CalamityModMusic:PlaguebringerMusicbox",
"CalamityModMusic:PolterghastMusicbox",
"CalamityModMusic:ProfanedGuardianMusicbox",
"CalamityModMusic:ProvidenceMusicbox",
"CalamityModMusic:RavagerMusicbox",
"CalamityModMusic:SCalAMusicbox",
"CalamityModMusic:SCalEMusicbox",
"CalamityModMusic:SCalGMusicbox",
"CalamityModMusic:SCalLMusicbox",
"CalamityModMusic:SignusMusicbox",
"CalamityModMusic:SirenIdleMusicbox",
"CalamityModMusic:SirenMusicbox",
"CalamityModMusic:SlimeGodMusicbox",
"CalamityModMusic:StormWeaverMusicbox",
"CalamityModMusic:SulphurousMusicbox",
"CalamityModMusic:SunkenSeaMusicbox",
"CalamityModMusic:VoidMusicbox",
"CalamityModMusic:Yharon1Musicbox",
"CalamityModMusic:Yharon3Musicbox"
            };

            foreach (string box in boxes)
            {
                PartRecipe working = PartRecipe.SimplePartRecipe(ModContent.ItemType<MusicBoxPart>(), 1, box, 1);
                workingCategories = makeFurnitureCategories(musicBoxKeyword);
                workingCategories.AddRange(makeAccessoryCategories(musicBoxKeyword));
                working.addCategoryAndSubcategories(workingCategories);
                working.addCategoryAndSubcategories(makeByModCategories(workingCategories, "Calamity Music"));
                PartRecipes.addRecipe(working);
            }
        }
    }
}
