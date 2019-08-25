namespace Algorithms_and_data_structure
{
    using Algorithms_and_data_structure.BruteForceAlgoritm;
    using Algorithms_and_data_structure.CombinationAlgorithms;
    using Algorithms_and_data_structure.GreedyAlgorithm;
    using Algorithms_and_data_structure.SearchingAlgorithms;
    using Algorithms_and_data_structure.SimpleRecursionProblems;
    using Algorithms_and_data_structure.SortingAlorithms;
    using System;
    using System.Collections.Generic;

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

            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Solve(20);
        }
    }
}
