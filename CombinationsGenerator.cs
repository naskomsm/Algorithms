namespace Algorithms_and_data_structure
{
    using System;

    public class CombinationsGenerator
    {
        public void Generate(int[] set, int[] vector, int index, int border)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border + 1; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    Generate(set, vector, index + 1, i);
                }
            }
        }
    }
}
