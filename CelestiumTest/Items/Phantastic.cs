using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Items

{

	public class Phantastic : ModItem

	{

		public override void SetStaticDefaults()

		{

			Tooltip.SetDefault("Wow, this is a fantastic weapon!");

		}



		public override void SetDefaults()

		{

			item.damage = 588;

			item.ranged = true;

			item.width = 34;

			item.height = 74;

			item.useTime = 3;

			item.useAnimation = 3;

			item.useStyle = 5;

			item.noMelee = true; //so the item's animation doesn't do damage

			item.knockBack = 2;

			item.value = 10000;

			item.rare = 10;

			item.UseSound = SoundID.Item11;

			item.autoReuse = true;

			item.shoot = 5; //idk why but all the guns in the vanilla source have this

			item.shootSpeed = 86f;

			item.useAmmo = AmmoID.Arrow;

		}



		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 99);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

	}}	}