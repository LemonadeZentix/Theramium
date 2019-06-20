using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Theramium.Items;

namespace Theramium
{
    public class Theramium : Mod
    {
        public override void AddRecipes()
        {
            ModRecipe diamondToSapphire = new ModRecipe(this);
            diamondToSapphire.AddIngredient(ItemID.Diamond, 1);
            diamondToSapphire.AddTile(TileID.Anvils);
            diamondToSapphire.SetResult(ItemID.Sapphire, 1);
            diamondToSapphire.AddRecipe();

            ModRecipe sapphireToDiamond = new ModRecipe(this);
            sapphireToDiamond.AddIngredient(ItemID.Sapphire, 1);
            sapphireToDiamond.AddTile(TileID.Anvils);
            sapphireToDiamond.SetResult(ItemID.Diamond, 1);
            sapphireToDiamond.AddRecipe();

            ModRecipe emeraldToDiamond = new ModRecipe(this);
            emeraldToDiamond.AddIngredient(ItemID.Emerald, 1);
            emeraldToDiamond.AddTile(TileID.Anvils);
            emeraldToDiamond.SetResult(ItemID.Diamond, 1);
            emeraldToDiamond.AddRecipe();

            ModRecipe diamondToEmerald = new ModRecipe(this);
            diamondToEmerald.AddIngredient(ItemID.Diamond, 1);
            diamondToEmerald.AddTile(TileID.Anvils);
            diamondToEmerald.SetResult(ItemID.Emerald, 1);
            diamondToEmerald.AddRecipe();

            ModRecipe rubyToDiamond = new ModRecipe(this);
            rubyToDiamond.AddIngredient(ItemID.Ruby, 1);
            rubyToDiamond.AddTile(TileID.Anvils);
            rubyToDiamond.SetResult(ItemID.Diamond, 1);
            rubyToDiamond.AddRecipe();

            ModRecipe diamondToRuby = new ModRecipe(this);
            diamondToRuby.AddIngredient(ItemID.Diamond, 1);
            diamondToRuby.AddTile(TileID.Anvils);
            diamondToRuby.SetResult(ItemID.Ruby, 1);
            diamondToRuby.AddRecipe();

            ModRecipe amethystToDiamond = new ModRecipe(this);
            amethystToDiamond.AddIngredient(ItemID.Amethyst, 1);
            amethystToDiamond.AddTile(TileID.Anvils);
            amethystToDiamond.SetResult(ItemID.Diamond, 1);
            amethystToDiamond.AddRecipe();

            ModRecipe diamondToAmethyst = new ModRecipe(this);
            diamondToAmethyst.AddIngredient(ItemID.Diamond, 1);
            diamondToAmethyst.AddTile(TileID.Anvils);
            diamondToAmethyst.SetResult(ItemID.Amethyst, 1);
            diamondToAmethyst.AddRecipe();

            ModRecipe topazToDiamond = new ModRecipe(this);
            topazToDiamond.AddIngredient(ItemID.Topaz, 1);
            topazToDiamond.AddTile(TileID.Anvils);
            topazToDiamond.SetResult(ItemID.Diamond, 1);
            topazToDiamond.AddRecipe();

            ModRecipe diamondToTopaz = new ModRecipe(this);
            diamondToTopaz.AddIngredient(ItemID.Diamond, 1);
            diamondToTopaz.AddTile(TileID.Anvils);
            diamondToTopaz.SetResult(ItemID.Topaz, 1);
            diamondToTopaz.AddRecipe();

            ModRecipe amberToDiamond = new ModRecipe(this);
            amberToDiamond.AddIngredient(ItemID.Amber, 1);
            amberToDiamond.AddTile(TileID.Anvils);
            amberToDiamond.SetResult(ItemID.Diamond, 1);
            amberToDiamond.AddRecipe();

            ModRecipe diamondToAmber = new ModRecipe(this);
            diamondToAmber.AddIngredient(ItemID.Diamond, 1);
            diamondToAmber.AddTile(TileID.Anvils);
            diamondToAmber.SetResult(ItemID.Amber, 1);
            diamondToAmber.AddRecipe();

            ModRecipe sapphireToEmerald = new ModRecipe(this);
            sapphireToEmerald.AddIngredient(ItemID.Sapphire, 1);
            sapphireToEmerald.AddTile(TileID.Anvils);
            sapphireToEmerald.SetResult(ItemID.Emerald, 1);
            sapphireToEmerald.AddRecipe();

            ModRecipe emeraldToSapphire = new ModRecipe(this);
            emeraldToSapphire.AddIngredient(ItemID.Emerald, 1);
            emeraldToSapphire.AddTile(TileID.Anvils);
            emeraldToSapphire.SetResult(ItemID.Sapphire, 1);
            emeraldToSapphire.AddRecipe();
        }
        public Theramium()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true

            };
        }
    }
}

