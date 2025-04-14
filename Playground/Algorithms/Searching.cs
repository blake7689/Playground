using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algorithms
{
    public class Searching
    {
        public static bool LinearSearch(int[] numArray, int value)
        {
            foreach (int num in numArray)
                if (num.Equals(value))
                    return true;

            return false;
        }

        public static bool LinearSearch_2(int[] numArray, int value)
        {
            if (numArray.Contains(value))
                return true;

            return false;
        }

        public static bool BinarySearch(int[] numArray, int value)
        {
            numArray = Sorting.QuickSort(numArray, 0, numArray.Length-1);
            int start = 0;
            int end = numArray.Length - 1;

            while (start <= end) {
                int middle = (start + end) / 2;

                if (numArray[middle].Equals(value))
                    return true;
                else if (numArray[middle] < value)
                    start = middle - 1;
                else
                    end = middle - 1;
            }

            return false;
        }
    }
}
