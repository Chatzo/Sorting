using System.Collections.Immutable;
using Sorting_algo;
namespace Sorting_algo_Tests
{
    public class BubbleSortTest : BaseSortTest
    {
        protected override ISort<int> Sorter => new BubbleSort();
        [Fact]
        protected void BubbleSort_EmptyArray_Test()
        {
            base.EmptyArray_Test();
        }
        [Fact]
        protected void BubbleSort_SingleElementArray_Test()
        {
            base.SingleElementArray_Test();
        }
        [Fact]
        protected void BubbleSort_IdenticalElements_Test()
        {
            base.IdenticalElements_Test();
        }
        [Fact]
        protected void BubbleSort_NegativeNumbers_Test()
        {
            base.NegativeNumbers_Test();
        }
        [Fact]
        protected void BubbleSort_NumbersWithZero_Test()
        {
            base.NumbersWithZero_Test();
        }
        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void BubbleSort_RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.RandomArray_Test(arraySize,lowerBound,upperBound);
        }

        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void BubbleSort_SequentialArrayWithWrapping_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
        }
        [Theory]
        [InlineData(1000, 10, 1, 100)]
        [InlineData(1000, 100, 1, 100)]
        [InlineData(1000, 100, 1, 1000)]
        public void BubbleSort_MultipleRandomArrays_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for(int i = 0; i < numberOfTests; i++)
            {
                base.RandomArray_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Theory]
        [InlineData(1000, 100, 0, 100)]
        [InlineData(1000, 100, 1, 100)]
        public void BubbleSort_MultipleSequentialArraysWithWrapping_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Fact]
        protected void BubbleSort_SortedArray_Test()
        {
            base.SortedArray_Test();
        }
        [Fact]
        protected void BubbleSort_ReverseSortedArray_Test()
        {
            base.ReverseSortedArray_Test();
        }
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        protected void BubbleSort_MinMaxArray_Test(int arraySize)
        {
            RandomArray_Test(arraySize, int.MinValue, int.MaxValue);
        }
    }
}