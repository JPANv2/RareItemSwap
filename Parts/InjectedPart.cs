using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts
{
    class InjectedPart : GlobalItem
    {

        public override bool CanPickup(Item itm, Player player)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(itm)))
                return true;
            return base.CanPickup(itm, player);
        }

        public override bool ItemSpace(Item itm, Player player)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(itm)))
                return true;
            return base.ItemSpace(itm, player);
        }

        public override bool OnPickup(Item item, Player player)
        {
            if (!ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(item)))
                return base.OnPickup(item, player);

            int oldStack = item.stack;
            if (player.GetModPlayer<PartsPlayer>().addPart(item))
            {
                Mod rmod = ModLoader.GetMod("ResearchFrom14");
                if (rmod != null && ModContent.GetInstance<Configs.Config>().researchCompatInfPart)
                {
                    object o = rmod.Call("IsResearched", player, item);
                    if (o != null && o is int && (o as int?).Value == 0)
                    {
                        player.GetModPlayer<PartsPlayer>().parts[ARareItemSwapJPANs.ItemToTag(item)] = long.MaxValue;
                    }
                }
                Main.PlaySound(SoundID.Grab, player.position);
                ItemText.NewText(item, oldStack);
                return false;
            }
            return true;
        }
        
        public override bool UseItem(Item itm, Player player)
        {
            if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(itm)))
            {
                ((ARareItemSwapJPANs)this.mod).ActivatePurchaseUI(player.whoAmI);
            }
            return base.UseItem(itm, player);
        }
    }
}
