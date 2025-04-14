using Playground;
using Playground.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundTests.Playground.AlgorithmsAndDataStructuresTests
{
    public class SearchingTests
    {
        [Fact]
        public void LinearSearch_ContainsValue_ReturnsTrue()
        {
            //arrange
            int[] numArray = [1, 2, 3, 4];

            //act
            bool result = Searching.LinearSearch(numArray, 3);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void LinearSearch_DoesNotContainValue_ReturnsFalse()
        {
            //arrange
            int[] numArray = [1, 2, 3, 4];

            //act
            bool result = Searching.LinearSearch(numArray, 5);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void LinearSearch_2_ContainsValue_ReturnsTrue()
        {
            //arrange
            int[] numArray = [1, 2, 3, 4];

            //act
            bool result = Searching.LinearSearch_2(numArray, 3);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void LinearSearch_2_DoesNotContainValue_ReturnsFalse()
        {
            //arrange
            int[] numArray = [1, 2, 3, 4];

            //act
            bool result = Searching.LinearSearch_2(numArray, 5);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void BinarySearch_ContainsValue_ReturnsTrue()
        {
            //arrange
            int[] numArray = [1, 8, 3, 4, 7, 2];

            //act
            bool result = Searching.BinarySearch(numArray, 1);

            //assert
            Assert.True(result);
        }
    }
}
