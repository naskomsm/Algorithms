namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;

    public class LongestIncreasingSubsequence
    {
        public void Solve(int[] numbers)
        {
            int[] solutions = new int[numbers.Length];
            var maxSolution = 0;

            for (int current = 0; current < numbers.Length; current++)
            {
                var solution = 1;
                var currentNumber = numbers[current];

                for (int solutionIndex = 0; solutionIndex < current; solutionIndex++)
                {
                    var previousNumber = numbers[solutionIndex];
                    var previousSolution = solutions[solutionIndex];

                    if (currentNumber > previousNumber && solution <= previousSolution)
                    {
                        solution = previousSolution + 1;
                    }
                }

                solutions[current] = solution;
                if(solution > maxSolution)
                {
                    maxSolution = solution;
                }
            }

            Console.WriteLine(maxSolution);
        }
    }
}
