using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISorting sortingTest;

            const int size = 1000;
            const int min = -20;
            const int max = 20;
            int[] unsorted;
            int[] copy;
            int[] sorted;
            
            //Create
            unsorted = CreateUnsortedArray(size, min, max);
            copy = new int[unsorted.Length];
            Array.Copy(unsorted, copy, unsorted.Length);
            //Sort
            sortingTest = new InsertionSort();
            sorted = sortingTest.Sort(unsorted);
            Array.Sort(copy);
            //Test
            bool success = TestArray(copy, sorted);
            Console.WriteLine($"InsertionSort is: {success}");

        }

        private static int[] CreateUnsortedArray(int size, int lowerBound, int upperBound )
        {
            int[] numbers = new int[size];

                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    numbers[i] = rand.Next(upperBound - lowerBound + 1) + lowerBound;
                }
            return numbers;
        }

        private static bool TestArray(int[] copy, int [] newlySorted)
        {
            for(int i  = 0; i < newlySorted.Length; i++)
            {
                if (Equals(copy[i], newlySorted[i]) == false)
                    return false;
            }
            return true;
        }
    }
}
