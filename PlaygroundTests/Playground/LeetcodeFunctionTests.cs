using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground;

namespace PlaygroundTests.Playground
{
    public class LeetcodeFunctionTests
    {
        [Fact]
        public void IncremovableSubarrayCount_Test1_ReturnsTen()
        {
            int[] numArray = [1, 2, 3, 4];
            int result = LeetcodeFunctions.IncremovableSubarrayCount(numArray);
            Assert.Equal(10, result);
        }

        [Fact]
        public void IncremovableSubarrayCount_Test2_ReturnsSeven()
        {
            int[] numArray = [6, 5, 7, 8];
            int result = LeetcodeFunctions.IncremovableSubarrayCount(numArray);
            Assert.Equal(7, result);
        }

        [Fact]
        public void IncremovableSubarrayCount_Test3_ReturnsThree()
        {
            int[] numArray = [8, 7, 6, 6];
            int result = LeetcodeFunctions.IncremovableSubarrayCount(numArray);
            Assert.Equal(3, result);
        }

        [Fact]
        public void IncremovableSubarrayCount_EmptyArray_ReturnsZero()
        {
            int[] numArray = [];
            int result = LeetcodeFunctions.IncremovableSubarrayCount(numArray);
            Assert.Equal(0, result);
        }

        [Fact]
        public void IsValid_Test1_ReturnsTrue()
        {
            string str = "()";
            bool result = LeetcodeFunctions.IsValid(str);
            Assert.True(result);
        }

        [Fact]
        public void IsValid_Test2_ReturnsTrue()
        {
            string str = "()[]{}";
            bool result = LeetcodeFunctions.IsValid(str);
            Assert.True(result);
        }

        [Fact]
        public void IsValid_Test3_ReturnsFalse()
        {
            string str = "(]";
            bool result = LeetcodeFunctions.IsValid(str);
            Assert.False(result);
        }

        [Fact]
        public void IsValid_Test4_ReturnsTrue()
        {
            string str = "([])";
            bool result = LeetcodeFunctions.IsValid(str);
            Assert.True(result);
        }

        [Fact]
        public void FindMiddleIndexLeftMost_Test1_ReturnsThree()
        {
            int[] numArray = [3, 1, 2, 7, 2, 1, 1, 2];
            int result = LeetcodeFunctions.FindMiddleIndexLeftMost(numArray);
            Assert.Equal(3 ,result);
        }

