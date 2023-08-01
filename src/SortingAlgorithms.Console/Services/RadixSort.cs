﻿using SortingAlgorithms.Console.Services.Interface;

namespace SortingAlgorithms.Console.Services;

public class RadixSort : ISortAlgorithm
{
    public int[] Sort(int[] arr)
    {
        int max = GetMax(arr);

        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(arr, exp);
        }

        return arr;
    }

    private int GetMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    private void CountingSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
        {
            count[(arr[i] / exp) % 10]++;
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            output[count[(arr[i] / exp) % 10] - 1] = arr[i];
            count[(arr[i] / exp) % 10]--;
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }
}
