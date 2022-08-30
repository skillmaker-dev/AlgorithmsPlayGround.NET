using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Searching.BinarySearch
{
    public class BinarySearchAlgorithm
    {
        /// <summary>
        /// Search an item in a list using BinarySearch algorithm, Time complexity of O(log n).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int SearchRecursive(double item, List<double> sortedList)
        {
            return SearchRecursive(item, sortedList, 0, sortedList.Count - 1);
        }

        /// <summary>
        /// Search an item in a list using BinarySearch algorithm in recursive approach, Time complexity of O(log n), Space complexity O(log n).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <param name="endIndex">End index of searching.</param>
        /// <param name="startIndex">Start index of searching.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        private static int SearchRecursive(double item, List<double> sortedList, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return -1;

            int middleIndex = (startIndex + endIndex) / 2;

            if (sortedList[middleIndex] == item)
                return middleIndex;

            if (item > sortedList[middleIndex])
                return SearchRecursive(item, sortedList, middleIndex + 1, endIndex);
           
            return SearchRecursive(item, sortedList, startIndex, middleIndex - 1);
        }

        /// <summary>
        /// Search an item in a list using BinarySearch algorithm in iterative approach, Time complexity of O(log n), Space complexity O(1).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int SearchIterative(double item, List<double> sortedList)
        {
            int start = 0;
            int end = sortedList.Count - 1;

            while (start <= end)
            {
                int middleIndex = (start + end) / 2;

                if (sortedList[middleIndex] == item)
                    return middleIndex;
                    

                if(item > sortedList[middleIndex])
                    start = middleIndex + 1;

                if (item < sortedList[middleIndex])
                    end = middleIndex - 1;
            }

            return -1;
        }
     }
}
