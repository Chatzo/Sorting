using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Tests
{
    //class for testing the TestHelper class
    public class TestHelpersTest
    {
        [Fact]
        public void GenerateRandomArray_ShouldReturnCorrectLength()
        {
            int arraySize = 100;
            int[] result = TestHelpers.GenerateRandomArray(arraySize, 1, 10);
            Assert.Equal(arraySize, result.Length);
        }

        [Fact]
        public void GenerateRandomArray_ShouldReturnValuesWithinBounds()
        {
            int arraySize = 100;
            int lowerBound = 1;
            int upperBound = 10;
            int[] result = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);

            foreach (int value in result)
            {
                Assert.InRange(value, lowerBound, upperBound);
            }
        }

        [Fact]
        public void GenerateRandomArray_ShouldReturnDifferentArrays()
        {
            int arraySize = 100;
            int lowerBound = 1;
            int upperBound = 10;
            int[] result1 = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);
            int[] result2 = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);

            Assert.False(result1.SequenceEqual(result2)); // Should be false if the arrays are random
        }

        [Fact]
        public void GenerateSequentialArrayWithWrapping_ShouldReturnCorrectLength()
        {
            int arraySize = 100;
            int lowerBound = 1;
            int upperBound = 10;

            int[] result = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);

            // Ensure the length of the result array is correct
            Assert.Equal(arraySize, result.Length);
        }

        [Fact]
        public void GenerateSequentialArrayWithWrapping_ShouldStartAtLowerBound()
        {
            int arraySize = 100;
            int lowerBound = 1;
            int upperBound = 10;

            int[] result = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);

            // Ensure the first element is equal to the lower bound
            Assert.Equal(lowerBound, result[0]);
        }

        [Fact]
        public void GenerateSequentialArrayWithWrapping_ShouldWrapAroundCorrectly()
        {
            int arraySize = 20;
            int lowerBound = 1;
            int upperBound = 5;

            int[] result = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);

            // Ensure the array wraps around correctly
            for (int i = 0; i < result.Length; i++)
            {
                int expectedValue = lowerBound + (i % (upperBound - lowerBound + 1));
                Assert.Equal(expectedValue, result[i]);
            }
        }

        [Fact]
        public void GenerateSequentialArrayWithWrapping_ShouldNotExceedUpperBound()
        {
            int arraySize = 100;
            int lowerBound = 1;
            int upperBound = 5;

            int[] result = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);

            // Ensure no value exceeds the upper bound
            foreach (var value in result)
            {
                Assert.InRange(value, lowerBound, upperBound);
            }
        }

    }
}
