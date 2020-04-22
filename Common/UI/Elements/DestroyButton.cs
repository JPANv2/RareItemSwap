using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI;

namespace ARareItemSwapJPANs.Common.UI.Elements
{
    public class DestroyButton : UIPanel
    {

        private UIText buttonText;

        public override void OnInitialize()
        {
            buttonText = new UIText("Refund", 0.50f);
            buttonText.HAlign = buttonText.VAlign = 0.5f;
            this.Append(buttonText);
            base.OnInitialize();
        }

        public override void Update(GameTime gameTime)
        {
            Item itm = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem;
            if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(itm))){
                buttonText.SetText("Deposit");
            }
            else
            {
                buttonText.SetText("Refund");
            }
            base.Update(gameTime);
        }

        public override void Click(UIMouseEvent evt)
        {
            Item itm = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem;
            if (itm != null && !itm.IsAir)
            {
                 ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).DestroyPlayerItemForParts(itm);
            }
        }
    }

    public class DestroyAllButton : UIPanel
    {

        private UIText buttonText;

        public override void OnInitialize()
        {
            buttonText = new UIText("Refund All", 0.50f);
            buttonText.HAlign = buttonText.VAlign = 0.5f;
            this.Append(buttonText);
            base.OnInitialize();
        }

        public override void Update(GameTime gameTime)
        {
            Item itm = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem;
            if (ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(itm)))
            {
                buttonText.SetText("Deposit");
            }
            else
            {
                buttonText.SetText("Refund All");
            }
            base.Update(gameTime);
        }

        public override void Click(UIMouseEvent evt)
        {
            Item itm = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem;
            int orgStack = -1;
            while (itm != null && !itm.IsAir && orgStack != itm.stack)
            {
                orgStack = itm.stack;
                ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).DestroyPlayerItemForParts(itm);
            }
        }
    }
}
