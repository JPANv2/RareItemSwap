using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ARareItemSwapJPANs.Common.Booth
{
    public class PartBooth: ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Part Booth");
            Tooltip.SetDefault("Swap your Parts for items (and vice versa) and check your Part balance here.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 1;
            item.consumable = true;

            item.width = 20;
            item.height = 20;

            item.createTile = ModContent.TileType<PartBoothTile>();
            //item.placeStyle = 0;
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 20);
            recipe.AddIngredient(ItemID.Glass, 20);
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.anyWood = true;
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PartBoothTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[(int)Type] = true;

            Main.tileNoAttach[(int)Type] = true;
            Main.tileLavaDeath[(int)Type] = false;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.LavaPlacement = LiquidPlacement.Allowed;
            TileObjectData.newTile.WaterDeath = false;
            TileObjectData.newTile.WaterPlacement = LiquidPlacement.Allowed;
            TileObjectData.newTile.Origin = new Point16(0, 3);
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinateHeights = new int[]
            {
                16,
                16,
                16,
                16
            };

            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.AnchorInvalidTiles = new int[] { 127 };

            TileObjectData.addTile((int)Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Part Booth");
            base.AddMapEntry(new Microsoft.Xna.Framework.Color(200, 200, 200), name);
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 0;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int k = -1;
            if (Main.netMode != 1)
            {
                    k = Item.NewItem(i * 16, j * 16, 48, 64, ModContent.ItemType<PartBooth>(), 1, false, 0, false, false);
            }
            if (Main.netMode == 2 && k >= 0)
            {
                NetMessage.SendData(21, -1, -1, null, k, 0f, 0f, 0f, 0, 0, 0);
            }
        }

        public override bool NewRightClick(int i, int j)
        {
            if(Main.netMode != NetmodeID.Server)
            {
                (mod as ARareItemSwapJPANs).ActivatePurchaseUI(Main.myPlayer);
            }
            return true;
        }
    }
}
