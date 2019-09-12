using Algorithms_and_data_structure.Graphs;
using System.Collections.Generic;

namespace Algorithms_and_data_structure
{
    public class Program
    {
        public static void Main()
        {
            //Labyrinth labyrinth = new Labyrinth(3, 3);
            //// you need to give the labyrinth - example --->
            //// s--
            //// -*-
            //// --e
            //labyrinth.Solve(0, 0, 'S');

            //MySelectionSort selectionSort = new MySelectionSort();
            //Console.WriteLine(selectionSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));

            //Console.WriteLine();

            //MyBubbleSort bubbleSort = new MyBubbleSort();
            //Console.WriteLine(bubbleSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));

            //Console.WriteLine();

            //MyInsertionSort insertionSort = new MyInsertionSort();
            //Console.WriteLine(insertionSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));

            //Console.WriteLine();

            //MyMergeSort mergeSort = new MyMergeSort();
            //var sorted = mergeSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 });
            //Console.WriteLine(string.Join(" ", sorted));

            //Console.WriteLine();

            //MyQuickSort quickSort = new MyQuickSort();
            //Console.WriteLine(quickSort.SortNumbers(new List<int>() { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 }));

            //BinarySearch searcher = new BinarySearch();
            //var searchedNumber = searcher.Find(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 0, 9);
            //Console.WriteLine(searchedNumber);

            //InterpolationSearch searcher = new InterpolationSearch();
            //var searchedNumber = searcher.Find(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 8, 0, 9);
            //Console.WriteLine(searchedNumber);

            //Permutation permutation = new Permutation();
            //permutation.Permute(0, new string[3] { "A", "B", "C" });
            //long possibleWaysCount = permutation.FindPossibleWaysCountWithoutRepetition(3);
            //Console.WriteLine($"Possible permutations: {possibleWaysCount}");

            //Variation variation = new Variation(2);
            //variation.VariateWithRepetition(0, new string[3] { "A", "B", "C" });

            //Combination combination = new Combination(2);
            //combination.Combine(0, 0, new string[3] { "A", "B", "C" });

            //Greedy greedy = new Greedy(new double[4] { 0.10, 0.02, 0.01, 0.05 }, 0.59);
            //greedy.Calculate();

            //BruteForce brute = new BruteForce("noob123");
            //brute.Run();

            //ExampleOfGreedy example = new ExampleOfGreedy();
            //example.Play(10);

            //Dictionary<int, int> set = new Dictionary<int, int>();
            //set.Add(0, 6);
            //set.Add(3, 5);
            //set.Add(1, 4);
            //set.Add(5, 7);
            //set.Add(3, 8);
            //set.Add(5, 9);
            //set.Add(6, 10);
            //set.Add(8, 11);
            //set.Add(8, 12);
            //set.Add(2, 13);
            //set.Add(12, 14);

            //ActivitySelectionProblem problem = new ActivitySelectionProblem(set);
            //problem.Run();

            //Fibonacci fibonacci = new Fibonacci();
            //fibonacci.Solve(50);

            //LongestIncreasingSubsequence lis = new LongestIncreasingSubsequence();
            //lis.Solve(new int[5] { 3, 5, 8, 6, 7 });

            //int[,] matrix = new int[4, 4];

            //matrix[0, 0] = 1;
            //matrix[0, 1] = 3;
            //matrix[0, 2] = 2;
            //matrix[0, 3] = 1;

            //matrix[1, 0] = 5;
            //matrix[1, 1] = 3;
            //matrix[1, 2] = 2;
            //matrix[1, 3] = 1;

            //matrix[2, 0] = 1;
            //matrix[2, 1] = 7;
            //matrix[2, 2] = 3;
            //matrix[2, 3] = 1;

            //matrix[3, 0] = 1;
            //matrix[3, 1] = 3;
            //matrix[3, 2] = 1;
            //matrix[3, 3] = 1;

            //MoveDownAndRightSumProblem problem = new MoveDownAndRightSumProblem(4, 4, matrix);
            //problem.Solve();

            //int[] price = new int[8];

            //price[0] = 1;
            //price[1] = 5;
            //price[2] = 8;
            //price[3] = 9;
            //price[4] = 10;
            //price[5] = 17;
            //price[6] = 17;
            //price[7] = 20;

            //RodCuttingProblem problem = new RodCuttingProblem(price);
            //Console.WriteLine(problem.CutRod(8));

            //TheKnapsackProblem problem = new TheKnapsackProblem(4);
            //problem.Solve();

            //var numbers = new int[] { 3, 5 };
            //SubsetSum problem = new SubsetSum();
            //problem.CalculateSumsWithRepetition(numbers, 5);

            //LongestCommonSubsequence lcs = new LongestCommonSubsequence();
            //var first = "GCGCAATG";
            //var second = "GCCCTAGCG";
            //lcs.Solve(first, second);

            // Representing graph with Adjacency List
            var graph = new List<int>[]
            {
                new List<int>() { 1, 2 },
                new List<int>() { 3, 4 },
                new List<int>() { 5 },
                new List<int>() { 2, 5 },
                new List<int>() { 3 },
                new List<int>(),
            };

            //DephFirstSearch dfs = new DephFirstSearch(graph);
            //dfs.PrintAllChildNodes();

            //BradthFirstSearch bfs = new BradthFirstSearch(graph);
            //bfs.BFS(0);

            // Representing graph with Adjacency Matrix
            //var otherGraph = new int[,]
            //{
            //    { 0 , 1 , 1 , 1 , 1 },
            //    { 1 , 0 , 0 , 0 , 0 },
            //    { 1 , 0 , 0 , 1 , 0 },
            //    { 1 , 0 , 1 , 0 , 1 },
            //    { 1 , 0 , 0 , 1 , 0 },
            //};

            // Representing graph with List of Edges
            //var anotherGraph = new List<Edge>()
            //{
            //    new Edge(0,1),
            //    new Edge(0,2),
            //    new Edge(0,3),
            //    new Edge(0,4),
            //    new Edge(1,0),
            //    new Edge(2,0),
            //    new Edge(2,2),
            //    new Edge(3,0),
            //    new Edge(3,4),
            //    new Edge(4,0),
            //    new Edge(4,3),
            //};


            SourceRemovalAlgorithm sra = new SourceRemovalAlgorithm();
            sra.Order(graph);
        }
    }
}
