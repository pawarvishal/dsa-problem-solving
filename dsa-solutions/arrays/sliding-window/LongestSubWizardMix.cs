using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.sliding_window
{
    /* A wizard mixes potions with varying strengths. Find the longest sequence where the strength difference ≤ k to avoid explosions!
    Problem: Given an array and k, return the longest subarray where max - min ≤ k.
    Examples:

    [3, 1, 5, 2, 8], k=3 → 3 ([1, 5, 2])

    [10, 10, 10], k=0 → 3 (All equal)

    [1, 4, 6, 9], k=2 → 1 (No valid window)
   */

    public class LongestSubWizardMix
    {
        /*public static void Main(string[] args)
        {
            int[] arr = { 3, 1, 5, 2, 8 };
            int k = 3;

            Console.Write(LongestSubWizardMix.LongestSubBrute(arr, k));
            Console.Write(LongestSubWizardMix.LongestSubSW(arr, k));
        }*/

        private static int LongestSubSW(int[] arr, int k)
        {
            int maxLen = 0;
            // use sliding window to add/remove from Valid window
            return maxLen;
        }

        private static int LongestSubBrute(int[] arr, int k)
        {
            int maxLen = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //set currentMin and currentMax to first element of subarray
                int currentMin = arr[i];
                int currentMax = arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    // check the new Min and Max
                    currentMin = Math.Min(currentMin, arr[j]);
                    currentMax = Math.Max(currentMax, arr[j]);

                    // check if current subarray satisfy the condition
                    if(currentMax - currentMin <= k)
                    {
                        maxLen = Math.Max(maxLen, j - i + 1);
                    }

                }
            }

            return maxLen;
        }
    }
}
