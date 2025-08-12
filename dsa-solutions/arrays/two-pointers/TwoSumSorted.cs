using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class TwoSumSorted
    {
        /*public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int target = 9;
            Console.Write(TwoSumSorted.IsTargetExist(nums, target));
        }*/

        private static bool IsTargetExist(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while(left < right)
            {
                int sum = nums[left] + nums[right];

                if(sum == target)
                {
                    return true;
                }
                else if(sum < target)
                {
                    left++; // increase sum by moving the left
                }
                else
                {
                    right--; // decrease the sum by moving to right
                }
            }

            return false;
        }
    }
}
