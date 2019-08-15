namespace Algorithms_and_data_structure.SortingAlorithms
{
    using System.Collections.Generic;
    using System.Linq;

    public class MyMergeSort
    {
        public List<int> SortNumbers(List<int> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            //before recursion
            var left = new List<int>();
            var right = new List<int>();

            int middle = collection.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(collection[i]);
            }

            for (int i = middle; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }

            //recursion
            left = SortNumbers(left);
            right = SortNumbers(right);

            //after recursion
            return Merge(left, right);  
        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }

                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }

                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}

