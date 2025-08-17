using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class MergeArray
    {
        /*public static void Main(string[] args)
        {
            int[] num1 = { 1, 3, 5, 0, 0 };
            int[] num2 = { 2, 4 };

            int[] resultArr = MergeArray.MergeArr(num1, num2);
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write(resultArr[i] + " ");
            }
        }*/

        private static int[] MergeArr(int[] num1, int[] num2)
        {
            int n2 = num2.Length;
            int n1 = num1.Length - n2; //non zero elements in num1 arr

            // point i and j pointer from back of arrays
            int i = n1 - 1;
            int j = n2 - 1;

            int k = n1 + n2 - 1; // to point to last poistion in array num1; 

            while(i >= 0 && j >= 0)
            {
                if (num1[i] > num2[j])
                {
                    num1[k] = num1[i];
                    i--;
                }
                else
                {
                    num1[k] = num2[j];
                    j--;
                }
                k--;
            }

            // copy the remaining elements from num2
            while( j >= 0)
            {
                num1[k] = num2[j];
                j--;
                k--;
            }

            return num1;

        }
    }
}
