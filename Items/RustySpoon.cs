using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.Items
{
	public class RustySpoon : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("IridiumSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A plain old spoon, probably ten years old. Not very interesting.");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}