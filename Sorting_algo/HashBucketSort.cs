//Author Georgios Chatzoglakis
//Date: 2025-04-20
//MIT licence

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// My own sorting Algo
    /// Based on the idea of bucket sort but using dictionaries in a hash-like structure.
    /// It also trying to handle bigger ranges of numbers than normal bucket sort.
    /// 
    /// </summary>
    public class HashBucketSort : ISort<int>
    {
        public int[] Sort(int[] unsorted)
        {
            Dictionary<int, Dictionary<int, int>> buckets = new Dictionary<int, Dictionary<int, int>>();

            int max = int.MinValue;
            int min = int.MaxValue;
            
            foreach (int num in unsorted)
            {
                if (num < min)
                    min = num;
                else if (num > max)
                    max = num;
            }
            int range = max - min;
            if (range == 0)
                return unsorted;

            int numBuckets = Math.Min(5000, Math.Max(10, (int)(unsorted.Length * range / 100000.0)));

            int bucketSize = (range + numBuckets - 1) / numBuckets;
            int bucketKey;

            foreach (int num in unsorted)
            {
                bucketKey = (num - min) / bucketSize;

                if (!buckets.TryGetValue(bucketKey, out var bucket))
                {
                    bucket = new Dictionary<int, int>();
                    buckets[bucketKey] = bucket;
                }

                // Add the number to the bucket
                if (bucket.TryGetValue(num, out int count))
                {
                    bucket[num] = count + 1;
                }
                else
                {
                    bucket[num] = 1;
                }
            }

            var sortedKeys = buckets.Keys.OrderBy(key => key).ToList();

            List<int> sortedNumbers = new List<int>();
            foreach (var key in sortedKeys)
            {
                var bucket = buckets[key];
                foreach (var number in bucket.Keys.OrderBy(n => n))
                {
                    // Add the number to the sorted list
                    for (int i = 0; i < bucket[number]; i++)
                    {
                        sortedNumbers.Add(number);
                    }
                }
            }

            return sortedNumbers.ToArray();
        }
    }
}
