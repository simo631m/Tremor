using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StickyFlail : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 10;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.rare = 3;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.knockBack = 7.5F;
			item.damage = 22;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("StickyFlailPro");
			item.shootSpeed = 15.9F;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sticky Flail");
			Tooltip.SetDefault("");
		}

	}
}
