using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Searching.JumpSearch
{
    public class JumpSearchAlgorithm
    {
        /// <summary>
        /// Search an item in a list using JumpSearch algorithm, Time complexity of O(sqrt n).
        /// </summary>
        /// <param name="item">Item to search for</param>
        /// <param name="sortedList">Sorted list in which we want to search.</param>
        /// <returns>Index of item if found, Otherwise returns -1.</returns>
        public static int Search(double item,List<double> sortedList)
        {
            int blockSize = (int)Math.Sqrt(sortedList.Count);

            int start = 0;
            int next = blockSize;

            while(start < sortedList.Count && sortedList[next - 1] < item )
            {
                start = next;
                next += blockSize;

                if(next > sortedList.Count)
                    next = sortedList.Count;
            }

            for(int i = start;i<next;i++)
                if(sortedList[i] == item)
                    return i;

            return -1;
        }
    }
}
