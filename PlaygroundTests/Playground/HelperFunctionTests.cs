using Playground;
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
    }
}
