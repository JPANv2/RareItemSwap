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
using Terraria.UI;
using Terraria.UI.Chat;

namespace ARareItemSwapJPANs.Common.UI.Elements
{
    /*Item slot for Parts.
     * When created, has a part it represents, and an amount thet is the total amount of that part
     * Normally displays a part image, and underneath the amount of that token, in white if available, red if not.
     * when hovered, displays the name of the part and the precise amount required and available.
     * When clicked on with no MouseItem, retrieves 1 token from storage as an item. Holding mouse down will keep adding them to your hand.
     * When clicked with a token of that kind in hand, deposits token.*/
    public class PartItemSlot : UIElement
    {
        public string partTag;
        public long amount = 0;
        private float scale;
        private Item item;
        private bool amountIsPlayerTotal = false;

        public PartItemSlot(string partTag, long amount = 0, float scale = 0.75f)
        {
            this.partTag = partTag;
            if (amount == -1)
            {
                this.amount = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().getPartAmount(partTag);
                amountIsPlayerTotal = true;
            }
            else
            {
                this.amount = amount;
            }
            this.scale = scale;
            this.Width.Set(Main.inventoryBack9Texture.Width * scale, 0f);
            this.Height.Set(Main.inventoryBack9Texture.Height * scale, 0f);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (item == null)
                item = ARareItemSwapJPANs.getItemFromTag(partTag);

            if(amountIsPlayerTotal)
                amount = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().getPartAmount(partTag);

            if (item != null && !item.IsAir)
            {
                long total = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().getPartAmount(partTag);
                if (IsMouseHovering)
                {
                    whileMouseHovering();
                    total = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().getPartAmount(partTag);
                    Main.HoverItem = item.Clone();
                    Main.hoverItemName = item.Name + " (" + total + ")";
                }

                CalculatedStyle dimensions = base.GetInnerDimensions();
                Rectangle rectangle = dimensions.ToRectangle();
                Texture2D itemTexture = Main.itemTexture[this.item.type];
                Rectangle rectangle2;
                if (Main.itemAnimations[item.type] != null)
                {
                    rectangle2 = Main.itemAnimations[item.type].GetFrame(itemTexture);
                }
                else
                {
                    rectangle2 = itemTexture.Frame(1, 1, 0, 0);
                }

                Color newColor = Color.White;
                float pulseScale = 1f;
                ItemSlot.GetItemLight(ref newColor, ref pulseScale, item, false);
                int height = rectangle2.Height;
                int width = rectangle2.Width;
                float drawScale = 1f;
                float availableWidth = (float)Main.inventoryBack9Texture.Width * scale;
                if (width > availableWidth || height > availableWidth)
                {
                    if (width > height)
                    {
                        drawScale = availableWidth / width;
                    }
                    else
                    {
                        drawScale = availableWidth / height;
                    }
                }
                drawScale *= scale;
                Vector2 vector = Main.inventoryBack9Texture.Size() * scale;
                Vector2 position2 = dimensions.Position() + vector / 2f - rectangle2.Size() * drawScale / 2f;
                Vector2 origin = rectangle2.Size() * (pulseScale / 2f - 0.5f);

                if (ItemLoader.PreDrawInInventory(item, spriteBatch, position2, rectangle2, item.GetAlpha(newColor),
                    item.GetColor(Color.White), origin, drawScale * pulseScale))
                {
                    spriteBatch.Draw(itemTexture, position2, new Rectangle?(rectangle2), item.GetAlpha(newColor), 0f, origin, drawScale * pulseScale, SpriteEffects.None, 0f);
                    if (item.color != Color.Transparent)
                    {
                        spriteBatch.Draw(itemTexture, position2, new Rectangle?(rectangle2), item.GetColor(Color.White), 0f, origin, drawScale * pulseScale, SpriteEffects.None, 0f);
                    }
                }
                ItemLoader.PostDrawInInventory(item, spriteBatch, position2, rectangle2, item.GetAlpha(newColor),
                    item.GetColor(Color.White), origin, drawScale * pulseScale);

                

                ChatManager.DrawColorCodedStringWithShadow(spriteBatch, Main.fontItemStack, "" + formattedAmount(), dimensions.Position() + new Vector2(0f, 32f) * scale, total > amount ? Color.White : total == amount ? Color.Yellow : Color.Red, 0f, Vector2.Zero, new Vector2(scale), -1f, scale);

                
            }
        }
        public void whileMouseHovering()
        {


            PartsPlayer p = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>();
            if (Main.mouseLeftRelease && Main.mouseLeft)
            {
                if (Main.mouseItem == null || Main.mouseItem.type == 0)
                {
                    Main.mouseItem = ARareItemSwapJPANs.getItemFromTag(partTag);
                    if (p.getPartAmount(partTag) >= Main.mouseItem.maxStack)
                    {   
                        Main.mouseItem.stack = Main.mouseItem.maxStack;
                        p.decreasePart(partTag, Main.mouseItem.maxStack);
                    }
                    else if (p.getPartAmount(partTag) > 0)
                    {
                        Main.mouseItem.stack = (int)p.getPartAmount(partTag);
                        p.decreasePart(partTag, p.getPartAmount(partTag));
                    }
                    else
                    {
                        Main.mouseItem.TurnToAir();
                    }
                }
                else
                {
                    if (p.addPart(Main.mouseItem))
                    {
                        Main.mouseItem.TurnToAir();
                    }
                }
            }
            else if (Main.stackSplit <= 1 && Main.mouseRight)
            {
                if (item.maxStack >= 1 && (Main.mouseItem.IsTheSameAs(item) || Main.mouseItem.type == 0) && (Main.mouseItem.stack < Main.mouseItem.maxStack || Main.mouseItem.type == 0))
                {
                    if (Main.mouseItem.type == 0)
                    {
                        if (p.decreasePart(partTag) != -1)
                        {
                            Main.mouseItem = ARareItemSwapJPANs.getItemFromTag(partTag);
                            Main.mouseItem.stack = 1;
                        }
                    }
                    else
                    {
                        if (Main.mouseItem.stack <= Main.mouseItem.maxStack && ARareItemSwapJPANs.ItemToTag(Main.mouseItem).Equals(partTag))
                        {
                            if (p.decreasePart(partTag) != -1)
                            {
                                Main.mouseItem.stack++;
                            }
                        }
                    }
                    Recipe.FindRecipes();
                    Main.soundInstanceMenuTick.Stop();
                    Main.soundInstanceMenuTick = Main.soundMenuTick.CreateInstance();
                    Main.PlaySound(12, -1, -1, 1, 1f, 0f);
                    if (Main.stackSplit == 0)
                    {
                        Main.stackSplit = 15;
                    }
                    else
                    {
                        Main.stackSplit = Main.stackDelay;
                    }
                }
            }

        }
        private string formattedAmount()
        {
            if (amount < 10000)
            {
                return "" + amount;
            }
            long outputAmount = amount / 1000;
            if (outputAmount < 10000)
            {
                return "" + outputAmount + "K";
            }
            outputAmount = outputAmount / 1000;
            if (outputAmount < 10000)
            {
                return "" + outputAmount + "M";
            }
            outputAmount = outputAmount / 1000;
            if (outputAmount < 10000)
            {
                return "" + outputAmount + "B";
            }
            outputAmount = outputAmount / 1000;
            if (outputAmount < 10000)
            {
                return "" + outputAmount + "T";
            }
            outputAmount = outputAmount / 1000;
            return "" + outputAmount + "Q";
        }

        public override int CompareTo(object obj)
        {
            if (obj == null || obj as PartItemSlot == null)
                return 1;
            return ARareItemSwapJPANs.getItemFromTag(partTag).Name.CompareTo(ARareItemSwapJPANs.getItemFromTag((obj as PartItemSlot).partTag).Name);
        }
    }
}
