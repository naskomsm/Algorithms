namespace Algorithms_and_data_structure.Graphs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SourceRemovalAlgorithm
    {
        public void Order(List<int>[] graph)
        {
            var result = new List<int>(); // hold sorted elements
            var nodes = new HashSet<int>();

            var nodesWithIncomingEdges = GetNodesWithIncomingEdges(graph);
            for (int i = 0; i < graph.Length; i++)
            {
                if (!nodesWithIncomingEdges.Contains(i))
                {
                    nodes.Add(i);
                }
            }

            while (nodes.Count != 0)
            {
                var currentNode = nodes.First();
                nodes.Remove(currentNode);

                result.Add(currentNode);

                var children = graph[currentNode].ToList();
                graph[currentNode] = new List<int>();

                var leftNodesWithIncomingEdges = GetNodesWithIncomingEdges(graph);

                foreach (var child in children)
                {
                    if (!leftNodesWithIncomingEdges.Contains(child))
                    {
                        nodes.Add(child);
                    }
                }
            }

            if (graph.SelectMany(s => s).Any())
            {
                Console.WriteLine("Sorry there is a cycle somewhere...");
            }

            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }

        private static HashSet<int> GetNodesWithIncomingEdges(List<int>[] graph)
        {
            var nodesWithIncomingEdges = new HashSet<int>();

            graph
                .SelectMany(s => s)
                .ToList()
                .ForEach(e => nodesWithIncomingEdges.Add(e));

            return nodesWithIncomingEdges;
        }
    }
}
