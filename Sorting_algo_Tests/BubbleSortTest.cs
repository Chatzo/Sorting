using System.Collections.Immutable;
using Sorting_algo;
namespace Sorting_algo_Tests
{
    public class BubbleSortTest
    {
        private ISort sorter = new BubbleSort();
        [Fact]
        public void RandomArrayTest()
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(1000, 1, 100);
            //call the sorting algoritm
            int[] sorted = sorter.Sort(unsorted); 

            //generate the expected reults
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Sort(expected);

            Assert.Equal(expected, sorted);
        }
    }
}