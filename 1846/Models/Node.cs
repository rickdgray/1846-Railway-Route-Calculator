using System;

namespace _1846.Models
{
    public class Node
    {
        /// <summary>
        /// Column
        /// </summary>
        /// <param name="Q">Column</param>
        public int Q { get; }
        /// <summary>
        /// Row
        /// </summary>
        /// <param name="R">Row</param>
        public int R { get; }
        public int S { get; }

        public bool IsZed { get; }
        public City City { get; }
        public int ConstructionPenalty { get; }

        public Tier Tier { get; set; }

        public Node(
            int q,
            int r,
            int? s = null,
            Tier tier = Tier.Empty,
            City city = null,
            bool isZed = false,
            int constructionPenalty = 0)
        {
            Q = q;
            R = r;
            if (s == null)
                S = 0 - Q - R;
            else
                S = s ?? 0;

            if (Q + R + S != 0)
                throw new ArgumentException("Coordinates must be zero-sum.");

            IsZed = isZed;
            City = city;
            ConstructionPenalty = constructionPenalty;
            Tier = tier;
        }

        public Node Add(Node b)
        {
            return new Node(Q + b.Q, R + b.R, S + b.S);
        }

        public Node Subtract(Node b)
        {
            return new Node(Q - b.Q, R - b.R, S - b.S);
        }

        public Node RotateLeft()
        {
            return new Node(-S, -Q, -R);
        }

        public Node RotateRight()
        {
            return new Node(-R, -S, -Q);
        }

        public enum Direction
        {
            UpRight,
            Right,
            DownRight,
            DownLeft,
            Left,
            UpLeft
        }

        public static Node GetAdjacentNode(Direction direction)
        {
            return direction switch
            {
                Direction.UpRight => new Node(1, 0, -1),
                Direction.Right => new Node(1, -1, 0),
                Direction.DownRight => new Node(0, -1, 1),
                Direction.DownLeft => new Node(-1, 0, 1),
                Direction.Left => new Node(-1, 1, 0),
                Direction.UpLeft => new Node(0, 1, -1),
                _ => throw new Exception("Invalid Direction"),
            };
        }

        public Node Neighbor(Direction direction)
        {
            return Add(GetAdjacentNode(direction));
        }

        public int Distance(Node b)
        {
            var diff = Subtract(b);
            return (Math.Abs(diff.Q) + Math.Abs(diff.R) + Math.Abs(diff.S)) / 2;
        }

        public override string ToString()
        {
            return $"{Tier.ToString()} {(IsZed ? "Zed " : string.Empty)}Tile at ({R}, {Q}){(City != null ? $" contains {(City is OffboardCity offboardCity ? $"{offboardCity.ToString()} " : $"{City.ToString()} ")}" : string.Empty)}";
        }
    }
}
