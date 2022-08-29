using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.NET.Sorting.CountingSort
{
    public class CountingSortAlgorithm
    {
        /// <summary>
        /// Sorting an array of positive integers in ascending order using CountingSort algorithm, Time complexity of O(n).
        /// </summary>
        /// <param name="list">Array of numbers to sort</param>
        /// <returns>Sorted Array in ascending order.</returns>
        public static int[] SortAscending(int[] list)
        {
            return Sort(list, false);
        }

        /// <summary>
        /// Sorting an array of positive integers in Descending order using CountingSort algorithm, Time complexity of O(n).
        /// </summary>
        /// <param name="list">Array of numbers to sort</param>
        /// <returns>Sorted Array in Descending order.</returns>
        public static int[] SortDescending(int[] list)
        {
            return Sort(list, true);
        }

        /// <summary>
        /// Sorting an array of positive integers using CountingSort algorithm, Time complexity of O(n).
        /// </summary>
        /// <param name="list">Array of numbers to sort</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done in descending order</param>
        /// <returns>A sorted Array</returns>
        private static int[] Sort(int[] list, bool sortDescending)
        {
            int[] sortedList = new int[list.Length];
            list.CopyTo(sortedList, 0);

            int max = sortedList[0];
            for (int i = 1; i < sortedList.Length; i++)
                if (sortedList[i] > max)
                    max = sortedList[i];

            int[] countingArray = new int[max + 1];

            for (int i = 0; i < sortedList.Length; i++)
            {
                countingArray[sortedList[i]]++;
            }

            if (!sortDescending)
            {
                int k = 0;
                for (int i = 0; i < countingArray.Length; i++)
                    for (int j = 0; j < countingArray[i]; j++)
                        sortedList[k++] = i;
            }
            else
            {
                int k = 0;
                for (int i = countingArray.Length - 1; i >= 0; i--)
                    for (int j = 0; j < countingArray[i]; j++)
                        sortedList[k++] = i;
            }


            return sortedList;
        }
    }
}
