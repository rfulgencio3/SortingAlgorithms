using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

// Heap Sort
public class HeapSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }

        return arr;
    }

    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int leftChild = 2 * i + 1;
        int rightChild = 2 * i + 2;

        if (leftChild < n && arr[leftChild] > arr[largest])
        {
            largest = leftChild;
        }

        if (rightChild < n && arr[rightChild] > arr[largest])
        {
            largest = rightChild;
        }

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }
}
