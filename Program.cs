namespace Algorithms_and_data_structure
{
    using Algorithms_and_data_structure.SortingAlorithms;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            //Labyrinth labyrinth = new Labyrinth(3, 3);
            //// you need to give the labyrinth - example --->
            //// ---
            //// -*-
            //// --e
            //labyrinth.Solve(0, 0, 'S');

            MySelectionSort selectionSort = new MySelectionSort();
            Console.WriteLine(selectionSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));

            Console.WriteLine();

            MyBubbleSort bubbleSort = new MyBubbleSort();
            Console.WriteLine(bubbleSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));

            Console.WriteLine();

            MyInsertionSort insertionSort = new MyInsertionSort();
            Console.WriteLine(insertionSort.SortNumbers(new List<int>() { 25, 10, 5, 7, 1, 2, 150, 256, 11, 23, 57, 69, 12 }));
        }
    }
}
