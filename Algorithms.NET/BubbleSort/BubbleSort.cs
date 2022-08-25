using System;
using System.Collections.Generic;

namespace Algorithms.NET.BubbleSort
{
    public static class BubbleSort
    {
        public static IEnumerable<double> SortDescending(List<double> list)
        {
            var sortedList = list;
            bool isSorted;
            for(int i = 0;i <sortedList.Count;i++)
            {
                isSorted = true;
                for(int j = 1;j <sortedList.Count - i;j++)
                    if(sortedList[j-1] < sortedList[j])
                    {
                        (sortedList[j-1],sortedList[j]) = (sortedList[j],sortedList[j-1]);
                        isSorted = false;
                    }

                if(isSorted)
                    return sortedList;
            }

            return sortedList;
        }

        public static IEnumerable<double> SortAscending(List<double> list)
        {
            var sortedList = list;
            bool isSorted;

            for(int i = 0;i <sortedList.Count;i++)
            {
                isSorted = true;
                for(int j = 1;j <sortedList.Count - i;j++)
                    if(sortedList[j-1] > sortedList[j])
                    {
                        (sortedList[j - 1], sortedList[j]) = (sortedList[j], sortedList[j - 1]);
                        isSorted = false;
                    }


                if (isSorted)
                    return sortedList;
            }

            return sortedList;
        }
    }
}
