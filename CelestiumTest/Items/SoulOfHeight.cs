using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Items
{
	public class SoulOfHeight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of Height");
			Tooltip.SetDefault("Essence of creatures from above.");
		}
		public override void SetDefaults()
		{
			item.value = 750000;
			item.rare = 4;
			ItemID.Sets.ItemNoGravity[item.type] = true; //Makes it float
			item.maxStack = 99;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
