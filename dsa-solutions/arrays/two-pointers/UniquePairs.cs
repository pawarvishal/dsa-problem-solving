using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class UniquePairs
    {
        /*
            Given an array with +ve and -ve numbers, return all unique pairs that sum to zero.
            Examples: [-3, -1, 0, 1, 3] → [[-3, 3], [-1, 1]]
         */
        /*public static void Main(string[] args)
        {
            //int[] nums = new int[] { -3, -1, 0, 1, 3 };
            int[] nums = new int[] { 1, 1, -1 };

            var result = UniquePairs.ReturnPairs(nums);
            foreach (var list in result)
            {
                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
        }*/

        private static List<List<int>> ReturnPairs(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            int n = nums.Length;

            // sort the array and check using two pointer if sum equals to zero
            Array.Sort(nums);
            int l = 0;
            int r = n - 1;

            while(l < r)
            {
                int sum = nums[l] + nums[r];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[l], nums[r] });

                    // we dont want duplicates in result so increase left to next uniuqe number
                    int leftNo = nums[l];
                    while (l < r && leftNo == nums[l])
                    {
                        l++;
                    }

                    int rightNo = nums[r];
                    while (l < r && rightNo == nums[r])
                    {
                        r--;
                    }
                }
                else if(sum < 0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return result;
        }
    }
}
