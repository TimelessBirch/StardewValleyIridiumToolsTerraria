using Terraria.ID;
using Terraria.ModLoader;

namespace StardewValleyIridiumTools.Items
{
	public class AncientSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's the remains of an ancient sword. Most of the blade has turned to rust, but the hilt is very finely crafted.");
		}

		public override void SetDefaults()
		{
			item.damage = 75;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
