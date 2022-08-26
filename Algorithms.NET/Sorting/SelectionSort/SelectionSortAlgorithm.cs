using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Sorting.SelectionSort
{
    public static class SelectionSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in descending order using SelectionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in descending order.</returns>
        public static IEnumerable<double> SortDescending(List<double> list)
        {
            return Sort(list, true);
        }

        /// <summary>
        /// Sorting a list of numbers in ascending order using SelectionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static IEnumerable<double> SortAscending(List<double> list)
        {
            return Sort(list,false);
        }

        /// <summary>
        /// Sorting a list of numbers using SelectionSort algorithm, Time complexity of O(n2).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done in descending order</param>
        /// <returns>A sorted list</returns>
        private static IEnumerable<double> Sort(List<double> list,bool sortDescending)
        {
            var sortedList = new List<double>();
            sortedList.AddRange(list); 
            for(int i = 0; i < sortedList.Count; i++)
            {
                double min = sortedList[i];
                double max = sortedList[i];
                int index = i;
                for(int j = i; j< list.Count; j++)
                {
                    //Finding max or min according to boolean value of sortDescending
                    if (!sortDescending && sortedList[j] < min)
                    {
                        min = sortedList[j];
                        index = j;
                    }
                    else if (sortDescending && sortedList[j] > max)
                    {
                        max = sortedList[j];
                        index = j;
                    }

                }
                if(index != i)
                    (sortedList[i], sortedList[index]) = (sortedList[index], sortedList[i]);
            }

            return sortedList;
        }
    }
}
