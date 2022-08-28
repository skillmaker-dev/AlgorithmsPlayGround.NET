using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Sorting.QuickSort
{
    public class QuickSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in ascending order using QuickSort algorithm, Time complexity of mostly O(n Log n) in case of shuffled list and O(n2) in worst case or sorted list.
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static List<double> SortAscending(List<double> list)
        {
            List<double> sortedList = new List<double>(list);
            
            return Sort(sortedList, 0, sortedList.Count - 1,false);
        }

        /// <summary>
        /// Sorting a list of numbers in Descending order using QuickSort algorithm, Time complexity of mostly O(n Log n) in case of shuffled list and O(n2) in worst case or sorted list.
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static List<double> SortDescending(List<double> list)
        {
            List<double> sortedList = new List<double>(list);

            return Sort(sortedList, 0, sortedList.Count - 1, true);
        }


        /// <summary>
        /// Sorting a list of numbers in Descending order using QuickSort algorithm, Time complexity of mostly O(n Log n) in case of shuffled list and O(n2) in worst case or sorted list.
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <param name="end">Index of last item</param>
        /// <param name="start">Index of first item</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done in descending order</param>
        /// <returns>A sorted list</returns>
        private static List<double> Sort(List<double> list, int start, int end,bool sortDescending)
        {
            var i = start;
            var j = end;

            //Select middle as the pivot
            var pivot = list[(start+end)/2];
            while(i < j)
            {
                //Skip elements that are less than pivot
                while ((!sortDescending && list[i] < pivot) || (sortDescending && list[i] > pivot))
                    i++;

                //Skip elements that are greater than pivot
                while ((!sortDescending && list[j] > pivot) || (sortDescending && list[j] < pivot))
                    j--;

                //Swap elements that are out of order
                if(i <= j)
                {
                    (list[i], list[j]) = (list[j],list[i]);
                    i++;
                    j--;
                }
            }

            if(start < j)
                //Sort the right side
                Sort(list,start,j,sortDescending);
            if(end > i)
                //Sort the left side
                Sort(list,i,end,sortDescending);

            return list;
        }
    }
}
