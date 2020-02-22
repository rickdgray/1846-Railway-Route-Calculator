namespace _1846.Models
{
    public class OffboardCity : City
    {
        public bool IsEast { get; }
        public bool IsWest { get; }
        public int EastWestBonus { get; }

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

        public override string ToString()
        {
            return $"Offboard {base.ToString()}, Locale: {(IsEast ? "Eastern" : IsWest ? "Western" : "Central")}{(IsEast || IsWest ? $", East to West Bonus: {EastWestBonus.ToString()}" : string.Empty)}";
        }
    }
}
