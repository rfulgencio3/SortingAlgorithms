using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

// Insertion Sort
public class InsertionSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        return arr;
    }
}
