using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BleachYAAM.Items
{
	public class BasicZanpakuto : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BleachYAAM.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 80;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 10;
			Item.value = 3;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}