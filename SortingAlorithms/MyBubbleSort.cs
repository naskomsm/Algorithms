namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;

    public class MyBubbleSort
    {
        public string SortNumbers(List<int> collection)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < collection.Count; i++)
                {
                    for (int j = i + 1; j < collection.Count; j++)
                    {
                        if(collection[j] < collection[i])
                        {
                            var firstNumber = collection[i];
                            collection[i] = collection[j];
                            collection[j] = firstNumber;
                            swapped = true;
                        }

                        i++;
                    }
                }
            }

            return string.Join(" ",collection);
        }
    }
}
