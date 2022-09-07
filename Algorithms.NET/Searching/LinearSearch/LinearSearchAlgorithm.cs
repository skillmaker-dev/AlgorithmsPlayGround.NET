using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Searching.LinearSearch
{
    public class LinearSearchAlgorithm
    {
        /// <summary>
        /// Search an item in a list using linearSearch algorithm, Time complexity of O(n).
        /// </summary>
        /// <param name="item">Item to search for.</param>
        /// <param name="list">List in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int Search(double item,List<double> list)
        {
            for(int i = 0;i< list.Count;i++)
            {
                if (list[i] == item)
                    return i;
            }

            return -1;
        }
    }
}
