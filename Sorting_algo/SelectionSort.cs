using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort : ISort<int>
    {
        public int[] Sort(int[] unsorted)
        {
            bool swap;
            int smallestIndex;
            for (int i = 0; i <unsorted.Length - 1; i++)
            {
                smallestIndex = i;
                swap = false;
                for (int j = i; j < unsorted.Length - 1; j++)
                {
                    if (unsorted[j + 1] < unsorted[smallestIndex])
                    {
                        smallestIndex = j + 1;
                        swap = true;
                    }
                }
                if (swap)
                {
                    int temp = unsorted[i];
                    unsorted[i] = unsorted[smallestIndex];
                    unsorted[smallestIndex] = temp;
                }
            }
            return unsorted;
        }
    }
}
