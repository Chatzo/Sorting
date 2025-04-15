using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting_algo;

namespace Sorting_algo_Tests
{
    public abstract class BaseSortTest
    {
        protected abstract ISort<int> Sorter { get; }

        protected void EmptyArray_Test()
        {
            int[] unsorted = new int[0];
            int[] sorted = Sorter.Sort(unsorted);
            Assert.Empty(sorted);
        }
        protected void SingleElementArray_Test()
        {
            int[] unsorted = { 1 };
            int[] sorted = Sorter.Sort(unsorted);
            Assert.Single(sorted);
        }
        protected void IdenticalElements_Test()
        {
            int[] unsorted = { 2, 2, 2, 2 };
            int[] sorted = Sorter.Sort(unsorted);
            Assert.Equal(unsorted, sorted);
        }

        protected void NegativeNumbers_Test()
        {
            int[] unsorted = { -2, 3, -5, 2, -7, -5  };
            int[] sorted = Sorter.Sort(unsorted);
            Assert.Equal(unsorted, sorted);
        }
        protected void NumbersWithZero_Test()
        {
            int[] unsorted = { 0, 3, 0, 2, 5, 0, 8, 7, 0 };
            int[] sorted = Sorter.Sort(unsorted);
            Assert.Equal(unsorted, sorted);
        }

        protected void RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm

            Array.Sort(expected);
            Assert.Equal(expected, sorted);
        }
        protected void SequentialArrayWithWrapping_Test(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm
            
            Array.Sort(expected);
            Assert.Equal(expected, sorted);
        }

        protected void SortedArray_Test()
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(1000, 1, 1000);
            Array.Sort(unsorted); //sorting the array with built in sort before testing
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm

            Assert.Equal(expected, sorted);
        }

        protected void ReverseSortedArray_Test()
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(1000, 1, 1000);
            Array.Sort(unsorted); //sorting the array with built in sort before testing
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Reverse(unsorted);
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm

            Assert.Equal(expected, sorted);
        }

        protected void MinMaxArray_Test(int arraySize)
        {
            RandomArray_Test(arraySize, int.MinValue, int.MaxValue);
        }
    }
}

