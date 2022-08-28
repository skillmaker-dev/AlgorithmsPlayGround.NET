using System.Collections.Generic;

namespace Algorithms.NET.Sorting.InsertionSort
{
    public class InsertionSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in ascending order using InsertionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static List<double> SortAscending(List<double> list)
        {
            return Sort(list, false);
        }

        /// <summary>
        /// Sorting a list of numbers in descending order using InsertionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in descending order.</returns>
        public static List<double> SortDescending(List<double> list)
        {
            return Sort(list, true);
        }

        /// <summary>
        /// Sorting a list of numbers using InsertionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done in descending order</param>
        /// <returns>A sorted list</returns>
        private static List<double> Sort(List<double> list, bool sortDescending)
        {
            List<double> sortedList = new List<double>(list);

            for (int i = 1; i < list.Count; i++)
            {
                var current = list[i];
                int j = i - 1;

                if (!sortDescending)
                    while (j >= 0 && sortedList[j] > current)
                    {
                        sortedList[j + 1] = sortedList[j];
                        j--;
                    }
                else
                    while (j >= 0 && sortedList[j] < current)
                    {
                        sortedList[j + 1] = sortedList[j];
                        j--;
                    }

                sortedList[j + 1] = current;
            }

            return sortedList;
        }
    }
}
