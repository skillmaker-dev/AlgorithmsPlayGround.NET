using Algorithms.NET.Debug;
using BenchmarkDotNet.Running;

List<double> unsortedAsc = new() { 0, 1, 2, 3, 4, 5 };
List<double> unsortedDesc = new() { 5, 4, 3, 2, 1, 0 };
List<double> unsortedRand = new() { 8, 9, 3, 3, 100000, 1 };
List<double> unsorted01 = new() { .8, .9, .3, .3, .1,0 };

//var sortedDesc = Algorithms.NET.Sorting.MergeSort.MergeSortAlgorithm.SortDescending(unsortedAsc);
var sortedAsc = Algorithms.NET.Sorting.BucketSort.BucketSortAlgorithm.SortAscending(unsorted01);
var sortedDesc = Algorithms.NET.Sorting.BucketSort.BucketSortAlgorithm.SortDescending(unsorted01);
//var sortedDesc = Algorithms.NET.Sorting.CountingSort.CountingSortAlgorithm.SortDescending(unsortedRand.ToArray());


foreach (var item in sortedDesc)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in sortedAsc)
{
    Console.WriteLine(item);
}

//List<double> _unsortedAsc = new();
//var rand = new Random();
//for (int i = 0; i < 1000000; i++)
//{
//    _unsortedAsc.Add(rand.Next(1000000));
//}

var summary = BenchmarkRunner.Run<BenchmarkDemo>();






