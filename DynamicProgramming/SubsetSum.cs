namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSum
    {
        public void CalculateSumsWithoutRepetition(int[] numbers, int targetSum)
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

            var allPosibleSums = new List<int>();
            foreach (var sum in result.Keys)
            {
                allPosibleSums.Add(sum);
            }

            Console.WriteLine($"All possible sums -> {string.Join(" ", allPosibleSums)}");

            Console.WriteLine($"Target sum -> {targetSum}");
            if (result.ContainsKey(targetSum))
            {
                var numbersOfTargetSum = new List<int>();

                while (targetSum != 0)
                {
                    var number = result[targetSum];
                    numbersOfTargetSum.Add(number);
                    targetSum -= number;
                }

                Console.WriteLine($"Your target sum can be achieved with these numbers -> {string.Join(" ", numbersOfTargetSum)}");
            }

            else
            {
                Console.WriteLine("Not a possible sum");
            }
        }

        public void CalculateSumsWithRepetition(int[] numbers, int targetSum)
        {
            var possibleSums = new bool[targetSum + 1];
            possibleSums[0] = true;

            for (int sum = 0; sum < possibleSums.Length; sum++)
            {
                if (possibleSums[sum])
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        var newSum = sum + numbers[i];

                        if (newSum <= targetSum)
                        {
                            possibleSums[newSum] = true;
                        }
                    }
                }
            }

            var numbersOfTargetSum = new List<int>();
            while (targetSum != 0)
            {
                var copy = targetSum;
                for (int i = 0; i < numbers.Length; i++)
                {
                    var sum = targetSum - numbers[i];
                    if (sum >= 0 && possibleSums[sum])
                    {
                        numbersOfTargetSum.Add(numbers[i]);
                        targetSum = sum;
                    }
                }

                if (targetSum == copy)
                {
                    Console.WriteLine("Not a possible sum");
                    break;
                }
            }

            if (numbersOfTargetSum.Any())
            {
                Console.WriteLine($"Target sum -> {targetSum}");
                Console.WriteLine($"Your target sum can be achieved with these numbers -> {string.Join(" ", numbersOfTargetSum)}");
            }
        }
    }
}
