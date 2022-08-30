using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Searching.ExponentialSearch
{
    public class ExponentialSearchAlgorithm
    {
        /// <summary>
        /// Search an item in a list using ExponentialSearch algorithm, Time complexity of O(log i) where i is the position of the search key in the list.
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int Search(double item, List<double> sortedList)
        {
            int bound = 1;

            while(bound < sortedList.Count && sortedList[bound] < item)
                bound *= 2;

            int start = bound / 2;
            int end = Math.Min(sortedList.Count - 1, bound);

            return BinarySearch.BinarySearchAlgorithm.SearchRecursive(item,sortedList, start, end);
        }
    }
}
