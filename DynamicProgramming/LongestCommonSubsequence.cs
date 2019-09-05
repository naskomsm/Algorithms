namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class LongestCommonSubsequence
    {
        public void Solve(string first, string second)
        {
            var lcs = new int[first.Length + 1, second.Length + 1];

            for (int row = 1; row <= first.Length; row++)
            {
                for (int col = 1; col <= second.Length; col++)
                {
                    var up = lcs[row - 1, col];
                    var left = lcs[row, col - 1];

                    var result = Math.Max(up, left);

                    if (first[row - 1] == second[col - 1])
                    {
                        result = Math.Max(1 + lcs[row - 1, col - 1], result);
                    }

                    lcs[row, col] = result;
                }
            }

            var currentRow = first.Length;
            var currentCol = second.Length;

            var commonSymbols = new List<char>();

            while (currentRow > 0 && currentCol > 0)
            {
                if (first[currentRow - 1] == second[currentCol - 1]
                    && lcs[currentRow, currentCol] - 1 == lcs[currentRow - 1, currentCol - 1])
                {
                    commonSymbols.Add(first[currentRow - 1]);
                    currentRow--;
                    currentCol--;
                }

                else if (lcs[currentRow - 1, currentCol] == lcs[currentRow, currentCol])
                {
                    currentRow--;
                }

                else
                {
                    currentCol--;
                }
            }

            commonSymbols.Reverse();
            Console.WriteLine(string.Join(" ", commonSymbols));
        }
    }
}
