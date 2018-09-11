using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Items
{
	public class SupremeTeam : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supreme Team");
			Tooltip.SetDefault("This is a THE Supreme Team's Sword.");
		}
		public override void SetDefaults()
		{
			item.damage = 696969;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 1;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item57;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SupremeGhost");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilOre, 65);
			recipe.AddIngredient(ItemID.Mushroom, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
