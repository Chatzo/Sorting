using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Sorting
{
    public class HeapSort: ISort<int>
    {

        BinaryHeap<int> heap = new BinaryHeap<int>();
        public int[] Sort(int[] unsorted)
        {
            //Build the Max-heap
            heap.BuildHeap(unsorted);

            //Sort the Array
            for (int i = unsorted.Length - 1; i >= 0; i--)
            {
                unsorted[i] = heap.Extract();
            }

            return unsorted;
        }
    }
}
