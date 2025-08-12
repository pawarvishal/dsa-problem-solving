using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class UniquePairsBrute
    {
        /*
            Given an array with +ve and -ve numbers, return all unique pairs that sum to zero.
            Examples: [-3, -1, 0, 1, 3] → [[-3, 3], [-1, 1]]
         */
        /*public static void Main(string[] args)
        {
            //int[] nums = new int[] { -3, -1, 0, 1, 3 };
            int[] nums = new int[] { 1, 1, -1 };

            var result = UniquePairsBrute.ReturnPairs(nums);
            foreach (var list in result)
            {
                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
        }*/

        private static List<List<int>> ReturnPairs(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // check if sum is zero
                    if (nums[i] + nums[j] == 0)
                    {
                        // create a pair, by putting -negative first and then positive value as [3, -3] are same as [-3, 3]

                        List<int> pair = new List<int> { Math.Min(nums[i], nums[j]), Math.Max(nums[i], nums[j]) };

                        // check if pair already exist in final list to avoid duplicates
                        if (!result.Any(p => p[0] == pair[0] && p[1] == pair[1]))
                        {
                            result.Add(pair);
                        }
                    }

                }
            }

            return result;
        }
    }
}
