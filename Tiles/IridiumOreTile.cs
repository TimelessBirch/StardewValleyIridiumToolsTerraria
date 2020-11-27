using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValleyIridiumTools.Tiles
{
    public class IridiumOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            Main.tileMergeDirt[Type] = true; // Will tile merge with dirt?
            Main.tileLighted[Type] = false; // ???
            Main.tileBlockLight[Type] = false; // Emits Light

            drop = mod.ItemType("IridiumOrePlaceable"); // What item drops after destorying the tile
            //ModTranslation name = CreateMapEntryName();
            //name.SetDefault("Tutorial Ore");
            AddMapEntry(new Color(101, 15, 214)); // Colour of Tile on Map
            minPick = 40; // What power pick minimum is needed to mine this block.
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.75f;
            g = 0.25f;
            b = 0.5f;
        }
    }
}