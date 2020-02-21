using System.Collections.Generic;

namespace _1846.Models
{
    public class City
    {
        public string Name { get; }
        public Company ReservedStation { get; }

        public int Revenue { get; set; }
        public int MeatBonus { get; set; }
        public int SteamBonus { get; set; }
        public int StationMax { get; set; }
        public List<Company> Stations { get; set; }

        public City(
            string name,
            int revenue,
            Company reservedStation,
            int meatBonus = 0,
            int steamBonus = 0,
            int stationMax = 1,
            List<Company> stations = null)
        {
            Name = name;
            Revenue = revenue;
            ReservedStation = reservedStation;
            
            MeatBonus = meatBonus;
            SteamBonus = steamBonus;
            StationMax = stationMax;

            if (stations == null)
                Stations = new List<Company>();
            else
                Stations = stations;
        }
    }
}
