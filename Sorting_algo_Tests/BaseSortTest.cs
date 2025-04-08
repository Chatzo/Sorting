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
        /*
1. **Large Arrays**: Ensure the algorithm can handle large arrays efficiently (e.g., tens of thousands of elements).
   - **Test**: Arrays of large sizes (e.g., 10,000 or 100,000 elements).

2. **Already Sorted Arrays**: Ensure that the algorithm doesn't alter an already sorted array.
   - **Test**: Arrays that are already sorted in ascending or descending order (e.g., `[1, 2, 3]` or `[3, 2, 1]`).

3. **Reverse Sorted Arrays**: Specifically test arrays that are sorted in reverse order to check if the algorithm can handle this.
   - **Test**: Arrays in descending order (e.g., `[5, 4, 3, 2, 1]`).

4. **Arrays with Negative Numbers**: Ensure the sorting algorithm works when negative numbers are present.
   - **Test**: Arrays with a mix of positive and negative numbers (e.g., `[-1, 3, -5, 4]`).

5. **Arrays with Zeroes**: Ensure that arrays with zero values are handled correctly.
   - **Test**: Arrays containing zeroes, such as `[0, 2, 0, 5]`.

6. **Arrays with Random Distributions**: Ensure that the algorithm can handle random distributions of numbers, both small and large.
   - **Test**: Arrays with random integers (which you already do with `GenerateRandomArray`).

7. **Arrays with Max/Min Integer Values**: Ensure that the sorting algorithm handles the full integer range.
   - **Test**: Arrays that include the minimum and maximum integer values (`int.MinValue` and `int.MaxValue`).

8. **Arrays with All Different Elements**: While you might already have random arrays, you can explicitly test arrays with no repeating elements for added coverage.
   - **Test**: Arrays with unique values (e.g., `[1, 2, 3, 4]`).

9. **Arrays with Multiple Identical Elements**: You already cover identical elements in the array, but testing with more diverse counts could be valuable.
   - **Test**: Arrays with multiple identical elements but mixed with other numbers (e.g., `[5, 5, 3, 5]`).
       */
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

        protected void RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateRandomArray(arraySize, lowerBound, upperBound);
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm
            //generate the expected reults
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Sort(expected);

            Assert.Equal(expected, sorted);
        }
        protected void SequentialArrayWithWrapping_Test(int arraySize, int lowerBound, int upperBound)
        {
            int[] unsorted = TestHelpers.GenerateSequentialArrayWithWrapping(arraySize, lowerBound, upperBound);
            int[] sorted = Sorter.Sort(unsorted); //call the sorting algoritm
            //generate the expected reults
            int[] expected = (int[])unsorted.Clone(); //create a seperate copy to avoid manipulating unsorted
            Array.Sort(expected);

            Assert.Equal(expected, sorted);
        }
    }
}

