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
        private List<double> _unsortedDesc = new();
        private List<double> _unsortedDesc2 = new();

        public BenchmarkDemo()
        {
            var rand = new Random();
             for(int i = 0; i < 10000;i++)
            {
                _unsortedDesc.Add(rand.Next(1000000));
                _unsortedDesc2.Add(rand.Next(1000000));
            }
        }

        [Benchmark]
        public void BuiltInSort() =>
        _unsortedDesc.Sort();
        

        [Benchmark]
        public void BubbleSort() => 
        BubbleSortAlgorithm.SortAscending(_unsortedDesc);

        [Benchmark]
        public void SelectionSort() =>
        SelectionSortAlgorithm.SortAscending(_unsortedDesc);

        [Benchmark]
        public void InsertionSort() =>
        InsertionSortAlgorithm.SortAscending(_unsortedDesc);

        [Benchmark]
        public void MergeSort() =>
        MergeSortAlgorithm.SortAscending(_unsortedDesc2);

    }
}
