namespace Algorithms_and_data_structure
{
    using System;

    public class VectorGenerator
    {
        public void Generate(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(vector, index + 1);
                }
            }
        }
    }
}
