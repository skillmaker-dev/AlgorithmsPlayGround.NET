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
    public class SortingBenchmark
    {
        private readonly List<double> _unsorted = new();
        private readonly List<double> _unsorted2 = new();

        public SortingBenchmark()
        {
            var rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double number = rand.NextDouble();
                _unsorted.Add(number);
                _unsorted2.Add(number);
            }
        }

        [Benchmark]
        public void BuiltInSort() =>
        _unsorted2.Sort();


        [Benchmark]
        public void BubbleSort() =>
        BubbleSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void SelectionSort() =>
        SelectionSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void InsertionSort() =>
        InsertionSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void MergeSort() =>
        MergeSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void QuickSort() =>
        QuickSortAlgorithm.SortAscending(_unsorted);

        [Benchmark]
        public void BucketSort() =>
        BucketSortAlgorithm.SortAscending(_unsorted);

    }
}
