using System;
using System.Collections.Generic;

namespace Algorithms.NET.Sorting.BubbleSort
{
    public static class BubbleSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in descending order using BubbleSort algorithm.
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in descending order.</returns>
        public static IEnumerable<double> SortDescending(List<double> list)
        {
            return Sort(list, true);
        }

        /// <summary>
        /// Sorting a list of numbers in ascending order using BubbleSort algorithm.
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static IEnumerable<double> SortAscending(List<double> list)
        {
            return Sort(list, false);
        }


        /// <summary>
        /// Sorting a list according ascending or descending
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done descending</param>
        /// <returns>A sorted list</returns>
        private static IEnumerable<double> Sort(List<double> list, bool sortDescending)
        {
            var sortedList = list;
            bool isSorted;

            for (int i = 0; i < sortedList.Count; i++)
            {
                isSorted = true;
                for (int j = 1; j < sortedList.Count - i; j++)
                {
                    if (sortDescending && sortedList[j - 1] < sortedList[j])
                    {
                        (sortedList[j - 1], sortedList[j]) = (sortedList[j], sortedList[j - 1]);
                        isSorted = false;
                    }
                    else if(!sortDescending && sortedList[j - 1] > sortedList[j])
                    {
                        (sortedList[j - 1], sortedList[j]) = (sortedList[j], sortedList[j - 1]);
                        isSorted = false;
                    }
                }

                if (isSorted)
                    return sortedList;
            }

            return sortedList;
        }
    }
}
