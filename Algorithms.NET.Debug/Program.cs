using Algorithms.NET.Debug;
using BenchmarkDotNet.Running;

List<double> unsortedAsc = new() { 0, 1, 2, 3, 4, 5 };
List<double> unsortedDesc = new() { 5, 4, 3, 2, 1, 0 };
List<double> unsortedRand = new() { 8, 9, 3, 3, 7, 1 };
List<double> unsortedLessThan1 = new() { .8, .9, .3, .3, .1,0 };

var sortedDesc = Algorithms.NET.Sorting.MergeSort.MergeSortAlgorithm.SortDescendingParallel(unsortedAsc);
var sortedAsc = Algorithms.NET.Sorting.BucketSort.BucketSortAlgorithm.SortAscending(unsortedLessThan1);


Console.WriteLine(Algorithms.NET.Searching.LinearSearch.LinearSearchAlgorithm.Search(4, unsortedAsc));
Console.WriteLine();
Console.WriteLine(Algorithms.NET.Searching.BinarySearch.BinarySearchAlgorithm.SearchRecursive(0, unsortedAsc));
Console.WriteLine();
Console.WriteLine(Algorithms.NET.Searching.BinarySearch.BinarySearchAlgorithm.SearchIterative(0, unsortedAsc));
Console.WriteLine();

Console.WriteLine(Algorithms.NET.Searching.TernarySearch.TernarySearchAlgorithm.Search(8, unsortedAsc));
Console.WriteLine();
Console.WriteLine(Algorithms.NET.Searching.JumpSearch.JumpSearchAlgorithm.Search(0, unsortedAsc));
Console.WriteLine();
Console.WriteLine(Algorithms.NET.Searching.ExponentialSearch.ExponentialSearchAlgorithm.Search(5, unsortedAsc));
Console.WriteLine();

foreach (var item in sortedDesc)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in sortedAsc)
{
    Console.WriteLine(item);
}



var sortingBenchmarkSummary = BenchmarkRunner.Run<SortingBenchmark>();
//var searchingBenchmarkSummary = BenchmarkRunner.Run<SearchingBenchmark>();






