using System.Collections.Generic;

namespace _1846.Models
{
    public class City
    {
        public string Name { get; set; }
        public int Revenue { get; set; }
        public int MeatBonus { get; set; }
        public int SteamBoatBonus { get; set; }
        public int StationMax { get; set; }
        public List<Company> Stations { get; set; }
        public Company ReservedStation { get; set; }
    }

    public enum Company
    {
        BaltimoreAndOhioRailroad,
        IllinoisCentral,
        NYCentral,
        Chesapeake,
        Erie,
        GrandTrunk,
        Pennsylvania,

        MichiganSouthern,
        Big4,

        ChicagoAndWIndiana
    }
}