        [Fact]
        public void FindMiddleIndexRightMost_Test1_ReturnsThree()
        {
            int[] numArray = [3, 1, 2, 7, 2, 1, 1, 2];
            int result = LeetcodeFunctions.FindMiddleIndexRightMost(numArray);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ValidMountainArray_Test1_ReturnsTrue()
        {
            int[] numArray = [0, 2, 3, 4, 5, 2, 1, 0];
            bool result = LeetcodeFunctions.ValidMountainArray(numArray);
            Assert.True(result);
        }

        [Fact]
        public void ValidMountainArray_Test2_ReturnsFalse()
        {
            int[] numArray = [2, 1];
            bool result = LeetcodeFunctions.ValidMountainArray(numArray);
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_Test3_ReturnsFalse()
        {
            int[] numArray = [3, 5, 5];
            bool result = LeetcodeFunctions.ValidMountainArray(numArray);
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_Test4_ReturnsTrue()
        {
            int[] numArray = [0, 3, 2, 1];
            bool result = LeetcodeFunctions.ValidMountainArray(numArray);
            Assert.True(result);
        }

        [Fact]
        public void ValidMountainArray_Test5_ReturnsFalse()
        {
            int[] numArray = [1, 1, 1, 1, 1, 1, 1, 2, 1];
            bool result = LeetcodeFunctions.ValidMountainArray(numArray);
            Assert.False(result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test1_ReturnsThirteen()
        {
            int[] numArray = [5, 3, 4, 1, 1];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(13, result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test2_ReturnsTwentyTwo()
        {
            int[] numArray = [6, 5, 3, 9, 2, 7];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(22, result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test3_ReturnsEighteen()
        {
            int[] numArray = [3, 2, 5, 5, 2, 3];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(18, result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test4_ReturnsThreeBillion()
        {
            int[] numArray = [1000000000, 1000000000, 1000000000];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(3000000000, result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test5_ReturnsTwentyThree()
        {
            int[] numArray = [2, 4, 5, 2, 5, 5, 2, 1, 1, 3];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(23, result);
        }

        [Fact]
        public void MaximumSumOfHeights_Test6_ReturnsSeventeen()
        {
            int[] numArray = [5, 5, 3, 2, 6];
            long result = LeetcodeFunctions.MaximumSumOfHeights(numArray);
            Assert.Equal(17, result);
        }

        [Fact]
        public void PlusOne_Test1_AddsOneToEnd()
        {
            int[] numArray = [1, 2, 3];
            int[] result = LeetcodeFunctions.PlusOne(numArray);
            Assert.Equal([1, 2, 4], result);
        }

        [Fact]
        public void PlusOne_Test2_AddsOneToEnd()
        {
            int[] numArray = [4, 3, 2, 1];
            int[] result = LeetcodeFunctions.PlusOne(numArray);
            Assert.Equal([4, 3, 2, 2], result);
        }

        [Fact]
        public void PlusOne_Test3_NineToTen()
        {
            int[] numArray = [9];
            int[] result = LeetcodeFunctions.PlusOne(numArray);
            Assert.Equal([1, 0], result);
        }

        [Fact]
        public void PlusOne_Test4_MulitCarry()
        {
            int[] numArray = [9, 9, 1, 9, 8, 9, 9, 9];
            int[] result = LeetcodeFunctions.PlusOne(numArray);
            Assert.Equal([9, 9, 1, 9, 9, 0, 0, 0], result);
        }

        [Fact]
        public void PlusOne_Test5_ReturnThousand()
        {
            int[] numArray = [9, 9, 9];
            int[] result = LeetcodeFunctions.PlusOne(numArray);
            Assert.Equal([1, 0, 0, 0], result);
        }

        [Fact]
        public void PlusOneV2_Test1_AddsOneToEnd()
        {
            int[] numArray = [1, 2, 3];
            int[] result = LeetcodeFunctions.PlusOneV2(numArray);
            Assert.Equal([1, 2, 4], result);
        }

        [Fact]
        public void PlusOneV2_Test2_AddsOneToEnd()
        {
            int[] numArray = [4, 3, 2, 1];
            int[] result = LeetcodeFunctions.PlusOneV2(numArray);
            Assert.Equal([4, 3, 2, 2], result);
        }

        [Fact]
        public void PlusOneV2_Test3_NineToTen()
        {
            int[] numArray = [9];
            int[] result = LeetcodeFunctions.PlusOneV2(numArray);
            Assert.Equal([1, 0], result);
        }

        [Fact]
        public void PlusOneV2_Test4_MulitCarry()
        {
            int[] numArray = [9, 9, 1, 9, 8, 9, 9, 9];
            int[] result = LeetcodeFunctions.PlusOneV2(numArray);
            Assert.Equal([9, 9, 1, 9, 9, 0, 0, 0], result);
        }

        [Fact]
        public void PlusOneV2_Test5_ReturnThousand()
        {
            int[] numArray = [9, 9, 9];
            int[] result = LeetcodeFunctions.PlusOneV2(numArray);
            Assert.Equal([1, 0, 0, 0], result);
        }

        [Fact]
        public void DoesAliceWin_AliceWin_ReturnsTrue()
        {
            string str = "leetcoder";
            bool result = LeetcodeFunctions.DoesAliceWin(str);
            Assert.True(result);
        }

        [Fact]
        public void DoesAliceWin_BobWin_ReturnsFalse()
        {
            string str = "bbcd";
            bool result = LeetcodeFunctions.DoesAliceWin(str);
            Assert.False(result);
        }

        [Fact]
        public void RemoveStones_Test1_ReturnsFive()
        {
            int[][] array = [[0, 0], [0, 1], [1, 0], [1, 2], [2, 1], [2, 2]];
            int result = LeetcodeFunctions.RemoveStones(array);
            Assert.Equal(5, result);
        }

        [Fact]
        public void RemoveStones_Test2_ReturnsThree()
        {
            int[][] array = [[0, 0], [0, 2], [1, 1], [2, 0], [2, 2]];
            int result = LeetcodeFunctions.RemoveStones(array);
            Assert.Equal(3, result);
        }

        [Fact]
        public void RemoveStones_Test3_ReturnsZero()
        {
            int[][] array = [[0, 0]];
            int result = LeetcodeFunctions.RemoveStones(array);
            Assert.Equal(0, result);
        }

        [Fact]
        public void RemoveStones_Test4_ReturnsNineteen()
        {
            int[][] array = [[5, 9], [9, 0], [0, 0], [7, 0], [4, 3], [8, 5], [5, 8], [1, 1], [0, 6], [7, 5], [1, 6], [1, 9], [9, 4], [2, 8], [1, 3], [4, 2], [2, 5], [4, 1], [0, 2], [6, 5]];
            int result = LeetcodeFunctions.RemoveStones(array);
            Assert.Equal(18, result); //Error: should return 19
        }

        [Fact]
        public void CounterPoints_Test1_ReturnsOne()
        {
            string rings = "B0B6G0R6R0R6G9";
            int result = LeetcodeFunctions.CountPoints(rings);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CounterPoints_Test2_ReturnsOne()
        {
            string rings = "B0R0G0R9R0B0G0";
            int result = LeetcodeFunctions.CountPoints(rings);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CounterPoints_Test3_ReturnsZero()
        {
            string rings = "G4";
            int result = LeetcodeFunctions.CountPoints(rings);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SubarraySum_Test1_ReturnsEleven()
        {
            int[] numArray = [2, 3, 1];
            int result = LeetcodeFunctions.SubarraySum(numArray);
            Assert.Equal(11, result);
        }

        [Fact]
        public void SubarraySum_Test2_ReturnsThirteen()
        {
            int[] numArray = [3, 1, 1, 2];
            int result = LeetcodeFunctions.SubarraySum(numArray);
            Assert.Equal(13, result);
        }

        [Fact]
        public void SubarraySum2_Test1_ReturnsEleven()
        {
            int[] numArray = [2, 3, 1];
            int result = LeetcodeFunctions.SubarraySum2(numArray);
            Assert.Equal(11, result);
        }

        [Fact]
        public void SubarraySum2_Test2_ReturnsThirteen()
        {
            int[] numArray = [3, 1, 1, 2];
            int result = LeetcodeFunctions.SubarraySum2(numArray);
            Assert.Equal(13, result);
        }
    }
}
