namespace Algorithms_and_data_structure.GreedyAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActivitySelectionProblem
    {
        private List<KeyValuePair<int, int>> myList;

        public ActivitySelectionProblem(Dictionary<int, int> set)
        {
            myList = set.ToList();
            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        }

        public void Run()
        {
            var last = myList[0];

            foreach (var item in myList)
            {
                if (item.Key >= last.Value)
                {
                    Console.WriteLine(item);
                    last = item;
                }
            }
        }
    }
}
