using System.Collections.Generic;

namespace _1846.Models
{
    public class Grid
    {
        public Node[,] Nodes { get; } = new Node[11, 11];
        public int Phase { get; set; } = 1;
        public int PlayerCount { get; set; }

        public Grid(int playerCount)
        {
            PlayerCount = playerCount;

            var cities = new Dictionary<City.CityName, City>
            {
                { City.CityName.Holland, new OffboardCity("Holland", 40, false, false, 0, steamBonus: 40) },
                { City.CityName.PortHuron, new City("Port Huron", 20, Company.GrandTrunk) },
                { City.CityName.Sarnia, new OffboardCity("Sarnia", 20, true, false, 20) },
                { City.CityName.ChicagoConnections, new OffboardCity("Chicago Connections", 20, false, true, 50, steamBonus: 20) },
                { City.CityName.SouthBend, new City("South Bend", 20, Company.None) },
                { City.CityName.Detroit, new City("Detroit", 40, Company.MichiganSouthern, stationMax: 2) },
                { City.CityName.Windsor, new OffboardCity("Windsor", 40, true, false, 30) },
                { City.CityName.Buffalo, new OffboardCity("Buffalo", 30, true, false, 30) },
                { City.CityName.Chicago, new City("Chicago", 10, Company.ChicagoAndWIndiana, 30, stationMax: 4) },
                { City.CityName.Toledo, new City("Toledo", 20, Company.None, steamBonus: 20) },
                { City.CityName.Erie, new City("Erie", 10, Company.NYCentral, stationMax: 2) },
                { City.CityName.FortWayne, new City("Fort Wayne", 20, Company.Pennsylvania) },
                { City.CityName.Cleveland, new City("Cleveland", 40, Company.None) },
                { City.CityName.Salamanca, new City("Salamanca", 10, Company.Erie) },
                { City.CityName.Binghamton, new OffboardCity("Binghamton", 20, true, false, 30) },
                { City.CityName.Homewood, new City("Homewood", 10, Company.Pennsylvania) },
                { City.CityName.Pittsburgh, new OffboardCity("Pittsburgh", 30, true, false, 20) },
                { City.CityName.Springfield, new City("Springfield", 20, Company.None) },
                { City.CityName.TerreHaute, new City("Terre Haute", 20, Company.None) },
                { City.CityName.Indianapolis, new City("Indianapolis", 20, Company.Big4) },
                { City.CityName.Dayton, new City("Dayton", 20, Company.None) },
                { City.CityName.Columbus, new City("Columbus", 20, Company.None) },
                { City.CityName.Wheeling, new City("Wheeling", 10, Company.BaltimoreAndOhio, steamBonus: 40) },
                { City.CityName.Cincinnati, new City("Cincinnati", 40, Company.BaltimoreAndOhio) },
                { City.CityName.Cumberland, new OffboardCity("Cumberland", 20, true, false, 30) },
                { City.CityName.StLouis, new OffboardCity("St. Louis", 50, false, true, 20, 30, 20) },
                { City.CityName.Centralia, new City("Centralia", 10, Company.IllinoisCentral, stationMax: 2) },
                { City.CityName.Huntington, new City("Huntington", 20, Company.Chesapeake) },
                { City.CityName.Charleston, new OffboardCity("Charleston", 20, true, false, 20) },
                { City.CityName.Louisville, new OffboardCity("Louisville", 50, false, false, 0) },
                { City.CityName.Cairo, new City("Cairo", 20, Company.IllinoisCentral) }
            };

            Nodes[0, 4] = new Node(4, 0, tier: Tier.Gray);//gray turn tile
            Nodes[1, 1] = new Node(1, 1, tier: Tier.Red, city: cities[City.CityName.Holland]);
            Nodes[1, 2] = new Node(2, 1, tier: Tier.MCReserved);
            Nodes[1, 3] = new Node(3, 1, tier: Tier.MCReserved);
            Nodes[1, 4] = new Node(4, 1);
            Nodes[1, 5] = new Node(5, 1, city: cities[City.CityName.PortHuron]);
            Nodes[1, 6] = new Node(6, 1, tier: Tier.Red, city: cities[City.CityName.Sarnia]);
            Nodes[2, 0] = new Node(0, 2, tier: Tier.Red, city: cities[City.CityName.ChicagoConnections]);
            Nodes[2, 1] = new Node(1, 2, tier: Tier.Gray);//gray turn tile
            Nodes[2, 2] = new Node(2, 2, city: cities[City.CityName.SouthBend]);
            Nodes[2, 3] = new Node(3, 2);
            Nodes[2, 4] = new Node(4, 2);
            Nodes[2, 5] = new Node(5, 2, tier: Tier.Yellow, city: cities[City.CityName.Detroit], isZed: true, constructionPenalty: 40);
            Nodes[2, 6] = new Node(6, 2, tier: Tier.Red, city: cities[City.CityName.Windsor]);
            Nodes[2, 8] = new Node(8, 2, tier: Tier.Red, city: cities[City.CityName.Buffalo]);//with 2, 9
            Nodes[3, 1] = new Node(1, 3, tier: Tier.Yellow, city: cities[City.CityName.Chicago]);
            Nodes[3, 2] = new Node(2, 3);
            Nodes[3, 3] = new Node(3, 3);
            Nodes[3, 4] = new Node(4, 3);
            Nodes[3, 5] = new Node(5, 3, city: cities[City.CityName.Toledo]);
            Nodes[3, 7] = new Node(7, 3);
            Nodes[3, 8] = new Node(8, 3, tier: Tier.Yellow, city: cities[City.CityName.Erie]);
            Nodes[3, 9] = new Node(9, 3, tier: Tier.Red, city: cities[City.CityName.Buffalo]);//with 1, 8
            Nodes[4, 1] = new Node(1, 4, tier: Tier.FreeForIC);
            Nodes[4, 2] = new Node(2, 4);
            Nodes[4, 3] = new Node(3, 4);
            Nodes[4, 4] = new Node(4, 4, city: cities[City.CityName.FortWayne]);
            Nodes[4, 5] = new Node(5, 4);
            Nodes[4, 6] = new Node(6, 4);
            Nodes[4, 7] = new Node(7, 4, city: cities[City.CityName.Cleveland], isZed: true);
            Nodes[4, 8] = new Node(8, 4);
            Nodes[4, 9] = new Node(9, 4, tier: Tier.Gray, city: cities[City.CityName.Salamanca]);
            Nodes[4, 10] = new Node(10, 4, tier: Tier.Red, city: cities[City.CityName.Binghamton]);
            Nodes[5, 1] = new Node(1, 5);
            Nodes[5, 2] = new Node(2, 5, tier: Tier.FreeForIC);
            Nodes[5, 3] = new Node(3, 5);
            Nodes[5, 4] = new Node(4, 5);
            Nodes[5, 5] = new Node(5, 5);
            Nodes[5, 6] = new Node(6, 5, tier: Tier.OandIReserved);
            Nodes[5, 7] = new Node(7, 5, tier: Tier.OandIReserved);
            Nodes[5, 8] = new Node(8, 5, tier: Tier.TunnelRequired, constructionPenalty: 40);
            Nodes[5, 9] = new Node(9, 5, tier: Tier.Gray, city: cities[City.CityName.Homewood]);
            Nodes[5, 10] = new Node(10, 5, tier: Tier.Red, city: cities[City.CityName.Pittsburgh]);//with 5, 10
            Nodes[6, 1] = new Node(1, 6, city: cities[City.CityName.Springfield]);
            Nodes[6, 2] = new Node(2, 6, tier: Tier.FreeForIC);
            Nodes[6, 3] = new Node(3, 6, city: cities[City.CityName.TerreHaute]);
            Nodes[6, 4] = new Node(4, 6, city: cities[City.CityName.Indianapolis]);
            Nodes[6, 5] = new Node(5, 6);
            Nodes[6, 6] = new Node(6, 6, city: cities[City.CityName.Dayton]);
            Nodes[6, 7] = new Node(7, 6, city: cities[City.CityName.Columbus]);
            Nodes[6, 8] = new Node(8, 6, tier: Tier.TunnelRequired, constructionPenalty: 40);
            Nodes[6, 9] = new Node(9, 6, tier: Tier.Yellow, city: cities[City.CityName.Wheeling]);
            Nodes[6, 10] = new Node(10, 6, tier: Tier.Red, city: cities[City.CityName.Pittsburgh]);//with 4, 10
            Nodes[7, 1] = new Node(1, 7);
            Nodes[7, 2] = new Node(2, 7);
            Nodes[7, 3] = new Node(3, 7, tier: Tier.FreeForIC);
            Nodes[7, 4] = new Node(4, 7);
            Nodes[7, 5] = new Node(5, 7);
            Nodes[7, 6] = new Node(6, 7, city: cities[City.CityName.Cincinnati], isZed: true);
            Nodes[7, 7] = new Node(7, 7, tier: Tier.TunnelRequired, constructionPenalty: 60);
            Nodes[7, 8] = new Node(8, 7, tier: Tier.TunnelRequired, constructionPenalty: 40);
            Nodes[7, 10] = new Node(10, 7, tier: Tier.Red, city: cities[City.CityName.Cumberland]);
            Nodes[8, 1] = new Node(1, 8, tier: Tier.Red, city: cities[City.CityName.StLouis]);//with 8, 2
            Nodes[8, 2] = new Node(2, 8);
            Nodes[8, 3] = new Node(3, 8, tier: Tier.Gray, city: cities[City.CityName.Centralia]);
            Nodes[8, 4] = new Node(4, 8);
            Nodes[8, 5] = new Node(5, 8);
            Nodes[8, 6] = new Node(6, 8);
            Nodes[8, 8] = new Node(8, 8, tier: Tier.Gray, city: cities[City.CityName.Huntington]);
            Nodes[8, 9] = new Node(9, 8, tier: Tier.Red, city: cities[City.CityName.Charleston]);
            Nodes[9, 2] = new Node(2, 9, tier: Tier.Red, city: cities[City.CityName.StLouis]);//with 7, 1
            Nodes[9, 3] = new Node(3, 9, tier: Tier.FreeForIC);
            Nodes[9, 4] = new Node(4, 9);
            Nodes[9, 5] = new Node(5, 9);
            Nodes[9, 6] = new Node(6, 9, tier: Tier.Red, city: cities[City.CityName.Louisville]);
            Nodes[10, 3] = new Node(3, 10, tier: Tier.Gray, city: cities[City.CityName.Cairo]);
        }

        public override string ToString()
        {
            var result = "";
            foreach(var node in Nodes)
            {
                if (node != null)
                    result = $"{result}{node.ToString()}\n";
            }
            return result;
        }
    }
}
