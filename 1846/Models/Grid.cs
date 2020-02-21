using System;
using System.Collections.Generic;
using System.Linq;

namespace _1846.Models
{
    public class Grid
    {
        public Node[,] Nodes { get; } = new Node[11, 11];

        public Grid()
        {


            Nodes[0, 4] = new Node(4, 0, tier: Tier.Gray);//gray turn tile
            Nodes[1, 1] = new Node(1, 1, tier: Tier.Red);//holland
            Nodes[1, 2] = new Node(2, 1);
            Nodes[1, 3] = new Node(3, 1);
            Nodes[1, 4] = new Node(4, 1);
            Nodes[1, 5] = new Node(5, 1);//port huron
            Nodes[1, 6] = new Node(6, 1);//sarnia
            Nodes[2, 0] = new Node(0, 2);//chicago connections
            Nodes[2, 1] = new Node(1, 2);//gray turn tile
            Nodes[2, 2] = new Node(2, 2);//south bend
            Nodes[2, 3] = new Node(3, 2);
            Nodes[2, 4] = new Node(4, 2);
            Nodes[2, 5] = new Node(5, 2);//detroit
            Nodes[2, 6] = new Node(6, 2);//windsor
            Nodes[2, 8] = new Node(8, 2);//buffalo with 2, 9
            Nodes[3, 1] = new Node(1, 3);//chicago
            Nodes[3, 2] = new Node(2, 3);
            Nodes[3, 3] = new Node(3, 3);
            Nodes[3, 4] = new Node(4, 3);
            Nodes[3, 5] = new Node(5, 3);//toledo
            Nodes[3, 7] = new Node(7, 3);
            Nodes[3, 8] = new Node(8, 3);//erie
            Nodes[3, 9] = new Node(9, 3);//buffalo with 1, 8
            Nodes[4, 1] = new Node(1, 4);
            Nodes[4, 2] = new Node(2, 4);
            Nodes[4, 3] = new Node(3, 4);
            Nodes[4, 4] = new Node(4, 4);//fort wayne
            Nodes[4, 5] = new Node(5, 4);
            Nodes[4, 6] = new Node(6, 4);
            Nodes[4, 7] = new Node(7, 4);//cleveland
            Nodes[4, 8] = new Node(8, 4);
            Nodes[4, 9] = new Node(9, 4);//salamanca
            Nodes[4, 10] = new Node(10, 4);//binghamton
            Nodes[5, 1] = new Node(1, 5);
            Nodes[5, 2] = new Node(2, 5);
            Nodes[5, 3] = new Node(3, 5);
            Nodes[5, 4] = new Node(4, 5);
            Nodes[5, 5] = new Node(5, 5);
            Nodes[5, 6] = new Node(6, 5);
            Nodes[5, 7] = new Node(7, 5);
            Nodes[5, 8] = new Node(8, 5);
            Nodes[5, 9] = new Node(9, 5);//homewood
            Nodes[5, 10] = new Node(10, 5);//pittsburgh with 5, 10
            Nodes[6, 1] = new Node(1, 6);//springfield
            Nodes[6, 2] = new Node(2, 6);
            Nodes[6, 3] = new Node(3, 6);//terre haute
            Nodes[6, 4] = new Node(4, 6);//indianapolis
            Nodes[6, 5] = new Node(5, 6);
            Nodes[6, 6] = new Node(6, 6);//dayton
            Nodes[6, 7] = new Node(7, 6);//columbus
            Nodes[6, 8] = new Node(8, 6);
            Nodes[6, 9] = new Node(9, 6);//wheeling
            Nodes[6, 10] = new Node(10, 6);//pittsburgh with 4, 10
            Nodes[7, 1] = new Node(1, 7);
            Nodes[7, 2] = new Node(2, 7);
            Nodes[7, 3] = new Node(3, 7);
            Nodes[7, 4] = new Node(4, 7);
            Nodes[7, 5] = new Node(5, 7);
            Nodes[7, 6] = new Node(6, 7);//cincinnati
            Nodes[7, 7] = new Node(7, 7);
            Nodes[7, 8] = new Node(8, 7);
            Nodes[7, 9] = new Node(9, 7);
            Nodes[7, 10] = new Node(10, 7);//cumberland
            Nodes[8, 1] = new Node(1, 8);//st. louis with 8, 2
            Nodes[8, 2] = new Node(2, 8);
            Nodes[8, 3] = new Node(3, 8);//centralia
            Nodes[8, 4] = new Node(4, 8);
            Nodes[8, 5] = new Node(5, 8);
            Nodes[8, 6] = new Node(6, 8);
            Nodes[8, 8] = new Node(8, 8);//huntington
            Nodes[8, 9] = new Node(9, 8);//charleston
            Nodes[9, 2] = new Node(2, 9);//st. louis with 7, 1
            Nodes[9, 3] = new Node(3, 9);
            Nodes[9, 4] = new Node(4, 9);
            Nodes[9, 5] = new Node(5, 9);
            Nodes[9, 6] = new Node(6, 9);//louisville
            Nodes[10, 3] = new Node(3, 10);//cairo

            var cities = new List<City>
            {
                new OffboardCity("Holland", 40, false, false, 0, steamBonus: 40),
                new City("Port Huron", 20, Company.GrandTrunk),
                new OffboardCity("Sarnia", 20, true, false, 20),
                new OffboardCity("Chicago Connections", 20, false, true, 50, steamBonus: 20),
                new City("South Bend", 20, Company.None),
                new City("Detroit", 40, Company.MichiganSouthern, stationMax: 2),
                new OffboardCity("Windsor", 40, true, false, 30),
                new City("Chicago", 10, Company.ChicagoAndWIndiana, 30, stationMax: 4),
                new City("Toledo", 20, Company.None, steamBonus: 20),
                new City("Erie", 10, Company.NYCentral, stationMax: 2),
                new OffboardCity("Buffalo", 30, true, false, 30),
                new City("Fort Wayne", 20, Company.Pennsylvania),
                new City("Cleveland", 40, Company.None),
                new City("Salamanca", 10, Company.Erie),
                new OffboardCity("Binghamton", 20, true, false, 30),
                new City("Homewood", 10, Company.Pennsylvania),
                new OffboardCity("Pittsburgh", 30, true, false, 20),
                new City("Springfield", 20, Company.None),
                new City("Terre Haute", 20, Company.None),
                new City("Indianapolis", 20, Company.Big4),
                new City("Dayton", 20, Company.None),
                new City("Columbus", 20, Company.None),
                new City("Wheeling", 10, Company.BaltimoreAndOhio, steamBonus: 40),
                new City("Cincinnati", 40, Company.BaltimoreAndOhio),
                new OffboardCity("Cumberland", 20, true, false, 30),
                new OffboardCity("St. Louis", 50, false, true, 20, 30, 20),
                new City("Centralia", 10, Company.IllinoisCentral, stationMax: 2),
                new City("Huntington", 20, Company.Chesapeake),
                new OffboardCity("Charleston", 20, true, false, 20),
                new OffboardCity("Louisville", 50, false, false, 0),
                new City("Cairo", 20, Company.IllinoisCentral)
            };

            //build roads
            for (int row = 0; row < Nodes.GetLength(0); row++)
            {
                for (int column = 0; column < Nodes.GetLength(1); column++)
                {
                    //find real tile
                    var currentNode = Nodes[row, column];
                    if (currentNode != null)
                    {
                        //check around tile clockwise from top left
                        foreach (var adjacentNodeCoords in adjacentNodesCoords)
                        {
                            //make sure coords are not off map
                            if (row + adjacentNodeCoords.Item1 >= 0 &&
                                row + adjacentNodeCoords.Item1 <= 9 &&
                                column + adjacentNodeCoords.Item2 >= 0 &&
                                column + adjacentNodeCoords.Item2 <= 19)
                            {
                                //make sure coords lead to real tile
                                var adjacentNode = Nodes[row + adjacentNodeCoords.Item1, column + adjacentNodeCoords.Item2];
                                if (adjacentNode != null)
                                {
                                    //check if road already exists
                                    var roadExists = currentNode.Neighbors
                                        .FirstOrDefault(r => r.WestDestination == adjacentNode || r.EastDestination == adjacentNode) != null;

                                    if (!roadExists)
                                    {
                                        var newRoad = new Road();
                                        //the node with the greater column number is more easterly
                                        if (currentNode.Q > adjacentNode.Q)
                                        {
                                            newRoad.EastDestination = currentNode;
                                            newRoad.WestDestination = adjacentNode;
                                        }
                                        else
                                        {
                                            newRoad.EastDestination = adjacentNode;
                                            newRoad.WestDestination = currentNode;
                                        }

                                        currentNode.Neighbors.Add(newRoad);
                                        adjacentNode.Neighbors.Add(newRoad);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //build offboard roads
            var road = new Road
            {
                WestDestination = offboardNodes[0],
                EastDestination = Nodes[2, 4],
                WestIsBuilt = true
            };
            offboardNodes[0].Neighbors.Add(road);
            Nodes[2, 4].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[1],
                EastDestination = Nodes[0, 8],
                WestIsBuilt = true
            };
            offboardNodes[1].Neighbors.Add(road);
            Nodes[0, 8].Neighbors.Add(road);

            road = new Tunnel
            {
                WestDestination = offboardNodes[2],
                EastDestination = Nodes[0, 14],
                EastIsBuilt = true,
                TunnelPenalty = 40
            };
            offboardNodes[2].Neighbors.Add(road);
            Nodes[0, 14].Neighbors.Add(road);

            road = new Tunnel
            {
                WestDestination = offboardNodes[3],
                EastDestination = Nodes[1, 13],
                EastIsBuilt = true,
                TunnelPenalty = 60
            };
            offboardNodes[3].Neighbors.Add(road);
            Nodes[1, 13].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[4],
                EastDestination = Nodes[2, 18],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[4].Neighbors.Add(road);
            Nodes[2, 18].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[4],
                EastDestination = Nodes[2, 18],
                EastIsBuilt = true
            };
            offboardNodes[4].Neighbors.Add(road);
            Nodes[2, 18].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[5],
                EastDestination = Nodes[3, 19],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[5].Neighbors.Add(road);
            Nodes[3, 19].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[6],
                EastDestination = Nodes[4, 18],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[6].Neighbors.Add(road);
            Nodes[4, 18].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[6],
                EastDestination = Nodes[4, 18],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[6].Neighbors.Add(road);
            Nodes[4, 18].Neighbors.Add(road);

            road = new Tunnel
            {
                WestDestination = offboardNodes[6],
                EastDestination = Nodes[5, 17],
                EastIsBuilt = true,
                TunnelPenalty = 20
            };
            offboardNodes[6].Neighbors.Add(road);
            Nodes[5, 17].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[7],
                EastDestination = Nodes[5, 17],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[7].Neighbors.Add(road);
            Nodes[5, 17].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[8],
                EastDestination = Nodes[7, 13],
                EastIsBuilt = true,
                WestIsBuilt = true
            };
            offboardNodes[8].Neighbors.Add(road);
            Nodes[7, 13].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[9],
                EastDestination = Nodes[7, 7],
                EastIsBuilt = true
            };
            offboardNodes[9].Neighbors.Add(road);
            Nodes[7, 7].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[9],
                EastDestination = Nodes[7, 9],
                WestIsBuilt = true
            };
            offboardNodes[9].Neighbors.Add(road);
            Nodes[7, 9].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[10],
                EastDestination = Nodes[7, 1],
                WestIsBuilt = true
            };
            offboardNodes[10].Neighbors.Add(road);
            Nodes[7, 1].Neighbors.Add(road);

            road = new Road
            {
                WestDestination = offboardNodes[10],
                EastDestination = Nodes[6, 0],
                WestIsBuilt = true
            };
            offboardNodes[10].Neighbors.Add(road);
            Nodes[6, 0].Neighbors.Add(road);

            //build bridges
            ((Bridge)Nodes[5, 17].Neighbors.FirstOrDefault(r => r.WestDestination == Nodes[4, 16])).BridgePenalty = 40;
            ((Bridge)Nodes[5, 17].Neighbors.FirstOrDefault(r => r.WestDestination == Nodes[5, 15])).BridgePenalty = 20;
            ((Bridge)Nodes[6, 10].Neighbors.FirstOrDefault(r => r.WestDestination == Nodes[7, 9])).BridgePenalty = 20;
            ((Bridge)Nodes[8, 4].Neighbors.FirstOrDefault(r => r.WestDestination == Nodes[8, 2])).BridgePenalty = 40;

            //build last tunnel
            ((Tunnel)Nodes[4, 18].Neighbors.FirstOrDefault(r => r.WestDestination == Nodes[3, 17])).TunnelPenalty = 40;
        }
    }
}
