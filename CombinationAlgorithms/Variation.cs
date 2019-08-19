namespace Algorithms_and_data_structure.CombinationAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Variation
    {
        private int arrayLength;
        private string[] variations;
        private bool[] used;

        public Variation(int arrayLength)
        {
            this.arrayLength = arrayLength;
            this.variations = new string[arrayLength];
            this.used = new bool[3];
        }

        public void Variate(int index, string[] elements)
        {
            if (index >= arrayLength)
            {
                Console.WriteLine(string.Join(" ", variations));
            }

            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        variations[index] = elements[i];
                        Variate(index + 1, elements);
                        used[i] = false;
                    }
                }
            }
        }

        public void VariateWithRepetition(int index, string[] elements)
        {
            if (index >= arrayLength)
            {
                Console.WriteLine(string.Join(" ", variations));
            }

            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    variations[index] = elements[i];
                    VariateWithRepetition(index + 1, elements);
                }
            }
        }
    }
}
