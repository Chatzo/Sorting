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

        //[Theory]
        //[InlineData(100, 1, 10)]
        //[InlineData(1000, 1, 1000)]
        //public void SelectionSort_RandomArray_Test(int arraySize, int lowerBound, int upperBound)
        //{
        //    base.RandomArray_Test(arraySize, lowerBound, upperBound);
        //}
    }
}
