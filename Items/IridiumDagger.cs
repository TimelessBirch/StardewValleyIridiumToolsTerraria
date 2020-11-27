using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.Items
{
	public class IridiumDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("IridumShortsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is an iridium dagger.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this.mod, "IridiumBarPlaceable", 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}