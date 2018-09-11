using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Items
{
	public class FryingPan : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frying Pan");
			Tooltip.SetDefault("The OG Zombie apocalypse weapon.");
		}
		public override void SetDefaults()
		{
			item.damage = 48;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 112;
			item.useAnimation = 112;
			item.useStyle = 1;
			item.knockBack = 420;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.SlapHand, 1);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
