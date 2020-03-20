namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;

    public class MyQuickSort
    {
        public string SortNumbers(List<int> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            var pivot = collection[0];

            //before recursion
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 1; i < collection.Count; i++)
            {
                if (collection[i] <= pivot)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            //recursion
            left = SortNumbers(left);
            right = SortNumbers(right);

            left.Add(pivot);

            //after recursion
            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            result.AddRange(left);
            result.AddRange(right);
            return result;
        }
    }
}
