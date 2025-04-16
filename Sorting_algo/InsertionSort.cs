using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo
{
    public class InsertionSort : ISort<int>
    {
        public int[] Sort(int[] unsorted)
        {
            int current;
            int j;
            for (int i = 1; i < unsorted.Length; i++)
            {
                j = i;
                current = unsorted[j];
                while (j > 0 && unsorted[j-1] > current)
                {
                    unsorted[j] = unsorted[j-1]; //move previous up one step
                    j--;
                }
                unsorted[j] = current; //insert in correct position
            }
            return unsorted;
        }
    }
}
