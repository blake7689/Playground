using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class HelperFunctions
    {
        public static int SumSpan(ReadOnlySpan<int> source)
        {
            var sum = 0;
            foreach (var item in source)
                sum += item;
            return sum;
        }

        public static int SumArray(int[] source)
        {
            var sum = 0;
            foreach (var item in source)
                sum += item;
            return sum;
        }

        public static int[] FindAllIndexof<T>(this IEnumerable<T> values, T val)
        {
            return values.Select((b, i) => object.Equals(b, val) ? i : -1).Where(i => i != -1).ToArray();
        }

        public static bool CheckListForStrictlyIncreasingInts(List<int> numsList)
        {
            for (int k = 0; k < numsList.Count - 1; k++)
            {
                if (numsList[k] >= numsList[k + 1]) 
                    return false;
            }
            return true;
        }
    }
}
