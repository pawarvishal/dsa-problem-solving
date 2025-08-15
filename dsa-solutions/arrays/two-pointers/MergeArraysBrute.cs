using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class MergeArraysBrute
    {
        /*public static void Main(string[] args)
        {
            int[] num1 = { 1, 3, 5, 0, 0 };
            int[] num2 = { 2, 4 };

            int[] resultArr = MergeArraysBrute.MergeArr(num1, num2);
            for(int i = 0; i < resultArr.Length; i++)
            {
                Console.Write(resultArr[i] + " ");
            }
        }*/

        private static int[] MergeArr(int[] num1, int[] num2)
        {
            int n1 = num1.Length;
            int n2 = num2.Length;
            int[] result = new int[n1];
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < n1 && j < n2)
            {
                // check which is smaller element and put it in the result array
                if (num1[i] < num2[j])
                {
                    result[k] = num1[i];
                    i++;
                    k++;
                }
                else
                {
                    result[k] = num2[j];
                    j++;
                    k++;
                }
            }

            // copy the remaining the elements from first array to result array
            while (k < result.Length && i < n1)
            {
                result[k] = num1[i];
                i++;
                k++;
            }

            return result;

        }
    }
}
