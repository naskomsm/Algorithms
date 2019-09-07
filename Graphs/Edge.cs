namespace Algorithms_and_data_structure.Graphs
{
    public class Edge
    {
        public Edge(int parent, int child)
        {
            this.Parent = parent;
            this.Child = child;
        }

        public int Parent { get; set; }

        public int Child { get; set; }
    }
}
