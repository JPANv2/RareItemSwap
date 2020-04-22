using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using ARareItemSwapJPANs.Configs;
using ARareItemSwapJPANs.Parts.Vanilla;

namespace ARareItemSwapJPANs.Common.Globals
{
    class GlobalBobberProjectile : GlobalProjectile
    {
        public override void Kill(Projectile projectile, int timeLeft)
        {
            if (projectile.aiStyle == 61 && projectile.ai[1] > 0f && projectile.ai[1] < (float)ItemLoader.ItemCount)
            {
                if(Main.rand.NextDouble() < ModContent.GetInstance<Config>().partDropChance)
                {
                    int partC = Main.rand.Next(ModContent.GetInstance<Config>().randParts) + ModContent.GetInstance<Config>().minParts;
                    Main.player[projectile.owner].QuickSpawnItem((int)ModContent.ItemType<FishingPart>(), partC);
                }
            }
        }
    }
}
