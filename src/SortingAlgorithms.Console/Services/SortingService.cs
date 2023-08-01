using System.Diagnostics;
using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

public class SortingService
{
    private ISortAlgorithm[] algorithms;

    public SortingService()
    {
        algorithms = new ISortAlgorithm[]
        {
            new BubbleSort(),
            new InsertionSort(),
            new SelectionSort(),
            new MergeSort(),
            new QuickSort(),
            new HeapSort(),
            new RadixSort()
        };
    }

    public void PerformSorting(int[] arr)
    {
        foreach (var algorithm in algorithms)
        {
            int[] copyArr = (int[])arr.Clone();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] sortedArr = algorithm.Sort(copyArr);

            stopwatch.Stop();

            string algorithmName = algorithm.GetType().Name;
            string sortedArrayString = string.Join(", ", sortedArr);

            System.Console.WriteLine($"Algorithm: {algorithmName}, Sorted Array: [{sortedArrayString}], Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }
}
