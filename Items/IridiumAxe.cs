using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.Items
{
	public class IridiumAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("IridiumAxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is an iridium axe.");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.axe = 200; //CHANGE well obviously a nice bit of it needs to be changed but yeah
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this.mod, "IridiumBarPlaceable", 9);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}