using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Searching.TernarySearch
{
    public class TernarySearchAlgorithm
    {
        /// <summary>
        /// Search an item in a list using TernarySearch algorithm, Time complexity of O(log3 n).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int Search(double item,List<double> sortedList)
        {
            return Search(sortedList,item,0,sortedList.Count - 1);
        }


        /// <summary>
        /// Search an item in a list using TernarySearch algorithm in recursive approach, Time complexity of O(log3 n).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <param name="endIndex">End index of searching.</param>
        /// <param name="startIndex">Start index of searching.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        private static int Search(List<double> sortedList,double item,int startIndex,int endIndex)
        {
            if (startIndex > endIndex)
                return -1;

            int partitionSize = (endIndex - startIndex) / 3;
            int m1 = partitionSize + startIndex;
            int m2 = endIndex - partitionSize;

            if (item == sortedList[m1])
                return m1;
            if (item == sortedList[m2])
                return m2;

            if(item < m1)
                return Search(sortedList, item, startIndex, m1 - 1);
            if (item > m1 && item < m2)
                return Search(sortedList, item, m1 + 1,m2 - 1);
            
                return Search(sortedList, item, m2 + 1, endIndex);              
        }
    }
}
