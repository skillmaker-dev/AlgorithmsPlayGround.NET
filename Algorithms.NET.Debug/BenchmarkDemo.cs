using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.NET.Sorting.BubbleSort;
using Algorithms.NET.Sorting.SelectionSort;
using Algorithms.NET.Sorting.InsertionSort;
using Algorithms.NET.Sorting.MergeSort;

namespace Algorithms.NET.Debug
{
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        private readonly List<double> _unsortedAsc = new();

        public BenchmarkDemo()
        {
             for(int i = 0; i < 1000;i++)
            {
                _unsortedAsc.Add((double)i);
            }
        }

        [Benchmark]
        public void BubbleSort() => 
        BubbleSortAlgorithm.SortDescending(_unsortedAsc);

        [Benchmark]
        public void SelectionSort() =>
        SelectionSortAlgorithm.SortDescending(_unsortedAsc);

        [Benchmark]
        public void InsertionSort() =>
        InsertionSortAlgorithm.SortDescending(_unsortedAsc);

        [Benchmark]
        public void MergeSort() =>
        MergeSortAlgorithm.SortDescending(_unsortedAsc);

    }
}
