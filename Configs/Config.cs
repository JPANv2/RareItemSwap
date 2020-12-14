using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace ARareItemSwapJPANs.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Chance for Part Drop")]
        [Tooltip("What is the probability, between 0 and 1 that a part will drop from an enemy (default 0.2)")]
        [Range(0.0f, 1f)]
        [Increment(.01f)]
        [DrawTicks]
        [DefaultValue(0.2f)]
        public float partDropChance;

        [Label("Minimum Parts")]
        [Tooltip("How many parts will an enemy drop at least if it would drop one (default 1).")]
        [Range(0, 100)]
        [Increment(1)]
        [DefaultValue(1)]
        public int minParts;

        [Label("Random Parts")]
        [Tooltip("How many parts will an enemy additionally drop (random from 0 to value) if it drops one (default 0).")]
        [Range(0, 100)]
        [Increment(1)]
        [DefaultValue(0)]
        public int randParts;


        [Label("Max Different Parts")]
        [Tooltip("How many different parts can an enemy drop at most when biomes/events overlap (default 2).\nNote: Event, Biome, Boss and christmas/halloween parts are independantly dropped from one another, and can drop simultaneously even with a value of 1")]
        [Range(0, 50)]
        [Increment(1)]
        [DefaultValue(2)]
        public int maxDifferentParts;

        [Label("Minimum number of boss tokens")]
        [Tooltip("How many boss tokens a boss will always drop when killed (default 3).  20 is required for a weapon, 80 for its expert mode item, 100 for its bag")]
        [Range(0, 100)]
        [Increment(1)]
        [DefaultValue(3)]
        public int minNumOfBossParts;

        [Label("Random Boss tokens")]
        [Tooltip("How many additional randomly spawning boss tokens a boss will drop when killed (default 0-2).  20 is required for a weapon, 80 for its expert mode item, 100 for its bag")]
        [Range(0, 100)]
        [Increment(1)]
        [DefaultValue(2)]
        public int randNumOfBossParts;

        [Label("Chance for Shop Part Drop")]
        [Tooltip("What is the probability, between 0 and 1 that a Shop Part corresponding to the value of the npc will drop from an enemy (default 0.05) This will be like dropping extra money.")]
        [Range(0.0f, 1f)]
        [Increment(.01f)]
        [DrawTicks]
        [DefaultValue(0.05f)]
        public float shopPartDropChance;

        [Label("Use Fake Biomes")]
        [Tooltip("Biomes such as Granite, Marble and Spider Caves are (in vanilla Terraria) determined by walls, not tiles. However, most mods determine those biomes by a count of tiles./n" +
            "This generates a \"fake\" version of that biome. Should this mod calculate with both fake and real versions? (default true)")]
        [DefaultValue(true)]
        public bool useFakeBiomes;

        [Label("Force Seasonal Compliance")]
        [Tooltip("By default, this mod allows you to adquire shop Halloween and Christmas items all year round. Enable this option to only be able to get these items in season.")]
        [DefaultValue(false)]
        [ReloadRequired]
        public bool forceSeasonal;

        [Label("Research mod Compatibility - Infinite Parts on Shop")]
        [Tooltip("By turning this on, if you have a part researched on your inventory, as soon as you pick one up you will have max of that part.")]
        [DefaultValue(false)]
        public bool researchCompatInfPart;

        /* [Label("Part Exchanger goes first")]
         [Tooltip("The Part Exchanger turns all picked up items into Parts if equipped as an accessory, or so it should. The problem is if a mod's ItemSpace function returns true, it will never run. This will make it the first Global item in modloader, so it always works.")]
         [DefaultValue(true)]
         [ReloadRequired]
         public bool forcePickup;*/

    }
}
