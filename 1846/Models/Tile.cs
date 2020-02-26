namespace _1846.Models
{
    public class Tile
    {
        public int Id { get; }
        public Tier Tier { get; }

        public Tile(int id, Tier tier)
        {
            Id = id;
            Tier = tier;
        }
    }
}
