namespace Algorithms_and_data_structure.DynamicProgramming.TheKnapsack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TheKnapsackProblem
    {
        private int capacity;
        private List<Item> items;

        private int[,] maxPrice;
        private bool[,] isItemTaken;

        public TheKnapsackProblem(int capacity)
        {
            this.capacity = capacity;
            this.items = new List<Item>();
        }

        public void Solve()
        {
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

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items taken: ");

            var currentRow = rows;
            var currentCol = cols;

            while (items.Any())
            {
                var isTaken = isItemTaken[currentRow, currentCol];

                if (isTaken)
                {
                    sb.AppendLine($"{items[currentRow]}");
                }

                currentRow--;
                currentCol -= items[currentRow].Weight; 

                items.RemoveAt(currentRow);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
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

                if(price == include)
                {
                    isItemTaken[row, col] = true;
                }
            }

            maxPrice[row, col] = price;
        }
    }
}
