using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.NET.Sorting.BubbleSort;

namespace Algorithms.NET.Debug
{
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        private readonly List<double> _unsortedAsc = new() { 0D, 1D, 2D, 3D, 4D, 5D,6D,7D,8D,9D,10D,11D,12D,13D,14D,15D,16D,17D,18D,19D,20D };

        [Benchmark]
        public void Sort() => 
        BubbleSortAlgorithm.SortDescending(_unsortedAsc);

    }
}
