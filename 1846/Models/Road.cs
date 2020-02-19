namespace _1846.Models
{
    public class Road
    {
        public Node WestDestination { get; set; }
        public Node EastDestination { get; set; }
        public bool WestIsBuilt { get; set; }
        public bool EastIsBuilt { get; set; }
        public bool IsBuilt => WestIsBuilt && EastIsBuilt;
    }
}
