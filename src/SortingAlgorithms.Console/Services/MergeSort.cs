using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

public class MergeSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];

        Array.Copy(arr, 0, left, 0, middle);
        Array.Copy(arr, middle, right, 0, arr.Length - middle);

        left = Sort(left);
        right = Sort(right);

        return Merge(left, right);
    }

    private int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int leftIndex = 0, rightIndex = 0, resultIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                result[resultIndex++] = left[leftIndex++];
            }
            else
            {
                result[resultIndex++] = right[rightIndex++];
            }
        }

        while (leftIndex < left.Length)
        {
            result[resultIndex++] = left[leftIndex++];
        }

        while (rightIndex < right.Length)
        {
            result[resultIndex++] = right[rightIndex++];
        }

        return result;
    }
}
