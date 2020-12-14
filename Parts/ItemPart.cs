using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Parts
{
    public abstract class ItemPart: ModItem
    {
        public override bool CloneNewInstances => true; 
        public string worldDisplay = "";
        public override bool CanPickup(Player player)
        {
            return true;
        }

        public override bool ItemSpace(Player player)
        {
            return true;
        }

        public override bool OnPickup(Player player)
        {
            int oldStack = item.stack;
            if(player.GetModPlayer<PartsPlayer>().addPart(this.item)){
                Mod rmod = ModLoader.GetMod("ResearchFrom14");
                if (rmod != null && ModContent.GetInstance<Configs.Config>().researchCompatInfPart)
                {
                    object o = rmod.Call("IsResearched", player, this.item);
                    if (o != null && o is int && (o as int?).Value == 0)
                    {
                        player.GetModPlayer<PartsPlayer>().parts[ARareItemSwapJPANs.ItemToTag(this.item)] = long.MaxValue;
                    }
                }
                Main.PlaySound(SoundID.Grab, player.position);
                ItemText.NewText(item, oldStack);
                return false;
            }
            return true;
        }

        public override bool UseItem(Player player)
        {
            ((ARareItemSwapJPANs)this.mod).ActivatePurchaseUI(player.whoAmI);
            return base.UseItem(player);
        }

        public override void SetDefaults()
        {
            base.item.width = 16;
            base.item.height = 16;
            base.item.maxStack = 999;
            base.item.value = Item.sellPrice(0, 0, 0, 1);
            base.item.rare = 2;
            base.item.useStyle = 4;
            base.item.useTime = 5;
            base.item.useAnimation = 5;

        }

        public override void AddRecipes()
        {
            ARareItemSwapJPANs.tokenList.Add(ARareItemSwapJPANs.ItemToTag(item));
            Mod rmod = ModLoader.GetMod("ResearchFrom14");
            if (rmod == null)
                return;
            rmod.Call("SetDefaultMaxResearch", item.type, 100);
            rmod.Call("SetDefaultCategories", item.type, "Parts");
        }

        // Token: 0x060031BB RID: 12731 RVA: 0x0024C174 File Offset: 0x0024A374
        public override bool PreDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
        {
            Main.itemFrameCounter[whoAmI]++;
            if (Main.itemFrameCounter[whoAmI] > 5)
            {
                Main.itemFrameCounter[whoAmI] = 0;
                Main.itemFrame[whoAmI]++;
                if (Main.itemFrame[whoAmI] > 9)
                {
                    Main.itemFrame[whoAmI] = 0;
                }
            }
            Texture2D texture = ModContent.GetTexture(worldDisplay);
            Rectangle rectangle = Utils.Frame(texture, 1, 10, 0, Main.itemFrame[whoAmI]);
            rectangle.Height -= 2;
            Vector2 value = new Vector2((float)(base.item.width / 2 - rectangle.Width / 2), (float)(base.item.height - rectangle.Height));
            spriteBatch.Draw(texture, base.item.position - Main.screenPosition + Utils.Size(rectangle) / 2f + value, new Rectangle?(rectangle), alphaColor, rotation, Utils.Size(rectangle) / 2f, scale, SpriteEffects.None, 0f);
            return false;
        }
    }
}
