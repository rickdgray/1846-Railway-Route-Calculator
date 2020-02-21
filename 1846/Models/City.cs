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

        public enum CityName
        {
            Holland,
            PortHuron,
            Sarnia,
            ChicagoConnections,
            SouthBend,
            Detroit,
            Windsor,
            Buffalo,
            Chicago,
            Toledo,
            Erie,
            FortWayne,
            Cleveland,
            Salamanca,
            Binghamton,
            Homewood,
            Pittsburgh,
            Springfield,
            TerreHaute,
            Indianapolis,
            Dayton,
            Columbus,
            Wheeling,
            Cincinnati,
            Cumberland,
            StLouis,
            Centralia,
            Huntington,
            Charleston,
            Louisville,
            Cairo
        }
    }
}
