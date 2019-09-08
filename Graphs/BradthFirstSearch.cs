namespace Algorithms_and_data_structure.Graphs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BradthFirstSearch
    {
        private List<int>[] graph;
        private bool[] visited;
        private Queue<int> queue;

        public BradthFirstSearch(List<int>[] graph)
        {
            this.graph = graph;
            this.visited = new bool[graph.Length];
            this.queue = new Queue<int>();
        }

        public void PrintAllChildNodes()
        {
            
        }

        public void BFS(int node)
        {
            this.queue.Enqueue(node);
            visited[node] = true;

            while (queue.Any())
            {
                var nodeToPrint = queue.Dequeue();
                Console.WriteLine(nodeToPrint);

                foreach (var child in this.graph[nodeToPrint])
                {
                    if (!this.visited[child])
                    {
                        this.queue.Enqueue(child);
                        this.visited[child] = true;
                    }
                }
            }
        }
    }
}
