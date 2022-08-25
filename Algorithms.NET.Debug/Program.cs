List<double> unsortedAsc = new() { 0,1,2,3,4,5 };
List<double> unsortedDesc = new() { 5,4,3,2,1,0 };

var sortedDesc = Algorithms.NET.BubbleSort.BubbleSort.SortDescending(unsortedAsc);
var sortedAsc = Algorithms.NET.BubbleSort.BubbleSort.SortAscending(unsortedDesc);


foreach(var item in sortedDesc)
{
    Console.WriteLine(item);
}
Console.WriteLine();
foreach (var item in sortedAsc)
{
    Console.WriteLine(item);
}