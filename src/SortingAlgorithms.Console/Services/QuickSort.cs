using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

// Quick Sort
public class QuickSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        return QuickSortRecursive(arr, 0, arr.Length - 1);
    }

    private int[] QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSortRecursive(arr, low, partitionIndex - 1);
            QuickSortRecursive(arr, partitionIndex + 1, high);
        }

        return arr;
    }

    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }
}
