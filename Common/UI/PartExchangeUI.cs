using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.UI.Elements;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader.UI.Elements;
using Terraria.UI;

namespace ARareItemSwapJPANs.Common.UI
{
    public class PartExchangeUI: UIState
    {
        public static bool visible;
        public DragableUIPanel panel;
        public float oldScale;

        public DestroySlot destroySlot;
        public SearchUITextBox search;
        public DestroyButton destroyButton;
        public DestroyAllButton destroyAllButton;
        public CloseButton closeButton;
        public PathTreePanel categories;
        public RecipePanel recipes;
        public TokenPanel tokenList;

        public PartRecipe selectedRecipe;

        public override void OnInitialize()
        {           
            visible = false;

            panel = new DragableUIPanel();
            panel.BackgroundColor = Color.CornflowerBlue;
            panel.BorderColor = Color.White;

            panel.Top.Set(Main.screenHeight / 2 - 150, 0);
            panel.Left.Set(Main.screenWidth / 2 - 300, 0);
            panel.Width.Set(600, 0);
            panel.Height.Set(300, 0);
            panel.MinWidth.Set(600, 0);
            panel.MinHeight.Set(300, 0);
            panel.MaxWidth.Set(1920, 0);
            panel.MaxHeight.Set(1080, 0);

            destroySlot = new DestroySlot(new Item());
            destroySlot.Top.Set(0, 0);
            destroySlot.Left.Set(0, 0);
            panel.Append(destroySlot);
            search = new SearchUITextBox();
            search.Top.Set(0, 0);
            search.Left.Set(destroySlot.Width.Pixels + destroySlot.MarginLeft + destroySlot.MarginRight + 112, 0);
            search.Width.Set(panel.GetInnerDimensions().Width - (destroySlot.Width.Pixels + destroySlot.MarginLeft + destroySlot.MarginRight + 12), 0);
            search.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);
            search.OnTextChanged += () => setVisible(true);
            panel.Append(search);

            destroyButton = new DestroyButton();
            destroyButton.BackgroundColor = Color.Red;
            destroyButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            destroyButton.Left.Set(destroySlot.Width.Pixels + 12, 0);
            destroyButton.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);
            destroyButton.Width.Set(search.Width.Pixels/6, 0);

            panel.Append(destroyButton);

