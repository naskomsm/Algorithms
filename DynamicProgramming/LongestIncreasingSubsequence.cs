namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class LongestIncreasingSubsequence
    {
        public void Solve(int[] numbers)
        {
            int[] solutions = new int[numbers.Length];
            var previousSolutions = new int[numbers.Length];

            var maxSolution = 0;
            var maxSolutionIndex = 0;

            for (int current = 0; current < numbers.Length; current++)
            {
                var solution = 1;
                var previousIndex = -1;  // default -> if we dont have prev index

                var currentNumber = numbers[current];

                for (int solutionIndex = 0; solutionIndex < current; solutionIndex++)
                {
                    var previousNumber = numbers[solutionIndex];
                    var previousSolution = solutions[solutionIndex];

                    if (currentNumber > previousNumber && solution <= previousSolution)
                    {
                        solution = previousSolution + 1;
                        previousIndex = solutionIndex;
                    } 
                }

                solutions[current] = solution;
                previousSolutions[current] = previousIndex;

                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxSolutionIndex = current;
                }
            }

            // Print the LIS
            var result = new List<int>();
            var index = maxSolutionIndex;

            while (index != -1)
            {
                var currentNumber = numbers[index];
                result.Add(currentNumber);
                index = previousSolutions[index];
            }

            result.Reverse();

            Console.WriteLine($"Lis -> {string.Join(" ", result)}");
            Console.WriteLine($"Lis length is -> {maxSolution}");
        }

    }
}
