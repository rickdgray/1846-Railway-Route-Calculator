using System.Collections.Generic;

namespace _1846.Models
{
    public class TileManifest
    {
        public Dictionary<int, Tile> TileList { get; }

        public TileManifest()
        {
            TileList.Add(5, new Tile(5, Tier.Yellow));
            TileList.Add(6, new Tile(6, Tier.Yellow));
            TileList.Add(7, new Tile(7, Tier.Yellow));
            TileList.Add(8, new Tile(8, Tier.Yellow));
            TileList.Add(9, new Tile(9, Tier.Yellow));
            TileList.Add(57, new Tile(57, Tier.Yellow));
            TileList.Add(291, new Tile(291, Tier.Yellow));
            TileList.Add(292, new Tile(292, Tier.Yellow));
            TileList.Add(293, new Tile(293, Tier.Yellow));
            TileList.Add(14, new Tile(14, Tier.Green));
            TileList.Add(15, new Tile(15, Tier.Green));
            TileList.Add(16, new Tile(16, Tier.Green));
            TileList.Add(17, new Tile(17, Tier.Green));
            TileList.Add(18, new Tile(18, Tier.Green));
            TileList.Add(19, new Tile(19, Tier.Green));
            TileList.Add(20, new Tile(20, Tier.Green));
            TileList.Add(21, new Tile(21, Tier.Green));
            TileList.Add(22, new Tile(22, Tier.Green));
            TileList.Add(23, new Tile(23, Tier.Green));
            TileList.Add(24, new Tile(24, Tier.Green));
            TileList.Add(25, new Tile(25, Tier.Green));
            TileList.Add(26, new Tile(26, Tier.Green));
            TileList.Add(27, new Tile(27, Tier.Green));
            TileList.Add(28, new Tile(28, Tier.Green));
            TileList.Add(29, new Tile(29, Tier.Green));
            TileList.Add(30, new Tile(30, Tier.Green));
            TileList.Add(31, new Tile(31, Tier.Green));
            TileList.Add(298, new Tile(298, Tier.Green));
            TileList.Add(294, new Tile(294, Tier.Green));
            TileList.Add(295, new Tile(295, Tier.Green));
            TileList.Add(296, new Tile(296, Tier.Green));
            TileList.Add(619, new Tile(619, Tier.Green));
            TileList.Add(39, new Tile(39, Tier.Brown));
            TileList.Add(40, new Tile(40, Tier.Brown));
            TileList.Add(41, new Tile(41, Tier.Brown));
            TileList.Add(42, new Tile(42, Tier.Brown));
            TileList.Add(43, new Tile(43, Tier.Brown));
            TileList.Add(44, new Tile(44, Tier.Brown));
            TileList.Add(45, new Tile(45, Tier.Brown));
            TileList.Add(46, new Tile(46, Tier.Brown));
            TileList.Add(47, new Tile(47, Tier.Brown));
            TileList.Add(70, new Tile(70, Tier.Brown));
            TileList.Add(299, new Tile(299, Tier.Brown));
            TileList.Add(297, new Tile(297, Tier.Brown));
            TileList.Add(611, new Tile(611, Tier.Brown));
            TileList.Add(51, new Tile(51, Tier.Gray));
            TileList.Add(300, new Tile(300, Tier.Gray));
            TileList.Add(290, new Tile(290, Tier.Gray));
        }
    }
}
