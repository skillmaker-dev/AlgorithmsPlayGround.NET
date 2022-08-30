using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NET.Debug
{
    [MemoryDiagnoser]
    public class SearchingBenchmark
    {
        private readonly List<int> _list = new();
        private readonly List<double> _sortedList = new();
        public SearchingBenchmark()
        {
            Random random = new();
            for(int i = 0; i <= 10000; i++)
            {
                _list.Add(random.Next(1000));
                _sortedList.Add(i);
            }
        }

        //Here we test the worst case scenario

        [Benchmark]
        public void LinearSearch() => Algorithms.NET.Searching.LinearSearch.LinearSearchAlgorithm.Search(10000,_sortedList);

        [Benchmark]
        public void BinarySearchRecursive() => Algorithms.NET.Searching.BinarySearch.BinarySearchAlgorithm.SearchRecursive(0, _sortedList);

        [Benchmark]
        public void BinarySearchIterative() => Algorithms.NET.Searching.BinarySearch.BinarySearchAlgorithm.SearchIterative(0, _sortedList);

        [Benchmark]
        public void TernarySearchRecursive() => Algorithms.NET.Searching.TernarySearch.TernarySearchAlgorithm.Search(0, _sortedList);

        [Benchmark]
        public void JumpSearch() => Algorithms.NET.Searching.JumpSearch.JumpSearchAlgorithm.Search(10000, _sortedList);

        [Benchmark]
        public void ExponentialSearch() => Algorithms.NET.Searching.ExponentialSearch.ExponentialSearchAlgorithm.Search(10000, _sortedList);
    }
}
