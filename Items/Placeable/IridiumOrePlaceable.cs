using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StardewValleyIridiumTools.Items.Placeable
{
	public class IridiumOrePlaceable : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
			DisplayName.SetDefault("Iridium Ore");
		}

		public override void SetDefaults()
		{
			//item.name = "Iridium Ore";
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = TileType<Tiles.IridiumOreTile>();
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
}