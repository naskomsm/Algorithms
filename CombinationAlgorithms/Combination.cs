namespace Algorithms_and_data_structure.CombinationAlgorithms
{
    using System;

    public class Combination
    {
        private string[] result;

        public Combination(int size)
        {
            this.result = new string[size];
        }

        public void Combine(int index, int start, string[] collection)
        {
            if (index >= this.result.Length)
            {
                Console.WriteLine(string.Join(" ", this.result));
            }

            else
            {
                for (int i = start; i < collection.Length; i++)
                {
                    result[index] = collection[i];
                    Combine(index + 1, i + 1, collection);
                }
            }
        }
    }
}
