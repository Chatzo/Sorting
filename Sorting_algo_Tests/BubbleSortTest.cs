using System.Collections.Immutable;
using Sorting_algo;
namespace Sorting_algo_Tests
{
    public class BubbleSortTest
    {
        private ISort<int> sorter = new BubbleSort();
        [Theory]
        //(arraysize, lowerBound, upperbound)
        [InlineData(100, 1, 100)]
        [InlineData(1000, 1, 100)]
        [InlineData(1000, 1, 1000)]
        public void RandomArray(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);
            //call the sorting algoritm
            int[] sorted = sorter.Sort(unsorted); 

            //generate the expected reults
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Sort(expected);

            Assert.Equal(expected, sorted);
        }
        [Theory]
        //(arraysize, lowerBound, upperbound)
        [InlineData(100, 1, 100)]
        [InlineData(1000, 1, 100)]
        [InlineData(1000, 1, 1000)]
        public void SequentialArrayWithWrapping(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);
            //call the sorting algoritm
            int[] sorted = sorter.Sort(unsorted);

            //generate the expected reults
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Sort(expected);

            Assert.Equal(expected, sorted);
        }
        [Theory]
        //(numerOfTest, arraysize, lowerBound, upperbound)
        [InlineData(1000, 100, 1, 10)]
        [InlineData(1000, 10, 1, 10)]
        [InlineData(1000, 100, 0, 100)]
        public void MultipleRandomArrays(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for(int i = 0; i < numberOfTests; i++)
            {
                int[] unsorted = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);
                //call the sorting algoritm
                int[] sorted = sorter.Sort(unsorted);

                //generate the expected reults
                int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
                Array.Sort(expected);

                Assert.Equal(expected, sorted);

            }
        }
        [Theory]
        //(numerOfTest, arraysize, lowerBound, upperbound)
        [InlineData(1000, 100, 1, 10)]
        [InlineData(1000, 10, 1, 10)]
        [InlineData(1000, 100, 0, 100)]
        public void MultipleSequentialArraysWithWrapping(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                int[] unsorted = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);
                //call the sorting algoritm
                int[] sorted = sorter.Sort(unsorted);

                //generate the expected reults
                int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
                Array.Sort(expected);

                Assert.Equal(expected, sorted);

            }
        }
    }
}