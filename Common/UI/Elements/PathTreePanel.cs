using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARareItemSwapJPANs.Common.Components;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.ModLoader.UI.Elements;
using Terraria.UI;
using FixedUIScrollbar = Terraria.ModLoader.UI.Elements.FixedUIScrollbar;

namespace ARareItemSwapJPANs.Common.UI.Elements
{
    public class PathTreePanel : UIPanel
    {
        public PathTree allTree = PathTree.makePathTree("", "All");
        public PathTree partsTree = PathTree.makePathTree("", "Part Bank");
        public PathTree paths;
        public UIGridList internalGrid;
        public UIScrollbar scrollbar;

        public PathTree selected = null;

        public bool hasChanged = false;
        public PathTreePanel()
        {
            paths = null;
        }

        public override void OnActivate()
        {
            BackgroundColor = Color.Blue;
            BorderColor = Color.White;
            hasChanged = true;
            internalGrid = new UIGridList();
            internalGrid.OnScrollWheel += PartExchangeUI.onScrollWheelForUIText;

            //scrollbar = new UIScrollbar();
            scrollbar = new InvisibleScrollbar();
            Append(internalGrid);
            scrollbar.SetView(100f, 1000f);
            scrollbar.Height.Set(0, 1f);
            scrollbar.Width.Set(1, 0);
            scrollbar.Left.Set(-14, 1f);
            Append(scrollbar);
            internalGrid.SetScrollbar(scrollbar);
            
            allTree.open();
        }

        public override void Update(GameTime gameTime)
        {
            if(paths == null)
            {
                paths = PathTree.makeEmptyRoot();
                foreach(string key in PartRecipes.recipesByCategory.Keys){
                    paths.addChildren(PathTree.makePathTree("", key));
                }
                hasChanged = true;
            }

            if (hasChanged)
                buildPathList();
            Recalculate();
            base.Update(gameTime);
        }

        private void buildPathList()
        {
            internalGrid.Clear();
            internalGrid.Left.Set(2, 0);
            internalGrid.Top.Set(2, 0);
            internalGrid.Width.Set(0, 1.0f);
            internalGrid.Height.Set(0, 1.0f);

            float startX = 2;
            float startY = 2;

            UIPathTreeText all = new UIPathTreeText(this,allTree);
            all.Left.Set(startX, 0);
            /*all.Top.Set(startY, 0);
            startY = startY + 12f;*/
            if (selected == null)
                selected = partsTree;
            
            if (all.tree.SimpleEquals(selected))
                all.TextColor = Color.LimeGreen;

            internalGrid.Add(all);

            List<String> keys = new List<string>();
            keys.AddRange(paths.tree.Keys);
            keys.Sort();
            foreach(String key in keys)
            {
                buildPathListFromPath(paths.tree[key], ref startY, ref startX);
                startX -= 4;
            }

            UIPathTreeText parts = new UIPathTreeText(this, partsTree);
            parts.Left.Set(startX, 0);
           /* parts.Top.Set(startY, 0);
            startY = startY + 12f;*/
            if (parts.tree.SimpleEquals(selected))
                parts.TextColor = Color.LimeGreen;
            internalGrid.Add(parts);

            //internalGrid.Height.Set(Math.Max(this.Height.Pixels, startY), 0);
            Recalculate();
            internalGrid.RecalculateChildren();
            hasChanged = false;
        }

        public void buildPathListFromPath(PathTree child, ref float startY, ref float startX)
        {
            UIPathTreeText now = new UIPathTreeText(this, child);
            now.Left.Set(startX, 0);
            /*now.Top.Set(startY, 0);
            startY = startY + 12f;*/
            startX = startX + 4f;
            if (now.tree.SimpleEquals(selected))
                now.TextColor = Color.LimeGreen;
            internalGrid.Add(now);
            if (child.isOpen)
            {
                List<String> keys = new List<string>();
                keys.AddRange(child.tree.Keys);
                keys.Sort();
                foreach (String key in keys)
                {
                    buildPathListFromPath(child.tree[key], ref startY, ref startX);
                    startX -= 4;
                }
            }
        }
    }

    public class UIPathTreeText: UIText
    {
        public PathTree tree;
        PathTreePanel parent;
        public UIPathTreeText(PathTreePanel parent, PathTree tre) : base(tre.CommonName, Main.inventoryScale,false)
        {
            tree = tre;
            this.parent = parent;
            this.TextColor = Color.White;
        }

        public override void Click(UIMouseEvent evt)
        {
            if (IsMouseHovering)
            {
                tree.toggle();
                parent.hasChanged = true;
                parent.selected = this.tree;
                ((ARareItemSwapJPANs)ModLoader.GetMod("ARareItemSwapJPANs")).ExchangeUISelectRecipe(null);
            }
        }
    }
}
