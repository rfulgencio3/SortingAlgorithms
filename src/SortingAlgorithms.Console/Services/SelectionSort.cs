using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

// Selection Sort
public class SelectionSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
        return arr;
    }
}
