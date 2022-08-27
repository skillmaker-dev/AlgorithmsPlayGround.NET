using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Sorting.MergeSort
{
    public class MergeSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in ascending order using MergeSort algorithm, Time complexity of O(n Log n).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in ascending order.</returns>
        public static List<double> SortAscending(List<double> list)
        {
            List<double> sortedList = new List<double>(list);
            return Sort(sortedList,false);
        }

        /// <summary>
        /// Sorting a list of numbers in descending order using MergeSort algorithm, Time complexity of O(n Log n).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted list in descending order.</returns>
        public static List<double> SortDescending(List<double> list)
        {
            List<double> sortedList = new List<double>(list);
            return Sort(sortedList, true);
        }

        /// <summary>
        /// Sorting a list of numbers using MergeSort algorithm, Time complexity of O(n Log n).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <param name="sortDescending">Boolean value specifying whether sorting should be done in descending order</param>
        /// <returns>A sorted list</returns>
        private static List<double> Sort(List<double> list,bool sortDescending)
        {
            //We stop recursion when size is 1, which means an array of one element is sorted.
            if (list.Count < 2)
                return list;

            //Divide list in half.
            int middle = list.Count / 2;

            List<double> left = new List<double>();
            List<double> right = new List<double>();

            //Fill each half
            for(int i = 0; i < middle; i++)
                left.Add(list[i]);

            for(int j = middle; j < list.Count; j++)
                right.Add(list[j]);

            //Sort each half.
            Sort(left,sortDescending);
            Sort(right,sortDescending);

            //Merge the results
            Merge(left, right, list, sortDescending);

            return list;
        }

        /// <summary>
        /// Merging two arrays in correct order according to the boolean value of sortDescending
        /// </summary>
        /// <param name="leftHalf">A list of the left half</param>
        /// <param name="rightHalf">A list of the right half</param>
        /// <param name="list">Original list in which we want to insert items correctly</param>
        /// <param name="sortDescending">Boolean value of whether sorting should be done in descending order or not</param>
        private static void Merge(List<double> leftHalf, List<double> rightHalf, List<double> list,bool sortDescending)
        {
            int i = 0, j = 0, k = 0;
            
            //We insert the first items in the correct order by comparing them to each others
            while(i < leftHalf.Count && j < rightHalf.Count)
            {
                if(!sortDescending && leftHalf[i] < rightHalf[j])
                    list[k++] = leftHalf[i++];
                else 
                    list[k++] = rightHalf[j++];
            }

            //We insert the remaining items 
            while(j < rightHalf.Count)
                list[k++] = rightHalf[j++];

            while(i < leftHalf.Count)
                list[k++] = leftHalf[i++];
        }
    }
}
