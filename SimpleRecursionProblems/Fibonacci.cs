namespace Algorithms_and_data_structure.SimpleRecursionProblems
{
    using System;
    using System.Collections.Generic;

    public class Fibonacci
    {
        public void Solve(int fibonaccyUpperGap)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < fibonaccyUpperGap; i++)
            {
                if (i == 0 || i == 1)
                {
                    result.Add(i);
                }

                else
                {
                    int number = result[i - 1] + result[i - 2];
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
