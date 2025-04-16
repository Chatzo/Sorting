using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo
{
    public class MergeSort : ISort<int>
    {
        public int[] Sort(int[] unsorted)
        {

            if (unsorted.Length <= 1)
                return unsorted;
            else
            {
                int[] left = new int[unsorted.Length / 2]; //left is half size if odd then its cut off ex: 13 / 2 = 6.5 -> rounded to size 6.
                int[] right = new int[unsorted.Length - left.Length]; // To make sure the rest is added to right side in case off ODD size ex: 13 - 6 = 7 
                SplitArrayInTwo(unsorted, left, right);
                MergeArray(unsorted, Sort(left), Sort(right));
            }
            return unsorted;
        }

        private void SplitArrayInTwo(int[] unsorted, int[] left, int[] right)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                if (i < unsorted.Length / 2)
                {
                    left[i] = unsorted[i];
                }
                else
                {
                    right[i - left.Length] = unsorted[i]; //[i- left.length] so right[] array is filled from 0 and upp and not become out of bounds
                }
            }
        }

        private void MergeArray(int[] unsorted, int[] left, int[] right)
        {
            int i = 0;
            int j = 0;
            while (i + j < unsorted.Length)
            {
                if (i < left.Length && j < right.Length && left[i] < right[j])
                {
                    unsorted[i + j] = left[i]; //if left side is lower than save it to the array
                    i++;
                }
                else if (i < left.Length && j < right.Length && left[i] > right[j])
                {
                    unsorted[i + j] = right[j]; //if right side is lower than save it to the array
                    j++;
                }
                else if (i < left.Length && j < right.Length && left[i] == right[j])
                {
                    unsorted[i + j] = left[i]; //both sides are same. just add left
                    i++;
                }
                else if (i >= left.Length && j < right.Length)
                {
                    unsorted[i + j] = right[j]; //whole left side already added. just add right side
                    j++;
                }
                else if (i < left.Length && j >= right.Length)
                {
                    unsorted[i + j] = left[i]; //whole right side already added. just add left side
                    i++;
                }
            }
        }
    }
}
