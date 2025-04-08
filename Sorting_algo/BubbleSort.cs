namespace Sorting_algo
{
    public class BubbleSort : ISort<int>
    {
        public int[] Sort(int[] unsorted)
        {
            int temp;
            bool swapped;
            for(int i = 0; i < unsorted.Length - 1; i++)
            {
                swapped = false;
                for(int j = 0; j < unsorted.Length - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;
                        swapped = true;
                    }
                }
                //if no swaps were made in the inner loop then the array is already sorted 
                if (swapped == false)
                    break;
            }
            return unsorted;
        }
    }
}