            destroyAllButton = new DestroyAllButton();
            destroyAllButton.BackgroundColor = Color.Red;
            destroyAllButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            destroyAllButton.Left.Set(destroyButton.Left.Pixels + destroyButton.Width.Pixels + 12, 0);
            destroyAllButton.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);
            destroyAllButton.Width.Set(search.Width.Pixels / 6, 0);

            panel.Append(destroyAllButton);

            closeButton = new CloseButton();
            closeButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            closeButton.Left.Set(panel.GetInnerDimensions().Width - 20, 0);
            panel.Append(closeButton);

            categories = new PathTreePanel();
            categories.Top.Set(destroySlot.Height.Pixels + 12, 0);
            categories.Left.Set(0, 0);
            categories.Width.Set(panel.GetInnerDimensions().Width / 3 - 4, 0);
            categories.Height.Set(panel.GetInnerDimensions().Height - categories.Top.Pixels, 0);
            panel.Append(categories);

            recipes = new RecipePanel(this);
            recipes.Top.Set(destroySlot.Height.Pixels + 12, 0);
            recipes.Left.Set(panel.Width.Pixels / 3, 0);
            recipes.Width.Set(panel.GetInnerDimensions().Width * 2 / 3, 0);
            recipes.Height.Set(panel.GetInnerDimensions().Height - (recipes.Top.Pixels + destroySlot.Height.Pixels + 32), 0);
            panel.Append(recipes);
           

            tokenList = new TokenPanel(this);
            tokenList.Top.Set(recipes.Height.Pixels + recipes.Top.Pixels, 0);
            tokenList.Left.Set(panel.Width.Pixels / 3, 0);
            tokenList.Width.Set(panel.GetInnerDimensions().Width * 2 / 3, 0);
            tokenList.Height.Set(destroySlot.Height.Pixels + 32, 0);
            panel.Append(tokenList);

            Append(panel);

        }

     

        public void resize()
        {
            destroySlot.Top.Set(0, 0);
            destroySlot.Left.Set(0, 0);

            search.Top.Set(0, 0);
            search.Left.Set(destroySlot.Width.Pixels + destroySlot.MarginLeft + destroySlot.MarginRight + 12, 0);
            search.Width.Set(panel.GetInnerDimensions().Width - (destroySlot.Width.Pixels + destroySlot.MarginLeft + destroySlot.MarginRight + 12), 0);
            search.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);

            destroyButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            destroyButton.Left.Set(destroySlot.Width.Pixels + 12, 0);
            destroyButton.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);
            destroyButton.Width.Set(search.Width.Pixels / 6, 0);

            destroyAllButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            destroyAllButton.Left.Set(destroyButton.Left.Pixels + destroyButton.Width.Pixels + 12, 0);
            destroyAllButton.Height.Set(destroySlot.GetInnerDimensions().Height / 2, 0);
            destroyAllButton.Width.Set(search.Width.Pixels / 6, 0);

            closeButton.Top.Set(search.Top.Pixels + search.Height.Pixels + 2, 0);
            closeButton.Left.Set(panel.GetInnerDimensions().Width - 20, 0);

            categories.Top.Set(destroySlot.Height.Pixels + 12, 0);
            categories.Left.Set(0, 0);
            categories.Width.Set(panel.GetInnerDimensions().Width / 3 - 4, 0);
            categories.Height.Set(panel.GetInnerDimensions().Height - categories.Top.Pixels, 0);

            recipes.Top.Set(destroySlot.Height.Pixels + 12, 0);
            recipes.Left.Set(panel.Width.Pixels / 3, 0);
            recipes.Width.Set(panel.GetInnerDimensions().Width*2 / 3, 0);
            recipes.Height.Set(panel.GetInnerDimensions().Height - (recipes.Top.Pixels + destroySlot.Height.Pixels + 32), 0);

            tokenList.Top.Set(recipes.Height.Pixels + recipes.Top.Pixels, 0);
            tokenList.Left.Set(panel.Width.Pixels / 3, 0);
            tokenList.Width.Set(panel.GetInnerDimensions().Width * 2 / 3, 0);
            tokenList.Height.Set(destroySlot.Height.Pixels + 32, 0);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (oldScale != Main.inventoryScale)
            {
                oldScale = Main.inventoryScale;
                Recalculate();
            }
        }

        public void setVisible(bool vis = true)
        {
            visible = vis;
            categories.hasChanged = true;
            recipes.hasChanges = true;
            tokenList.hasChanges = true;
            resize();
        }

        public void setSelectedRecipe(PartRecipe recipe)
        {
            if (recipe != null || (destroySlot.item == null || destroySlot.item.IsAir))
            {
                selectedRecipe = recipe;
                setVisible();
            }
        }
        public static void onScrollWheel(UIScrollWheelEvent evt, UIElement listeningElement)
        {
            Main.LocalPlayer.ScrollHotbar(Terraria.GameInput.PlayerInput.ScrollWheelDelta / 120);
        }

        internal static void onScrollWheelForUIText(UIScrollWheelEvent evt, UIElement listeningElement)
        {
            Main.LocalPlayer.ScrollHotbar(Terraria.GameInput.PlayerInput.ScrollWheelDelta / 360);
        }
    }

    public class CloseButton : UIText
    {
        public CloseButton():base("X") 
        {
            this.TextColor = Color.Red;
        }

        public override void Click(UIMouseEvent evt)
        {
            if (IsMouseHovering)
            {
                PartExchangeUI.visible = false;
            }
        }
    }
}
