namespace Algorithms_and_data_structure.DynamicProgramming.TheKnapsack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheKnapsackProblem
    {
        private int capacity;
        private List<Item> items;
        private List<Item> result;

        private int[,] maxPrice;
        private bool[,] isItemTaken;

        public TheKnapsackProblem(int capacity)
        {
            this.capacity = capacity;
            this.items = new List<Item>();
            this.result = new List<Item>();
        }

        public void Solve()
        {
            GetData();
            InitializeAndFufillMatrix();
            PrintTheItems();
        }

        private void PrintTheItems()
        {
            var bottomRow = isItemTaken.GetLength(0) - 1;
            var bottomCol = isItemTaken.GetLength(1) - 1;

            while (items.Any())
            {
                var currentItem = items[bottomRow - 1];

                if (isItemTaken[bottomRow, bottomCol] == true)
                {
                    this.result.Add(currentItem);
                    bottomCol -= currentItem.Weight;
                }

                bottomRow--;
                items.RemoveAt(bottomRow);
            }

            Console.WriteLine($"Best items to get -> ");
            foreach (var item in result)
            {
                Console.Write($"Name: {item.Name}, ");
                Console.Write($"Weight: {item.Weight}, ");
                Console.WriteLine($"Value: {item.Price}.");
            }
        }

        private void GetData()
        {
            Console.WriteLine("Give the item information in the format -> {name} {weight} {price}");
            Console.WriteLine("Write -> {end} to solve the problem");

            var command = Console.ReadLine().Split(" ");

            while (command[0] != "end")
            {
                var name = command[0];
                var weight = int.Parse(command[1]);
                var price = int.Parse(command[2]);

                var item = new Item(name, weight, price);
                items.Add(item);

                command = Console.ReadLine().Split(" ");
            }
        }

        private void InitializeAndFufillMatrix()
        {
            var rows = items.Count + 1;
            var cols = capacity + 1;

            maxPrice = new int[rows, cols];
            isItemTaken = new bool[rows, cols];

            for (int row = 1; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    FindBestValue(row, col);
                }
            }
        }

        private void FindBestValue(int row, int col)
        {
            var currentItem = items[row - 1];
            int price;

            if (currentItem.Weight > col)
            {
                var exclude = maxPrice[row - 1, col];
                price = exclude;
            }

            else
            {
                var exclude = maxPrice[row - 1, col];
                var include = currentItem.Price + maxPrice[row - 1, col - currentItem.Weight];

                price = Math.Max(exclude, include);

                if (price == include)
                {
                    isItemTaken[row, col] = true;
                }
            }

            maxPrice[row, col] = price;
        }
    }
}
