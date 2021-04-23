using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace ARareItemSwapJPANs.Recipes
{
    public class PublicModPartRepository : ModPartRepository
    {

        public Dictionary<string, Func<bool>> dropsInEvent = new Dictionary<string, Func<bool>>();
        public Dictionary<string, Func<bool>> dropsInBiome = new Dictionary<string, Func<bool>>();
        public Dictionary<string, Func<bool>> dropsInWeather = new Dictionary<string, Func<bool>>();
        public Dictionary<string, Func<bool>> dropsInStage = new Dictionary<string, Func<bool>>();

        public override List<int> getEventPartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            List<int> ans = new List<int>();
            foreach(string s in dropsInEvent.Keys)
            {
                if (dropsInEvent[s]())
                    ans.Add(ARareItemSwapJPANs.getItemTypeFromTag(s));
            }
            return ans;
        }

        public override List<int> getBiomePartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            List<int> ans = new List<int>();
            foreach (string s in dropsInBiome.Keys)
            {
                if (dropsInBiome[s]())
                    ans.Add(ARareItemSwapJPANs.getItemTypeFromTag(s));
            }
            return ans;
        }

        public override List<int> getWeatherPartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            List<int> ans = new List<int>();
            foreach (string s in dropsInWeather.Keys)
            {
                if (dropsInWeather[s]())
                    ans.Add(ARareItemSwapJPANs.getItemTypeFromTag(s));
            }
            return ans;
        }

        public override List<int> getStagePartsDrops(NPC npc, Player p, List<int> listSoFar = null)
        {
            List<int> ans = new List<int>();
            foreach (string s in dropsInStage.Keys)
            {
                if (dropsInStage[s]())
                    ans.Add(ARareItemSwapJPANs.getItemTypeFromTag(s));
            }
            return ans;
        }

        public override void AddRecipes()
        {
            
        }
    }
}
