using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Playground.Algorithms
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] unsortedArray)
        {
            int[] sortedArray = unsortedArray;
            bool hasChanged;
            do
            {
                hasChanged = false;
                for (int i = 0; i < sortedArray.Length - 1; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        (sortedArray[i + 1], sortedArray[i]) = (sortedArray[i], sortedArray[i + 1]);
                        hasChanged = true;
                    }
                }
            } while (hasChanged);

            return sortedArray;
        }

        public static int[] InsertionSort(int[] intArray)
        {
            int[] sortedArray = intArray;

            for (int i = 1; i < sortedArray.Length; i++)
            {
                int key = sortedArray[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < sortedArray[j])
                    {
                        sortedArray[j + 1] = sortedArray[j];
                        j--;
                        sortedArray[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return sortedArray;
        }

        public static List<int> MergeSort(List<int> nums)
        {
            List<int> left, right;

            if (nums.Count <= 1) { return nums; }

            int midpoint = nums.Count / 2;
            left = new List<int>(midpoint);

            if ((nums.Count % 2) == 0)
            {
                right = new List<int>(midpoint);
            }
            else { right = new List<int>(midpoint + 1); }

            for (int i = 0; i < midpoint; i++)
            {
                left.Add(nums[i]);
            }

            for (int j = midpoint; j < nums.Count; j++)
            {
                right.Add(nums[j]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            List<int> result = HelperFunctions.MergeLists(left, right);
            return result;

        }

        public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var l = leftIndex;
            var r = rightIndex;
            var pivot = array[leftIndex];
            while (l <= r)
            {
                while (array[l] < pivot) { l++; }
                while (array[r] > pivot) { r--; }

                if (l <= r)
                {
                    (array[r], array[l]) = (array[l], array[r]);
                    l++;
                    r--;
                }
            }

            if (leftIndex < r)
                QuickSort(array, leftIndex, r);
            if (l < rightIndex)
                QuickSort(array, l, rightIndex);
            return array;
        }
    }
}
