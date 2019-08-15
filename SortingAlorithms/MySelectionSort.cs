namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;

    public class MySelectionSort
    {
        public string SortNumbers(List<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                int smallest = collection[i];
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if(collection[j] < smallest)
                    {
                        smallest = collection[j];

                        var firstNumber = collection[i];
                        collection[i] = collection[j];
                        collection[j] = firstNumber;
                    }
                }
            }

            return string.Join(" ",collection);
        }
    }
}
