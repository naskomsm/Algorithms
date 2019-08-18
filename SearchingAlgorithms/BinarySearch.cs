namespace Algorithms_and_data_structure.SearchingAlgorithms
{
    using System.Collections.Generic;

    public class BinarySearch
    {
        public int Find(List<int> collection, int number, int start, int end)
        {
            if (end < start)
            {
                return 0;
            }

            else
            {
                int mid = (start + end) / 2;

                if (number < collection[mid])
                {
                    return Find(collection, number, start, mid - 1);
                }

                else if (number > collection[mid])
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
