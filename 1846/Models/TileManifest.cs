using System.Collections.Generic;

namespace _1846.Models
{
    public class TileManifest
    {
        public Dictionary<int, Tile> TileList { get; }

        public TileManifest()
        {
            TileList.Add(5, new Tile(5, Tier.Yellow));
        }
    }
}
