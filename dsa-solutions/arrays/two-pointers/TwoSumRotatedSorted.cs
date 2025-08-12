using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class TwoSumRotatedSorted
    {
        /*public static void Main(string[] args)
        {
            int[] nums = new int[] { 6, 7, 1, 2, 3, 4 };
            int target = 9;
            Console.Write("two sum sorted ");
            Console.Write(TwoSumRotatedSorted.TwoSum(nums, target));
        }*/

        private static bool TwoSum(int[] nums, int target)
        {
            //find pivot, smallest element of sorted array
            int n = nums.Length;

            // find pivot
            int pivot = 0;
            for(int i = 0; i < n - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    pivot = i + 1;
                    break;
                }
            }


            int left = pivot; //smallest in the nums
            int right = (pivot - 1 + n) % n; // before pivot

            while(left != right)
            {
                int sum = nums[left] + nums[right];

                if(sum == target)
                {
                    return true;
                }
                
                if( sum < target)
                {
                    // move forward cicularaly using modulo
                    left = (left + 1) % n;
                }
                else
                {
                    // move backword cicularaly using modulo
                    right = (right - 1 + n) % n;
                }
            }

            return false;
        }

        private static int FindPivotUsingBinary(int[] nums)
        {
            //using binary search to find smallest element
            int low = 0;
            int high = nums.Length - 1;

            while(low < high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] > nums[high])
                {
                    low = mid + 1; //smallest element is in right half
                }
                else
                {
                    high = mid; // smallest element is in left half
                }
            }

            return low;
        }
    }
}
