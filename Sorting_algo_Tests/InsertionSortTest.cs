using Sorting_algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo_Tests
{
    public class InsertionSortTest : BaseSortTest
    {
        protected override ISort<int> Sorter => new InsertionSort();

        [Fact]
        protected void InsertionSort_EmptyArray_Test()
        {
            base.EmptyArray_Test();
        }
        [Fact]
        protected void InsertionSort_SingleElementArray_Test()
        {
            base.SingleElementArray_Test();
        }
        [Fact]
        protected void InsertionSort_IdenticalElements_Test()
        {
            base.IdenticalElements_Test();
        }
        [Fact]
        protected void InsertionSort_NegativeNumbers_Test()
        {
            base.NegativeNumbers_Test();
        }
        [Fact]
        protected void InsertionSort_NumbersWithZero_Test()
        {
            base.NumbersWithZero_Test();
        }
        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void InsertionSort_RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.RandomArray_Test(arraySize, lowerBound, upperBound);
        }

        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void InsertionSort_SequentialArrayWithWrapping_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
        }
        [Theory]
        [InlineData(1000, 10, 1, 100)]
        [InlineData(1000, 100, 1, 100)]
        [InlineData(1000, 100, 1, 1000)]
        public void InsertionSort_MultipleRandomArrays_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                base.RandomArray_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Theory]
        [InlineData(1000, 100, 0, 100)]
        [InlineData(1000, 100, 1, 100)]
        public void InsertionSort_MultipleSequentialArraysWithWrapping_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Fact]
        protected void InsertionSort_SortedArray_Test()
        {
            base.SortedArray_Test();
        }
        [Fact]
        protected void InsertionSort_ReverseSortedArray_Test()
        {
            base.ReverseSortedArray_Test();
        }
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        protected void InsertionSort_MinMaxArray_Test(int arraySize)
        {
            RandomArray_Test(arraySize, int.MinValue, int.MaxValue);
        }
    }
}
