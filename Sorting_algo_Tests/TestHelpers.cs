using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Tests
{
    public static class TestHelpers
    {
        private static Random random = new Random();
        public static int[] GenerateRandomArray(int arraySize, int lowerBound, int upperBound)
        {
            int [] unsortedList = new int[arraySize]; 
            
            for(int i = 0; i < unsortedList.Length; i++)
            {
                unsortedList[i] = random.Next(lowerBound, upperBound + 1);

            }
            return unsortedList;
        }

        public static int[] GenerateSequentialArrayWithWrapping(int arraySize, int lowerBound, int upperBound)
        {
            int[] sequentialList = new int[arraySize];
            int current = lowerBound;
            for(int i = 0; i < sequentialList.Length; i++)
            {
                sequentialList[i] = current++;
                if (current > upperBound) 
                    current = lowerBound; //wrap around and start over with the sequence from the lower number again.
            }
            return sequentialList;
        }
    }
}
