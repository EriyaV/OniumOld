﻿using Terraria.ID;
using Terraria.ModLoader;
using OniumMod.Tiles.Crafting;

namespace OniumMod.Items.Crafting
{
	public class ForbiddenTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded workbench.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.Crafting.ForbiddenTable>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}