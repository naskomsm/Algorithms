namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;

    public class MyQuickSort
    {
        public string SortNumbers(List<int> collection)
        {
            int pivot = collection[0];

            for (int i = 0; i < collection.Count; i++)
            {
                int pivotIndex = collection.IndexOf(pivot);
                int storeIndex = pivotIndex + 1;

                for (int j = pivotIndex + 1; j < collection.Count; j++)
                {
                    if (collection[j] < collection[pivotIndex])
                    {
                        int temp = collection[j];
                        collection[j] = collection[storeIndex];
                        collection[storeIndex] = temp;
                        storeIndex++;
                    }
                }

                int secondTemp = collection[pivotIndex];
                collection[pivotIndex] = collection[storeIndex - 1];
                collection[storeIndex - 1] = secondTemp;
            }

            return string.Join(" ", collection);
        }
    }
}
