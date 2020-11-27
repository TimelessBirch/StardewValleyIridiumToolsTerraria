using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StardewValleyIridiumTools.Items.Placeable
{
	public class IridiumBarPlaceable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Material");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;
			DisplayName.SetDefault("Iridium Bar");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = TileType<Tiles.IridiumBarTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<IridiumOrePlaceable>(), 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}