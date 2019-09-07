namespace Algorithms_and_data_structure.Graphs
{
    using System;
    using System.Collections.Generic;

    public class DephFirstSearch
    {
        private List<int>[] graph;
        private bool[] visited;

        public DephFirstSearch(List<int>[] graph)
        {
            this.graph = graph;
            this.visited = new bool[graph.Length];
        }

        public void PrintAllChildNodes()
        {
            for (int n = 0; n < graph.Length; n++)
            {
                if (!visited[n])
                {
                    Console.Write("Connected component: ");
                    DFS(n);
                    Console.WriteLine();
                }
            }
        }

        private void DFS(int node)
        {
            if (!this.visited[node])
            {
                this.visited[node] = true;

                foreach (var child in this.graph[node])
                {
                    DFS(child);
                }

                Console.Write($"{node} ");
            }
        }
    }
}
