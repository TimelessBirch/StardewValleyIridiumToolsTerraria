//using StardewValleyIridiumTools.Tiles;
//using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.Items
{
	public class IridiumSlingshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("IridiumSlingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is an iridium slingshot.");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.noMelee = true;
			item.width = 20;
			item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 6.6f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this.mod, "IridiumBarPlaceable", 7);
			recipe.AddIngredient(ItemID.WhiteString, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}