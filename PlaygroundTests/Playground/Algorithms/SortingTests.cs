using Playground;
using Playground.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundTests.Playground.AlgorithmsAndDataStructuresTests
{
    public class SortingTests
    {
        [Fact]
        public void BubbleSort_UnorderedArray_ReturnsSortedArray()
        {
            //arrange
            int[] unsortedArray = [1, 2, 10, 5, 8, 3, 6, 1, 8, 4];
            int[] expectedResult = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.BubbleSort(unsortedArray);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void BubbleSort_OrderedArray_ReturnsSameArray()
        {
            //arrange
            int[] sortedArray = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.BubbleSort(sortedArray);

            //assert
            Assert.Equal(sortedArray, result);
        }

        [Fact]
        public void InsertionSort_UnorderedArray_ReturnsSortedArray()
        {
            //arrange
            int[] unsortedArray = [1, 2, 10, 5, 8, 3, 6, 1, 8, 4];
            int[] expectedResult = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.InsertionSort(unsortedArray);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void InsertionSort_OrderedArray_ReturnsSameArray()
        {
            //arrange
            int[] sortedArray = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.InsertionSort(sortedArray);

            //assert
            Assert.Equal(sortedArray, result);
        }

        [Fact]
        public void MergeSort_UnorderedArray_ReturnsSortedArray()
        {
            //arrange
            List<int> unsortedArray = [1, 2, 10, 5, 8, 3, 6, 1, 8, 4];
            List<int> expectedResult = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            List<int> result = Sorting.MergeSort(unsortedArray);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MergeSort_OrderedArray_ReturnsSameArray()
        {
            //arrange
            List<int> sortedArray = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            List<int> result = Sorting.MergeSort(sortedArray);

            //assert
            Assert.Equal(sortedArray, result);
        }

        [Fact]
        public void QuickSort_UnorderedArray_ReturnsSortedArray()
        {
            //arrange
            int[] unsortedArray = [1, 2, 10, 5, 8, 3, 6, 1, 8, 4];
            int[] expectedResult = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.QuickSort(unsortedArray, 0, unsortedArray.Length-1);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void QuickSort_OrderedArray_ReturnsSameArray()
        {
            //arrange
            int[] sortedArray = [1, 1, 2, 3, 4, 5, 6, 8, 8, 10];

            //act
            int[] result = Sorting.QuickSort(sortedArray, 0, sortedArray.Length-1);

            //assert
            Assert.Equal(sortedArray, result);
        }
    }
}
