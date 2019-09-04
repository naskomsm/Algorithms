namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SubsetSum
    {
        private int[] numbers;
        private Dictionary<int, int> sums;

        public SubsetSum(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void CalculateSumWithTarget(int targetSum)
        {
            Console.WriteLine($"Target sum -> {targetSum}");
            if (sums.ContainsKey(targetSum))
            {
                var numbersOfTargetSum = new List<int>();

                while (targetSum != 0)
                {
                    var number = sums[targetSum];
                    numbersOfTargetSum.Add(number);
                    targetSum -= number;
                }

                Console.WriteLine($"Your target sum can be achieved with these numbers -> {string.Join(" ", numbersOfTargetSum)}");
            }

            else
            {
                Console.WriteLine("This sum is not in SUMS...");
            }
        }

        public void CalculateSums()
        {
            var result = new Dictionary<int, int>();
            result.Add(0, 0);

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                foreach (var number in result.Keys.ToList())
                {
                    var newSum = number + currentNumber;
                    if (!result.ContainsKey(newSum))
                    {
                        result.Add(newSum, currentNumber);
                    }
                }
            }

            this.sums = result;
            PrintResult(result);
        }

        private void PrintResult(Dictionary<int, int> result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in result)
            {
                sb.AppendLine($"Sum -> {kvp.Key}, Previous sum -> {kvp.Value}");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
