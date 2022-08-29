using Algorithms.NET.Sorting.BubbleSort;
using Algorithms.NET.Sorting.BucketSort;
using Algorithms.NET.Sorting.InsertionSort;
using Algorithms.NET.Sorting.MergeSort;
using Algorithms.NET.Sorting.QuickSort;
using Algorithms.NET.Sorting.SelectionSort;
using BenchmarkDotNet.Attributes;

namespace Algorithms.NET.Debug
{
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        private List<double> _unsorted = new();
        private List<double> _unsorted2 = new();

        public BenchmarkDemo()
        {
            var rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                _unsorted.Add(rand.NextDouble());
                _unsorted2.Add(rand.Next(1000000));
            }
        }

        //[Benchmark]
        public void BuiltInSort() =>
        _unsorted2.Sort();


        //[Benchmark]
        public void BubbleSort() =>
        BubbleSortAlgorithm.SortAscending(_unsorted);

        //[Benchmark]
        public void SelectionSort() =>
        SelectionSortAlgorithm.SortAscending(_unsorted);

        //[Benchmark]
        public void InsertionSort() =>
        InsertionSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void MergeSort() =>
        MergeSortAlgorithm.SortAscending(_unsorted);

        //[Benchmark]
        public void QuickSort() =>
        QuickSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void BucketSort() =>
        BucketSortAlgorithm.SortAscending(_unsorted);

    }
}
