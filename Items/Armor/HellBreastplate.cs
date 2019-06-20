using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Theramium.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HellBreastPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("HellBreastplate");
			Tooltip.SetDefault("U can do very gud things
				+ "\nImmunity to 'On Fire!'"
				+ "\n+20 max mana and +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 20;
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe "HellstoneBar", 60);
			recipe.AddTile(TileID, "77");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}