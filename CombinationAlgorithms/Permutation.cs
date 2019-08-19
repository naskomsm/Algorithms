namespace Algorithms_and_data_structure.CombinationAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class Permutation
    {
        public void Permute(int index, string[] elements)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }

            else
            {
                Permute(index + 1, elements);
                for (int i = index + 1; i < elements.Length; i++)
                {
                    Swap(index, i, elements);
                    Permute(index + 1, elements);
                    Swap(index, i, elements);
                }
            }
        }

        public void PermuteWithRepetition(int index, string[] elements)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }

            else
            {
                HashSet<string> swapped = new HashSet<string>();

                for (int i = index; i < elements.Length; i++)
                {
                    if (!swapped.Contains(elements[i]))
                    {
                        Swap(index, i, elements);
                        PermuteWithRepetition(index + 1, elements);
                        Swap(index, i, elements);
                        swapped.Add(elements[i]);
                    }
                }
            }
        }

        private void Swap(int firstIndex, int secondIndex, string[] collection)
        {
            var temp = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = temp;
        }

        public long FindPossibleWaysCountWithoutRepetition(int collectionLength)
        {
            if (collectionLength == 0)
            {
                return 1;
            }

            var result = collectionLength * FindPossibleWaysCountWithoutRepetition(collectionLength - 1);

            return result;
        }
    }
}
