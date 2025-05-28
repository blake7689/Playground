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

        public static string FindAndRemovePalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            Dictionary<string, int> palindromes = new Dictionary<string, int>();

            for (int i = 0; i < charArray.Length; i++) //starting element
            {
                for (int j = 1; j <= charArray.Length - i; j++) //length
                {
                    string subString = s.Substring(i, j);
                    int subCount = CheckForPalindrome(subString);

                    if (!subCount.Equals(0))
                    {
                        palindromes.Add($"{i},{j}", subCount);
                    }
                }
            }

            if (!palindromes.Count.Equals(0))
                return RemoveLargestPalindrome(palindromes, s);
            else
                return "Error";
        }

        public static int CheckForPalindrome(string subString)
        {
            if (subString.Equals(string.Empty))
                return 0;

            char[] charArray = subString.ToCharArray();
            StringBuilder reverseSubString = new StringBuilder();

            for (int i = charArray.Length - 1; i >= 0; i--) //reverse
                reverseSubString.Append(charArray[i]);

            if (reverseSubString.Equals(subString))
                return charArray.Length;
            else
                return 0;
        }

        public static bool CheckForPalindrome_2(string subString)
        {
            if (subString.Equals(string.Empty))
                return false;

            char[] charArray = subString.ToCharArray();
            StringBuilder reverseSubString = new StringBuilder();

            for (int i = charArray.Length - 1; i >= 0; i--) //reverse
                reverseSubString.Append(charArray[i]);

            return reverseSubString.Equals(subString);
        }

        public static string RemoveLargestPalindrome(Dictionary<string, int> palindromes, string s)
        {
            if (palindromes.Count.Equals(0) || s.Equals(string.Empty))
                return s;

            string[] palindromeKey = palindromes.MaxBy(p => p.Value).Key.Split(',');
            return s.Remove(Int32.Parse(palindromeKey[0]), Int32.Parse(palindromeKey[1]));
        }

        public static bool CheckForAvailableMatches(Queue<int> students, Queue<int> sandwiches)
        {
            if (!students.TryPeek(out int result))
                return false;

            return students.Contains(sandwiches.Peek());
        }

        public static List<int> MergeLists(List<int> left, List<int> right)
        {
            int length = left.Count + right.Count;

            List<int> result = new List<int>(length);

            int leftIndex, rightIndex, resultIndex;
            leftIndex = rightIndex = resultIndex = 0;

            while ((leftIndex < left.Count) || (rightIndex < right.Count))
            {
                if ((leftIndex < left.Count) && (rightIndex < right.Count))
                {
                    if (left[leftIndex] <= right[rightIndex])
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        result.Add(right[rightIndex]);
                        rightIndex++;
                        resultIndex++;
                    }
                }
                else if (leftIndex < left.Count)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                    resultIndex++;
                }
                else if (rightIndex < right.Count)
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                    resultIndex++;
                }
            }
            return result;
        }

        public static Dictionary<char, int> GetCharOccurances(string s)
        {
            Dictionary<char, int> charOccurances = [];
            foreach (char c in s)
            {
                if (charOccurances.TryGetValue(c, out int value))
                    charOccurances[c] = ++value;
                else
                    charOccurances.Add(c, 1);
            }

            return charOccurances;
        }

        public static int GetLongestSubstring(string s, int k, Dictionary<char, int> charOccurances)
        {
            foreach (var occurance in charOccurances)
            {
                if (occurance.Value < k)
                {
                    char c = occurance.Key;
                    int maxLength = 0;

                    foreach (string substring in s.Split(c))
                        maxLength = Math.Max(maxLength, LeetcodeFunctions.LongestSubstring(substring, k));

                    return maxLength;
                }
            }
            return s.Length;
        }

        public static bool IsValidMovement(int fromRow, int fromColumn, int toRow, int toColumn)
        {
            if (toRow < (fromRow - 1) || toRow > (fromRow + 1))
                return false;

            if (toColumn < (fromColumn - 1) || toColumn > (fromColumn + 2))
                return false;

            return true;
        }

        public static bool CheckIfRouteExists(int curRow, int curCol, int toRow, int toColumn, bool[,] mapMatrix, bool[,] visited)
        {
            try
            {
                if (curRow == toRow && curCol == toColumn)
                    return true;

                if (!mapMatrix[curRow, curCol])
                    return false;

                if (!mapMatrix[toRow, toColumn])
                    return false;

                if (visited[curRow, curCol])
                    return false;

                visited[curRow, curCol] = true;

                List<string> validMovements = GetValidMovements(curRow, curCol, mapMatrix);

                if (validMovements.Count == 0)
                    return false;

                foreach (string newPositions in validMovements)
                {
                    int newRow = int.Parse(newPositions.Split(',')[0]);
                    int newCol = int.Parse(newPositions.Split(',')[1]);

                    if (CheckIfRouteExists(newRow, newCol, toRow, toColumn, mapMatrix, visited))
                        return true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

            return false;
        }

        public static List<string> GetValidMovements(int curRow, int curCol, bool[,] mapMatrix)
        {
            List<string> validMovements = new List<string>();

            if (TryMovement(curRow - 1, curCol, mapMatrix)) //down
                validMovements.Add((curRow - 1) + "," + curCol);

            if (TryMovement(curRow, curCol - 1, mapMatrix)) //left
                validMovements.Add(curRow + "," + (curCol - 1));

            if (TryMovement(curRow + 1, curCol, mapMatrix)) //up
                validMovements.Add((curRow + 1) + "," + curCol);

            if (TryMovement(curRow, curCol + 1, mapMatrix)) //right
                validMovements.Add(curRow + "," + (curCol + 1));

            return validMovements;
        }

        public static bool TryMovement(int newRow, int newCol, bool[,] mapMatrix)
        {
            try
            {
                if (mapMatrix[newRow, newCol])
                    return true;
                else
                    return false;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
