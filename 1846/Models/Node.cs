using System;
using System.Collections.Generic;
using System.Linq;

namespace _1846.Models
{
    public class Node
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public List<Road> Neighbors { get; set; }
        public City City { get; set; }
        public bool IsZed { get; set; }
        public int Tier { get; set; }
        public int BridgePenalty { get; set; }
        public int TunnelPenalty { get; set; }
        public bool IsMichiganCentralReserved { get; set; }
        public bool IsOhioAndIndianaReserved { get; set; }
        public bool IsGovSubsidizedForIllinoisCentral { get; set; }

        public static Node[,] GetNodes()
        {
            var nodeCoords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(0, 8),
                new Tuple<int, int>(0, 10),
                new Tuple<int, int>(0, 12),
                new Tuple<int, int>(0, 14),
                new Tuple<int, int>(1, 7),
                new Tuple<int, int>(1, 9),
                new Tuple<int, int>(1, 11),
                new Tuple<int, int>(1, 13),
                new Tuple<int, int>(2, 4),
                new Tuple<int, int>(2, 6),
                new Tuple<int, int>(2, 8),
                new Tuple<int, int>(2, 10),
                new Tuple<int, int>(2, 12),
                new Tuple<int, int>(2, 16),
                new Tuple<int, int>(2, 18),
                new Tuple<int, int>(3, 3),
                new Tuple<int, int>(3, 5),
                new Tuple<int, int>(3, 7),
                new Tuple<int, int>(3, 9),
                new Tuple<int, int>(3, 11),
                new Tuple<int, int>(3, 13),
                new Tuple<int, int>(3, 15),
                new Tuple<int, int>(3, 17),
                new Tuple<int, int>(3, 19),
                new Tuple<int, int>(4, 2),
                new Tuple<int, int>(4, 4),
                new Tuple<int, int>(4, 6),
                new Tuple<int, int>(4, 8),
                new Tuple<int, int>(4, 10),
                new Tuple<int, int>(4, 12),
                new Tuple<int, int>(4, 14),
                new Tuple<int, int>(4, 16),
                new Tuple<int, int>(4, 18),
                new Tuple<int, int>(5, 1),
                new Tuple<int, int>(5, 3),
                new Tuple<int, int>(5, 5),
                new Tuple<int, int>(5, 7),
                new Tuple<int, int>(5, 9),
                new Tuple<int, int>(5, 11),
                new Tuple<int, int>(5, 13),
                new Tuple<int, int>(5, 15),
                new Tuple<int, int>(5, 17),
                new Tuple<int, int>(6, 0),
                new Tuple<int, int>(6, 2),
                new Tuple<int, int>(6, 4),
                new Tuple<int, int>(6, 6),
                new Tuple<int, int>(6, 8),
                new Tuple<int, int>(6, 10),
                new Tuple<int, int>(6, 12),
                new Tuple<int, int>(6, 14),
                new Tuple<int, int>(7, 1),
                new Tuple<int, int>(7, 3),
                new Tuple<int, int>(7, 5),
                new Tuple<int, int>(7, 7),
                new Tuple<int, int>(7, 9),
                new Tuple<int, int>(7, 13),
                new Tuple<int, int>(8, 2),
                new Tuple<int, int>(8, 4),
                new Tuple<int, int>(8, 6),
                new Tuple<int, int>(9, 1)
            };

            var adjacentNodesCoords = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(-1, -1),
                new Tuple<int, int>(-1, 1),
                new Tuple<int, int>(0, 2),
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(1, -1),
                new Tuple<int, int>(0, -2)
            };

            //build tiles
            var nodes = new Node[10, 20];
            foreach (var coord in nodeCoords)
            {
                nodes[coord.Item1, coord.Item2] = new Node
                {
                    Row = coord.Item1,
                    Column = coord.Item2,
                    Neighbors = new List<Road>()
                };
            }

            //build offboard cities
            var offboardCities = new List<OffboardCity>
            {
                new OffboardCity
                {
                    Name = "Chicago Connections",
                    Revenue = 20,
                    IsWest = true,
                    EastWestBonus = 50,
                    SteamBoatBonus = 20,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Holland",
                    Revenue = 40,
                    SteamBoatBonus = 40,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Sarnia",
                    Revenue = 30,
                    IsEast = true,
                    EastWestBonus = 20,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Windsor",
                    Revenue = 40,
                    IsEast = true,
                    EastWestBonus = 30,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Buffalo",
                    Revenue = 30,
                    IsEast = true,
                    EastWestBonus = 30,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Binghamton",
                    Revenue = 20,
                    IsEast = true,
                    EastWestBonus = 30,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Pittsburgh",
                    Revenue = 30,
                    IsEast = true,
                    EastWestBonus = 20,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Cumberland",
                    Revenue = 20,
                    IsEast = true,
                    EastWestBonus = 30,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Charleston",
                    Revenue = 20,
                    IsEast = true,
                    EastWestBonus = 20,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "Louisville",
                    Revenue = 50,
                    StationMax = 0
                },
                new OffboardCity
                {
                    Name = "St. Louis",
                    Revenue = 50,
                    IsWest = true,
                    EastWestBonus = 20,
                    SteamBoatBonus = 20,
                    MeatBonus = 30,
                    StationMax = 0
                }
            };

            //build roads
            for (int row = 0; row < nodes.GetLength(0); row++)
            {
                for (int column = 0; column < nodes.GetLength(1); column++)
                {
                    //find real tile
                    var currentNode = nodes[row, column];
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
                                var adjacentNode = nodes[row + adjacentNodeCoords.Item1, column + adjacentNodeCoords.Item2];
                                if (adjacentNode != null)
                                {
                                    //check if road already exists
                                    var roadExists = currentNode.Neighbors
                                        .FirstOrDefault(r => r.WestDestination == adjacentNode || r.EastDestination == adjacentNode) != null;

                                    if (!roadExists)
                                    {
                                        var newRoad = new Road();
                                        //the node with the greater column number is more easterly
                                        if (currentNode.Column > adjacentNode.Column)
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

            //build bridges
            ((Bridge)nodes[5, 17].Neighbors.FirstOrDefault(r => r.WestDestination == nodes[4, 16])).BridgePenalty = 40;
            ((Bridge)nodes[5, 17].Neighbors.FirstOrDefault(r => r.WestDestination == nodes[5, 15])).BridgePenalty = 20;
            ((Bridge)nodes[6, 10].Neighbors.FirstOrDefault(r => r.WestDestination == nodes[7, 9])).BridgePenalty = 20;

            //build tunnels
            ((Bridge)nodes[0, 14].Neighbors.FirstOrDefault(r => r.WestDestination == nodes[5, 15])).BridgePenalty = 20;

            return nodes;
        }
    }
}
