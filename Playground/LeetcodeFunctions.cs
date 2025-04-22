using Playground.Algorithms;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Playground
{
    public class LeetcodeFunctions
    {
        public static int LongestSubstring(string s, int k)
        {
            if (s.Length < k) return 0;

            Dictionary<char, int> charOccurances = HelperFunctions.GetCharOccurances(s);

            if (!charOccurances.Any(c => c.Value >= k))
                return 0;

            return HelperFunctions.GetLongestSubstring(s, k, charOccurances);
        }

        public static bool LemonadeChange(int[] bills)
        {
            int cost = 5;
            List<int> registerBills = [];
            Queue<int> billQueue = new Queue<int>(bills);

            while (billQueue.Count > 0)
            {
                if (!LemonadeTransaction(ref registerBills, billQueue.Dequeue(), cost))
                    return false;
            }

            return true;
        }

        public static bool LemonadeTransaction(ref List<int> registerBills, int bill, int cost)
        {
            registerBills.Add(bill);
            int changeDue = bill - cost;

            if (changeDue == 0) { return true; }

            List<int> validRegisterBills = registerBills.Where(r => r <= changeDue).ToList();
            validRegisterBills.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < validRegisterBills.Count && changeDue > 0; i++)
            {
                if (validRegisterBills[i] <= changeDue)
                {
                    changeDue -= validRegisterBills[i];
                    registerBills.Remove(validRegisterBills[i]);
                }
            }

            return changeDue == 0;
        } //LemonadeChange

        public static bool IsFascinating(int n)
        {
            List<int> nums = [];
            int[] correctNums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            string s = string.Format("{0}{1}{2}", n, n * 3, n * 2);

            foreach (char c in s)
                nums.Add(int.Parse(c.ToString()));

            return correctNums.SequenceEqual(Sorting.BubbleSort(nums.ToArray()));
        }

        public static bool IsFascinating_2(int n)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(n).Append(n*2).Append(n*3);

            if (!sb.ToString().Length.Equals(9))
                return false;

            for (int i = 1; i <= 9; i++)
                if (!sb.ToString().Contains($"{i}"))
                    return false;

            return true;
        }

        public static int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new(students);
            Queue<int> sandwichQueue = new(sandwiches);

            while (HelperFunctions.CheckForAvailableMatches(studentQueue, sandwichQueue))
            {
                if (studentQueue.Peek().Equals(sandwichQueue.Peek())) 
                {
                    studentQueue.Dequeue();
                    sandwichQueue.Dequeue();
                }
                else
                    studentQueue.Enqueue(studentQueue.Dequeue());
            }

            return studentQueue.Count();
        }

        public static int RemovePalindromeSub(string s)
        {
            int count = 0;
            string tempS = s;

            while (!tempS.Equals(string.Empty))
            {
                tempS = HelperFunctions.FindAndRemovePalindrome(tempS);

                if (tempS.Equals("Error"))
                    return 0;

                count++;
            }

            return count;
        }

        public static int RemovePalindromeSub_2(string s)
        {
            if (s.Equals(string.Empty))
                return 0;

            if (HelperFunctions.CheckForPalindrome_2(s))
                return 1;
            else
                return 2;
        }

        public static int IncremovableSubarrayCount(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = 1; j <= nums.Length - i; j++)
                {
                    List<int> numsList = nums.ToList();
                    numsList.RemoveRange(i, j);
                    if (HelperFunctions.CheckListForStrictlyIncreasingInts(numsList)) count++;
                }
            }
            return count;
        }

        public static int SubarraySum2(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int start = Math.Max(0, i - nums[i]);
                total += HelperFunctions.SumSpan(nums.AsSpan().Slice(start, i + 1 - start));
            }
            return total;
        }

        public static int SubarraySum(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int start = Math.Max(0, i - nums[i]);
                var subNums = nums.Skip(start).Take(i + 1 - start);
                total += subNums.Sum();
            }
            return total;
        }

        public static int CountPoints(string rings)
        {
            List<string> ringList = new List<string>();

            for (int i = 0; i <= rings.Length; i++)
            {
                if (i % 2 != 0)
                {
                    ringList.Add(rings.Substring(i - 1, 2));
                }
            }

            var rodGroups = ringList.GroupBy(r => r.Substring(1, 1));

            int count = 0;
            foreach (var rodGroup in rodGroups)
            {
                bool foundR = false, foundG = false, foundB = false;
                foreach (var rod in rodGroup)
                {
                    if (rod.Contains('R'))
                    {
                        foundR = true;
                    }
                    else if (rod.Contains('G'))
                    {
                        foundG = true;
                    }
                    else if (rod.Contains('B'))
                    {
                        foundB = true;
                    }
                }

                if (foundR && foundG && foundB)
                    count++;
            }

            return count;
        }

        public static int RemoveStones(int[][] stones)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int stonesRemoved = 0;

            while (!stones.Length.Equals(0))
            {
                for (int i = 0; i < stones.Length; i++)
                {
                    int[] stone = stones[i];
                    int count = 0;

                    foreach (int[] otherStones in stones.Where(s => !s.Equals(stone)))
                    {
                        if (otherStones[0].Equals(stone[0]) || otherStones[1].Equals(stone[1])) count++;
                    }

                    if (!count.Equals(0)) map.Add(i, count);
                }

                if (map.All(s => s.Value.Equals(0))) return stonesRemoved;

                int stoneIndexToRemove = map.FirstOrDefault(m => m.Value.Equals(map.Values.Min())).Key;

                List<int[]> stoneList = new List<int[]>(stones);
                stoneList.RemoveAt(stoneIndexToRemove);
                stones = stoneList.ToArray();

                stonesRemoved++;

                map.Clear();
            }

            return -1;
        }

        public static bool DoesAliceWin(string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            if (!s.Any(c => vowels.Contains(c))) return false;
            return true;
        }

        public static int[] PlusOne(int[] digits)
        {
            int[] tempDegits = new int[digits.Length];
            Array.Copy(digits, tempDegits, digits.Length);
            tempDegits[tempDegits.Length - 1]++;

            Stack<int> digitStack = new Stack<int>();
            bool carryOne = false;

            for (int i = tempDegits.Length - 1; i >= 0; i--)
            {
                int currDigit = tempDegits[i];

                //add carried one
                if (carryOne) currDigit++;

                if (currDigit > 9)
                {
                    digitStack.Push(currDigit - 10);
                    carryOne = true;
                }
                else
                {
                    digitStack.Push(currDigit);
                    carryOne = false;
                }
            }

            //add one for carry past array size
            if (carryOne)
            {
                digitStack.Push(1);
            }

            return digitStack.ToArray();
        }

        public static int[] PlusOneV2(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;

            return digits;
        }

        public static long MaximumSumOfHeights(int[] heights)
        {
            Dictionary<int, int[]> indexOfHieghts = new Dictionary<int, int[]>();
            //int[] peakIndexes = heights.FindAllIndexof(heights.Max());

            //handle multi peak indexes
            for (int peakIndex = 0; peakIndex < heights.Length; peakIndex++)
            {
                int[] heightsCopy = new int[heights.Length];
                Array.Copy(heights, heightsCopy, heights.Length);

                //left of peak
                for (int i = peakIndex - 1; i >= 0; i--)
                {
                    if (heightsCopy[i] > heightsCopy[i + 1])
                        heightsCopy[i] = heightsCopy[i + 1];
                }

                //right of peak
                for (int i = peakIndex + 1; i < heightsCopy.Length; i++)
                {
                    if (heightsCopy[i] > heightsCopy[i - 1])
                        heightsCopy[i] = heightsCopy[i - 1];
                }

                indexOfHieghts.Add(peakIndex, heightsCopy);
            }

            //find the largest sum
            List<long> sums = new List<long>();
            foreach (KeyValuePair<int, int[]> indexOfHieght in indexOfHieghts)
            {
                sums.Add(indexOfHieght.Value.Select(i => (long)i).Aggregate((a, b) => a + b));
            }

            return sums.Max();
        }

        public static bool ValidMountainArray(int[] arr)
        {
            bool incline = false, decline = false;

            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i] > arr[i - 1] && decline) || arr[i].Equals(arr[i - 1]))
                {
                    return false;
                }
                else if (arr[i] > arr[i - 1] && !incline)
                {
                    incline = true;
                }
                else if (arr[i] < arr[i - 1] && !decline)
                {
                    decline = true;
                }

                if (decline && !incline) return false;
            }

            if (!incline) return false;
            if (!decline) return false;

            return true;
        }

        public static int FindMiddleIndexLeftMost(int[] nums)
        {
            for (int middleIndex = 0; middleIndex < nums.Length; middleIndex++)
            {
                int leftRunningCount = 0, rightRunningCount = 0;

                for (int i = 0; i < middleIndex; i++)
                {
                    leftRunningCount += nums[i];
                }

                for (int i = nums.Length - 1; i > middleIndex; i--)
                {
                    rightRunningCount += nums[i];
                }

                if (leftRunningCount.Equals(rightRunningCount))
                {
                    return middleIndex;
                }
            }
            return -1;
        }

        public static int FindMiddleIndexRightMost(int[] nums)
        {
            for (int middleIndex = nums.Length - 1; middleIndex >= 0; middleIndex--)
            {
                int leftRunningCount = 0, rightRunningCount = 0;

                for (int i = 0; i < middleIndex; i++)
                {
                    leftRunningCount += nums[i];
                }

                for (int i = nums.Length - 1; i > middleIndex; i--)
                {
                    rightRunningCount += nums[i];
                }

                if (leftRunningCount.Equals(rightRunningCount))
                {
                    return middleIndex;
                }
            }
            return -1;
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>();
            pairs.Add(')', '(');
            pairs.Add(']', '[');
            pairs.Add('}', '{');

            foreach (char c in s.ToCharArray())
            {
                if (pairs.Any(m => m.Value.Equals(c)))
                {
                    stack.Push(c);
                }
                else
                {
                    char opening = pairs[c];
                    if (stack.Count.Equals(0) || !stack.Peek().Equals(opening))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count.Equals(0);
        }
    }
}
