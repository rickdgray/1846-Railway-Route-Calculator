namespace _1846.Models
{
    public class OffboardCity : City
    {
        public OffboardCity(
            string name,
            int revenue,
            bool isEast,
            bool isWest,
            int eastWestBonus,
            int meatBonus = 0,
            int steamBonus = 0)
            : base(name, revenue,
                Company.None,
                meatBonus,
                steamBonus, 0, null)
        {
            IsEast = isEast;
            IsWest = isWest;
            EastWestBonus = eastWestBonus;
        }

        public bool IsEast { get; }
        public bool IsWest { get; }
        public int EastWestBonus { get; }
    }
}
