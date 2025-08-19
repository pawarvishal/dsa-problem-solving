using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.sliding_window
{
    public class MinSubSumHistorical
    {

        public static void Main(string[] args)
        {
            int[] arr = { 1, 0, 1, 1, 0, 1 }; // retruns 4
            int k = 3;
            Console.WriteLine(MinSubSumHistorical.MinSubarrBrute(arr, k));
            Console.Write(MinSubSumHistorical.MinSubarr(arr, k));
        }

        private static int MinSubarr(int[] arr, int k)
        {
            int n = arr.Length;
            int i = 0;
            int minLen = int.MaxValue;
            int sum = 0;

            for (int j = 0; j < n; j++)
            {
                // add arr value to sum
                sum += arr[j];

                //check if sum equals or greater than target
                while (sum >= k)
                {
                    minLen = Math.Min(minLen, j - i + 1); // maintain min window seen so far
                    sum -= arr[i];
                    i++; // shrink window from left to make window smaller
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }

        private static int MinSubarrBrute(int[] arr, int k)
        {
            int n = arr.Length;
            int minLen = int.MaxValue;

            for(int i = 0; i < n; i++)
            {
                int sum = 0;

                for (int j = i; j < n; j++)
                {
                    sum += arr[j];

                    if(sum >= k)
                    {
                        minLen = Math.Min(minLen, j - i + 1);
                        break; // break, no need to extend as window only gets bigger
                    }

                }
            }

            return minLen == int.MaxValue ? 0 : minLen;


        }
    }
}
