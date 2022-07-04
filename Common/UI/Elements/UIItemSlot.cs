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
    public class UIItemSlot : UIElement
    {
        public static Texture2D defaultBackgroundTexture = Main.inventoryBack9Texture;
        public static Texture2D selectedBackgroundTexture = Main.inventoryBack3Texture;
        public Texture2D backgroundTexture = defaultBackgroundTexture;
        protected bool isSelected = false;
        internal float scale = .75f;
        public int itemType;
        public Item item;
        public Item realItem;
        public bool hideSlot = false;

        public UIItemSlot(Item item, float scale = .75f)
        {
            this.scale = scale;
            this.item = item;
            this.realItem = item;
            this.itemType = item.type;
            this.Width.Set(defaultBackgroundTexture.Width * scale, 0f);
            this.Height.Set(defaultBackgroundTexture.Height * scale, 0f);
        }

        internal int frameCounter = 0;
        internal int frameTimer = 0;
        private const int frameDelay = 7;

        public override void Update(GameTime gameTime)
        {
            if (realItem != item)
                item = realItem;

            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (item != null)
            {
                if (isSelected)
                {
                    backgroundTexture = selectedBackgroundTexture;
                }
                else
                {
                    backgroundTexture = defaultBackgroundTexture;
                }
                if (IsMouseHovering)
                {
                    whileMouseHovering();
                }
                CalculatedStyle dimensions = base.GetInnerDimensions();
                Rectangle rectangle = dimensions.ToRectangle();
                if (!hideSlot)
                {
                    spriteBatch.Draw(backgroundTexture, dimensions.Position(), null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
                    DrawAdditionalOverlays(spriteBatch, dimensions.Position(), scale);
                }
                if (!item.IsAir)
                {
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
                    float availableWidth = (float)defaultBackgroundTexture.Width * scale;
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
                    Vector2 vector = backgroundTexture.Size() * scale;
                    Vector2 position2 = dimensions.Position() + vector / 2f - rectangle2.Size() * drawScale / 2f;
                    Vector2 origin = rectangle2.Size() * (pulseScale / 2f - 0.5f);
                    //Vector2 drawPosition = dimensions.Position();
                    //drawPosition.X += defaultBackgroundTexture.Width * scale / 2f - (float)width * drawScale / 2f;
                    //drawPosition.Y += defaultBackgroundTexture.Height * scale / 2f - (float)height * drawScale / 2f;

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
                    if (ItemID.Sets.TrapSigned[item.type])
                    {
                        spriteBatch.Draw(Main.wireTexture, dimensions.Position() + new Vector2(40f, 40f) * scale, new Rectangle?(new Rectangle(4, 58, 8, 8)), Color.White, 0f, new Vector2(4f), 1f, SpriteEffects.None, 0f);
                    }
                    DrawAdditionalBadges(spriteBatch, dimensions.Position(), scale);
                    if (item.stack > 1)
                    {
                        ChatManager.DrawColorCodedStringWithShadow(spriteBatch, Main.fontItemStack, item.stack.ToString(), dimensions.Position() + new Vector2(10f, 26f) * scale, Color.White, 0f, Vector2.Zero, new Vector2(scale), -1f, scale);
                    }

                    //this.item.GetColor(Color.White);
                    //spriteBatch.Draw(itemTexture, drawPosition, rectangle2, this.item.GetAlpha(Color.White), 0f, Vector2.Zero, drawScale, SpriteEffects.None, 0f);
                    //if (this.item.color != default(Color))
                    //{
                    //	spriteBatch.Draw(itemTexture, drawPosition, new Rectangle?(rectangle2), this.item.GetColor(Color.White), 0f, Vector2.Zero, drawScale, SpriteEffects.None, 0f);
                    //}
                    //if (this.item.stack > 1)
                    //{
                    //	spriteBatch.DrawString(Main.fontItemStack, this.item.stack.ToString(), new Vector2(drawPosition.X + 10f * scale, drawPosition.Y + 26f * scale), Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
                    //}

                    
                }
            }
        }

        public virtual void whileMouseHovering()
        {
           
            Main.HoverItem = item.Clone();
            Main.hoverItemName = Main.HoverItem.Name + (Main.HoverItem.modItem != null ? " [" + Main.HoverItem.modItem.mod.Name + "]" : "");

            Main.HoverItem.SetNameOverride(Main.HoverItem.Name + (Main.HoverItem.modItem != null ? " [" + Main.HoverItem.modItem.mod.Name + "]" : ""));
        }

        public void select(bool selected = true)
        {
            isSelected = selected;
        }

        internal virtual void DrawAdditionalOverlays(SpriteBatch spriteBatch, Vector2 vector2, float scale)
        {
        }

        internal virtual void DrawAdditionalBadges(SpriteBatch spriteBatch, Vector2 vector2, float scale)
        {
        }
    }

    public class DestroySlot: UIItemSlot
    {
        public DestroySlot(Item item, float scale = .75f) : base(item, scale) { }
        public override void Click(UIMouseEvent evt)
        {
            if (IsMouseHovering)
            {
                if((Main.mouseItem == null || Main.mouseItem.IsAir) && item != null)
                {
                    Main.mouseItem = item;
                    realItem = new Item();
                    Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem = realItem;
                    ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).ExchangeUISelectRecipe(null);
                }
                else if (Main.mouseItem != null && (PartRecipes.ContainsAsResult(Main.mouseItem) || ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(Main.mouseItem))))
                {
                    if (item == null || item.IsAir)
                    {
                        realItem = Main.mouseItem;
                        Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem = Main.mouseItem;
                        Main.mouseItem = item;
                        if (!ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(realItem))){
                            ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).ExchangeUISelectRecipe(PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(realItem)][0]);
                        }
                        
                    }
                    else if(item.type == Main.mouseItem.type)
                    {
                        if(item.stack + Main.mouseItem.stack <= item.maxStack)
                        {
                            item.stack += Main.mouseItem.stack;
                            Main.mouseItem.TurnToAir();
                        }
                        else
                        {
                            Main.mouseItem.stack -= (item.maxStack - item.stack);
                            item.stack = item.maxStack;
                        }
                    }
                    else
                    {
                        {
                            Item temp = realItem;
                            realItem = Main.mouseItem;
                            Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem = Main.mouseItem;
                            Main.mouseItem = temp;
                            if (!ARareItemSwapJPANs.tokenList.Contains(ARareItemSwapJPANs.ItemToTag(realItem)))
                            {
                                ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).ExchangeUISelectRecipe(PartRecipes.recipesByResult[ARareItemSwapJPANs.ItemToTag(realItem)][0]);
                            }

                        }
                    }

                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem != realItem)
            {
                realItem = item = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>().destroyingItem;
            }
            base.Update(gameTime);
        }
    }

    public class PurchaseItemSlot : UIItemSlot
    {
        public PartRecipe recipe;
        
        public PurchaseItemSlot(PartRecipe recipe, float scale = 0.75F) : base(recipe.result, scale)
        {
            this.recipe = recipe;
        }

        public override void whileMouseHovering()
        {
            PartsPlayer p = Main.player[Main.myPlayer].GetModPlayer<PartsPlayer>();
            if (Main.mouseLeftRelease && Main.mouseLeft)
            { 
                if (Main.mouseItem == null || Main.mouseItem.type == 0)
                {
                    if (!isSelected)
                    {
                       ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).ExchangeUISelectRecipe(recipe);
                    }
                    else
                    {
                        Main.mouseItem = recipe.Purchase(p);
                    }
                 }
                 else
                 {
                    recipe.refund(p, ref Main.mouseItem);
                 }
            }
                else if (Main.stackSplit <= 1 && Main.mouseRight)
                {
                    if (item.maxStack >= 1 && (Main.mouseItem.IsTheSameAs(item) || Main.mouseItem.type == 0) && (Main.mouseItem.stack < Main.mouseItem.maxStack || Main.mouseItem.type == 0))
                    {
                        if (Main.mouseItem.type == 0)
                        {
                            Main.mouseItem = recipe.Purchase(p);
                        }
                        else
                        {
                            if (Main.mouseItem.stack + recipe.result.stack <= Main.mouseItem.maxStack)
                            {
                                Item purchased = recipe.Purchase(p);
                                if (!purchased.IsAir)
                                {
                                    Main.mouseItem.stack += purchased.stack;
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
                Main.hoverItemName = item.Name;
                string hoverItemName = Main.hoverItemName;
                Main.hoverItemName = hoverItemName + " ( " + item.stack + ")\nCosts:\n";
                foreach (Item pr in recipe.parts)
                {
                    Main.hoverItemName += " - " + pr.Name + " (" + pr.stack + ");\n";
                }
            if (recipe.irreversible)
            {
                Main.hoverItemName += "IRREVERSIBLE!";
            }
            if(ModLoader.GetMod("ResearchFrom14") != null)
            {
                Mod rmod = ModLoader.GetMod("ResearchFrom14");
                int? toResearch = (rmod.Call("isresearched", p.player, item)) as int?;
                if(toResearch != null)
                {
                    if (toResearch == -1)
                        Main.hoverItemName += "\nUnresearchable!";
                    else if (toResearch == -2)
                        Main.hoverItemName += "\nResearched by parts!";
                    else if (toResearch == -3)
                        Main.hoverItemName += "\nResearched by crafting!";
                    else if (toResearch == 0)
                        Main.hoverItemName += "\nResearched!";
                    else
                        Main.hoverItemName += "\nResearch " + toResearch + " more to unlock.";
                } 
            }
        }

        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            PurchaseItemSlot pr = obj as PurchaseItemSlot;
            if (pr == null)
                return 1;
            return PartRecipe.orderByResultName(this.recipe, pr.recipe);
            
        }
    }
}
