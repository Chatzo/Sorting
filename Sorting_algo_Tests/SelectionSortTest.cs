using Sorting_algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo_Tests
{
    public class SelectionSortTest : BaseSortTest
    {
        protected override ISort<int> Sorter => new SelectionSort();

        [Fact]
        protected void SelectionSort_EmptyArray_Test()
        {
            base.EmptyArray_Test();
        }
        [Fact]
        protected void SelectionSort_SingleElementArray_Test()
        {
            base.SingleElementArray_Test();
        }
        [Fact]
        protected void SelectionSort_IdenticalElements_Test()
        {
            base.IdenticalElements_Test();
        }
        [Fact]
        protected void SelectionSort_NegativeNumbers_Test()
        {
            base.NegativeNumbers_Test();
        }
        [Fact]
        protected void SelectionSort_NumbersWithZero_Test()
        {
            base.NumbersWithZero_Test();
        }
        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void SelectionSort_RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.RandomArray_Test(arraySize, lowerBound, upperBound);
        }

        [Theory]
        [InlineData(100, 1, 10)]
        [InlineData(1000, 1, 1000)]
        [InlineData(10000, 1, 1000)]
        public void SelectionSort_SequentialArrayWithWrapping_Test(int arraySize, int lowerBound, int upperBound)
        {
            base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
        }
        [Theory]
        [InlineData(1000, 10, 1, 100)]
        [InlineData(1000, 100, 1, 100)]
        [InlineData(1000, 100, 1, 1000)]
        public void SelectionSort_MultipleRandomArrays_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                base.RandomArray_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Theory]
        [InlineData(1000, 100, 0, 100)]
        [InlineData(1000, 100, 1, 100)]
        public void SelectionSort_MultipleSequentialArraysWithWrapping_Test(int numberOfTests, int arraySize, int lowerBound, int upperBound)
        {
            for (int i = 0; i < numberOfTests; i++)
            {
                base.SequentialArrayWithWrapping_Test(arraySize, lowerBound, upperBound);
            }
        }
        [Fact]
        protected void SelectionSort_SortedArray_Test()
        {
            base.SortedArray_Test();
        }
        [Fact]
        protected void SelectionSort_ReverseSortedArray_Test()
        {
            base.ReverseSortedArray_Test();
        }
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        protected void SelectionSort_MinMaxArray_Test(int arraySize)
        {
            RandomArray_Test(arraySize, int.MinValue, int.MaxValue);
        }
    }
}
