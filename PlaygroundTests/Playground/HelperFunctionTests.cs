using Playground;
using Playground.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundTests.Playground
{
    public class HelperFunctionTests
    {
        [Fact]
        public void SumSpan_RegularArray_ReturnsSum()
        {
            //arrange
            int[] array = [1, 2, 3];

            //act
            int result = HelperFunctions.SumSpan(array.AsSpan());

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void SumSpan_EmptyArray_ReturnsZero()
        {
            //arrange
            int[] array = [];

            //act
            int result = HelperFunctions.SumSpan(array.AsSpan());

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void SumArray_RegularArray_ReturnsSum()
        {
            //arrange
            int[] array = [1, 2, 3];

            //act
            int result = HelperFunctions.SumArray(array);

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void SumArray_EmptyArray_ReturnsZero()
        {
            //arrange
            int[] array = [];

            //act
            int result = HelperFunctions.SumArray(array);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FindAndRemovePalindrome_EmptyString_ReturnsError()
        {
            //arrange
            string s = string.Empty;

            //act
            string result = HelperFunctions.FindAndRemovePalindrome(s);

            //assert
            Assert.Equal("Error", result);
        }


        [Fact]
        public void FindAndRemovePalindrome_ValidString_Returnsbb()
        {
            //arrange
            string s = "ababb";

            //act
            string result = HelperFunctions.FindAndRemovePalindrome(s);

            //assert
            Assert.Equal("bb", result);
        }

        [Fact]
        public void CheckForPalindrome_EmptyString_ReturnsZero()
        {
            //arrange
            string s = string.Empty;

            //act
            int result = HelperFunctions.CheckForPalindrome(s);

            //assert
            Assert.Equal(0, result);
        }


        [Fact]
        public void CheckForPalindrome_NonPalindromeString_ReturnsZero()
        {
            //arrange
            string s = "baaa";

            //act
            int result = HelperFunctions.CheckForPalindrome(s);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CheckForPalindrome_ValidPalindromeString_ReturnsLength()
        {
            //arrange
            string s = "aba";

            //act
            int result = HelperFunctions.CheckForPalindrome(s);

            //assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void CheckForPalindrome_2_EmptyString_ReturnsFalse()
        {
            //arrange
            string s = string.Empty;

            //act
            bool result = HelperFunctions.CheckForPalindrome_2(s);

            //assert
            Assert.False(result);
        }


        [Fact]
        public void CheckForPalindrome_2_NonPalindromeString_ReturnsFalse()
        {
            //arrange
            string s = "baaa";

            //act
            bool result = HelperFunctions.CheckForPalindrome_2(s);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void CheckForPalindrome_2_ValidPalindromeString_ReturnsTrue()
        {
            //arrange
            string s = "aba";

            //act
            bool result = HelperFunctions.CheckForPalindrome_2(s);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void RemoveLargestPalindrome_EmptyDictionary_ReturnsFalse()
        {
            //arrange
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string s = "abaa";

            //act
            string result = HelperFunctions.RemoveLargestPalindrome(dict, s);

            //assert
            Assert.Equal(s, result);
        }


        [Fact]
        public void RemoveLargestPalindrome_EmptyString_ReturnsFalse()
        {
            //arrange
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "0,1", 1 },
                { "0,3", 3 },
                { "1,1", 1 },
                { "2,1", 1 },
                { "2,2", 2 },
                { "3,1", 1 }
            };
            string s = string.Empty;

            //act
            string result = HelperFunctions.RemoveLargestPalindrome(dict, s);

            //assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveLargestPalindrome_EmptyStringAndDictionary_ReturnsFalse()
        {
            //arrange
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string s = string.Empty;

            //act
            string result = HelperFunctions.RemoveLargestPalindrome(dict, s);

            //assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveLargestPalindrome_ValidPalindromeString_ReturnsWithoutLargest()
        {
            //arrange
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "0,1", 1 },
                { "0,3", 3 },
                { "1,1", 1 },
                { "2,1", 1 },
                { "2,2", 2 },
                { "3,1", 1 }
            };
            string s = "abaa";

            //act
            string result = HelperFunctions.RemoveLargestPalindrome(dict, s);

            //assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void CheckForAvailableMatches_EmptyStudentQueue_ReturnsFalse()
        {
            //arrange
            Queue<int> studentQueue = new Queue<int>();
            Queue<int> sandwichQueue = new Queue<int>();

            //act
            bool result = HelperFunctions.CheckForAvailableMatches(studentQueue, sandwichQueue);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void CheckForAvailableMatches_StudentMatchingSandwich_Returnstrue()
        {
            //arrange
            Queue<int> studentQueue = new Queue<int>();
            studentQueue.Enqueue(1);
            Queue<int> sandwichQueue = new Queue<int>();
            sandwichQueue.Enqueue(1);

            //act
            bool result = HelperFunctions.CheckForAvailableMatches(studentQueue, sandwichQueue);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void CheckForAvailableMatches_StudentNotMatchingSandwich_Returnstrue()
        {
            //arrange
            Queue<int> studentQueue = new Queue<int>();
            studentQueue.Enqueue(1);
            Queue<int> sandwichQueue = new Queue<int>();
            sandwichQueue.Enqueue(0);

            //act
            bool result = HelperFunctions.CheckForAvailableMatches(studentQueue, sandwichQueue);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void MergeLists_OrderedArray_ReturnsSameArray()
        {
            //arrange
            List<int> left = [1];
            List<int> right = [2];
            List<int> merged = [1, 2];

            //act
            List<int> result = HelperFunctions.MergeLists(left, right);

            //assert
            Assert.Equal(merged, result);
        }
    }
}
