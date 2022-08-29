using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.NET.Sorting.BucketSort
{
    public class BucketSortAlgorithm
    {
        /// <summary>
        /// Sorting a list of numbers in ascending order using BucketSort algorithm, Time complexity of O(n).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted List in ascending order.</returns>
        public static List<double> SortAscending(List<double> list)
        {
            return Sort(list, false);
        }

        /// <summary>
        /// Sorting a list of numbers in ascending order using BucketSort algorithm,, Time complexity of O(n).
        /// </summary>
        /// <param name="list">List of numbers to sort</param>
        /// <returns>Sorted List in Descending order.</returns>
        public static List<double> SortDescending(List<double> list)
        {
            return Sort(list, true);
        }

        private static List<double> Sort(List<double> list, bool sortDescending)
        {
            int NUMBER_OF_BUCKETS = 10000;
            //Copy the original list to avoid mutation
            List<double> sortedList = new List<double>(list);
            //Create buckets array of size NUMBER_OF_BUCKETS
            List<double>[] buckets = new List<double>[NUMBER_OF_BUCKETS];

            //Initilize inner lists
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<double>();
            }

            double max = 0;
            //Find the max
            for(int i = 0;i < sortedList.Count;i++)
            {
                if (sortedList[i] > max)
                    max = sortedList[i];
            }

            int divider = 1;
            //Find the divider which we are going to divide numbers that are greater than 1
            while(max >= 1)
            {
                max /= 10;
                divider *= 10;
            }
            //We divide the numbers
            if(divider > 1)
                for (int i = 0; i < sortedList.Count; i++)
                {
                    sortedList[i] = sortedList[i] / divider;
                }


            
            // We insert the numbers to the corresponding bucket
            for (int i = 0; i < sortedList.Count; i++)
            {
                int index = (int)(sortedList[i] * NUMBER_OF_BUCKETS);
                buckets[index].Add(sortedList[i]);
            }

            // We sort the inner lists using MergeSort, you can use QuickSort too
            for (int i = 0; i < NUMBER_OF_BUCKETS; i++)
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    buckets[i] = MergeSortFunc(buckets[i]);
                }

            // We insert elements based on if we want them sorted ascending or descending
            if (!sortDescending)
            {
                int k = 0;
                for (int i = 0; i < buckets.Length; i++)
                    for (int j = 0; j < buckets[i].Count; j++)
                        sortedList[k++] = buckets[i][j] * divider;
            }
            else
            {
                int k = sortedList.Count - 1;
                for (int i = 0; i < buckets.Length; i++)
                    for (int j = 0; j < buckets[i].Count; j++)
                        sortedList[k--] = buckets[i][j] * divider;
            }




            return sortedList;
        }

        private static List<double> MergeSortFunc(List<double> list)
        {
            if (list.Count < 2)
                return list;

            int middle = list.Count / 2;

            List<double> left = new List<double>();
            List<double> right = new List<double>();

            for (int i = 0; i < middle; i++)
                left.Add(list[i]);

            for (int i = middle; i < list.Count; i++)
                right.Add(list[i]);

            MergeSortFunc(left);
            MergeSortFunc(right);

            Merge(left, right, list);

            return list;
        }

        private static void Merge(List<double> left, List<double> right, List<double> list)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                    list[k++] = left[i++];
                else list[k++] = right[j++];
            }

            while (i < left.Count)
            {
                list[k++] = left[i++];

            }

            while (j < right.Count)
            {
                list[k++] = right[j++];

            }
        }
    }
}
