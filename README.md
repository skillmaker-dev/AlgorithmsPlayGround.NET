# Algorithms.NET
## Open source library containing the most used sorting and searching algorithms.

In this library you can find the most used sorting & searching algorithms and that are must know for developers, and their implementation, these algorithms are as follows:

### Sorting:
- Bubble Sort
- Insertion Sort
- Selection Sort
- Bucket Sort
- Merge Sort
- Quick Sort
- Counting Sort

### Searching:
- Binary Search
- Ternary Search
- Jump Search
- Linear Search
- Exponential Search


### You can play with these algorithms in ```Algorithms.NET.Debug```

### To view and compare performance of each algorithm, manipulate the code inside :
```SearchingBenchmark.cs``` & ```SortingBenchmark.cs``` 
### To run the benchmarks, comment out :
```var searchingBenchmarkSummary = BenchmarkRunner.Run<SearchingBenchmark>();```
</br>
or 
</br>
 ```var sortingBenchmarkSummary = BenchmarkRunner.Run<SortingBenchmark>();```
 
 Then run the project in ```Release Mode```
 
 ## Benchmark
 
 ### Sorting algorithms comparison: 
 ![SortBenchmark](https://user-images.githubusercontent.com/64654197/188233893-6ca26a71-7a30-4c21-95df-b25bb8719a6e.png)
 
 #### Note :  BuiltIn Sorting algorithm uses an unstable version of QuickSort, and after .NET 4.5 it now uses Insertion sort for n<16, otherwise it starts with Quicksort and switches to Heapsort when the number of partitions (recursion depth?) exceeds 2 * Log^N. Called: Introsort, and that explains why it is the fastest.
 
 ### Searching algorithms comparison: 
 ![SearchingBenchmark](https://user-images.githubusercontent.com/64654197/188233962-b8a86341-007e-4e86-b607-52183f6acac2.png)


 
 ### Here is the explanation of each algorithm: 

### Sorting:
- Bubble Sort : https://www.programiz.com/dsa/bubble-sort
- Insertion Sort : https://www.programiz.com/dsa/insertion-sort
- Selection Sort : https://www.programiz.com/dsa/selection-sort
- Bucket Sort : https://www.programiz.com/dsa/bucket-sort
- Merge Sort : https://www.programiz.com/dsa/merge-sort
- Quick Sort : https://www.programiz.com/dsa/quick-sort
- Counting Sort : https://www.programiz.com/dsa/counting-sort

### Searching:
- Binary Search : https://www.programiz.com/dsa/binary-search
- Ternary Search :  Same as binary search but with dividing in 3 sections.
- Jump Search : https://en.wikipedia.org/wiki/Jump_search
- Linear Search : https://www.programiz.com/dsa/linear-search
- Exponential Search : https://en.wikipedia.org/wiki/Exponential_search
