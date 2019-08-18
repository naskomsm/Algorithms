namespace Algorithms_and_data_structure.SearchingAlgorithms
{
    using System.Collections.Generic;

    public class InterpolationSearch
    {
        public int Find(List<int> collection, int number, int start, int end)
        {
            if(end < start)
            {
                return 0;
            }

            else
            {
                int mid = start + (number - collection[start]) * (end - start) / (collection[end] - collection[start]);

                if(number < collection[mid])
                {
                    return Find(collection, number, start, mid - 1);
                }

                else if(number > collection[mid])
                {
                    return Find(collection, number, mid + 1, end);
                }

                else
                {
                    return number;
                }
            }
        }
    }
}
