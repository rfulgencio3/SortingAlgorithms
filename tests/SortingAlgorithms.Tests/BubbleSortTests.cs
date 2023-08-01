using System;
using System.Drawing;
using SortingAlgorithms.Console.Services;
using Xunit;

namespace SortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        private readonly BubbleSort bubbleSort;

        public BubbleSortTests()
        {
            bubbleSort = new BubbleSort();
        }

        [Fact]
        public void BubbleSort_SortEmptyArray_ReturnsEmptyArray()
        {
            int[] arr = new int[0];
            int[] expected = new int[0];

            int[] result = bubbleSort.Sort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BubbleSort_SortUnsortedArray_ReturnsSortedArray()
        {
            int[] arr = new int[5];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(+ 1);
            }
            int[] expected = arr.OrderBy(x => x).ToArray();

            int[] result = bubbleSort.Sort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BubbleSort_SortSortedArray_ReturnsSameArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            int[] result = bubbleSort.Sort(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BubbleSort_SortReverseSortedArray_ReturnsSortedArray()
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] result = bubbleSort.Sort(arr);

            Assert.Equal(expected, result);
        }
    }
}
