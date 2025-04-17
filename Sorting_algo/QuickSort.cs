using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_algo
{
    /// <summary>
    /// In-place quick sort
    /// </summary>
    public class QuickSort : ISort<int>
    {
        
        public int[] Sort(int[] unsorted)
        {
            if (unsorted == null || unsorted.Length <= 1)
                return unsorted;

            QuickSortRecursive(unsorted, 0, unsorted.Length - 1);
            return unsorted;
        }

        private int[] QuickSortRecursive(int [] unsorted, int startHead, int startTail)
        {
            if (startHead >= startTail)
                return unsorted;

            int first = unsorted[startHead];
            int middle = unsorted[(startHead + startTail) / 2];
            int last = unsorted[startTail];
            //picking the pivot with median of three
            int pivot;
            if (first > middle)
            {
                if (middle > last)
                    pivot = middle;  // first > middle > last 
                else if (first > last)
                    pivot = last;    // first > last > middle
                else
                    pivot = first;   // last > first > middle
            }
            else
            {
                if (first > last)
                    pivot = first;   // middle > first > last
                else if (middle > last)
                    pivot = last;    // middle > last > first
                else
                    pivot = middle;  // last > middle > first
            }

            int temp;
            int head = startHead;
            int mid = startHead;
            int tail = startTail;
            
            while (mid <= tail)
            {
                if (unsorted[mid] < pivot)
                {
                    temp = unsorted[head];
                    unsorted[head] = unsorted[mid];
                    unsorted[mid] = temp;
                    head++;
                    mid++;
                }
                else if (unsorted[mid] == pivot)
                {
                    mid++;
                }
                else if (unsorted[mid] > pivot)
                {
                    temp = unsorted[tail];
                    unsorted[tail] = unsorted[mid];
                    unsorted[mid] = temp;
                    tail--;
                } 
            }

            QuickSortRecursive(unsorted, startHead, head -1 ); //left side of pivot new sub array sent in
            QuickSortRecursive(unsorted, tail + 1, startTail); //right side of pivot. new subarray is sent in
            return unsorted;
        }
    }
}
