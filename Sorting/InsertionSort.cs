
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class InsertionSort : ISorting
    {
        int[] ISorting.Sort(int[] unsorted)
        {
            int i, j, current;
            for (i = 1; i <= unsorted.Length - 1; i++)
            {
                current = unsorted[i];
                j = i;
                while (j >= 1 && unsorted[j - 1] > current)
                {
                    unsorted[j] = unsorted[j - 1]; //moves element one step up
                    j--;
                }
                unsorted[j] = current; //inserts the element in the correct position
            }
            return unsorted;
        }
    }
}
