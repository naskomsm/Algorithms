namespace Algorithms_and_data_structure.CombinationAlgorithms
{
    using System;

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

        private void Swap(int firstIndex, int secondIndex, string[] collection)
        {
            var temp = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = temp;
        }

        public long FindPossibleWaysCount(int collectionLength)
        {
            if (collectionLength == 0)
            {
                return 1;
            }

            var result = collectionLength * FindPossibleWaysCount(collectionLength - 1);

            return result;
        }
    }
}
