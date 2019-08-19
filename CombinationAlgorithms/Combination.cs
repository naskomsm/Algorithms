namespace Algorithms_and_data_structure.CombinationAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Combination
    {
        private int k;

        public Combination(int k)
        {
            this.k = k;
        }

        public void Combine(int index, int start, string[] array)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", array));
            }

            else
            {
                for (int i = start; i < array.Length; i++)
                {
                    //todo
                }
            }
        }
    }
}
