namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;

    public class MyInsertionSort
    {
        public string SortNumbers(List<int> collection)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                int currentNumber = collection[i];
                int j = i - 1;

                while (j >= 0 && collection[j] > currentNumber)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }

                collection[j + 1] = currentNumber;
            }

            return string.Join(" ",collection);
        }
    }
}
