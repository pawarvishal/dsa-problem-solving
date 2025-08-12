using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.two_pointers
{
    public class PalindromeSwapCheckBrute
    {
        // Time complexity ( o(n^2 * n)

        /*public static void Main(string[] args)
        {
            string s = "abca";

            Console.Write(PalindromeSwapCheckBrute.IsPalindromeWithOneSwap(s));
        }*/

        private static bool IsPalindromeWithOneSwap(string s)
        {
            // check if string already palindrome, no swap check needed
            if (CheckIfPalindrome(s))
            {
                return true;
            }

            // try every pair of i and j, in nested loop
            char[] chars = s.ToCharArray();
            int n = chars.Length;

            for(int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //check new string pallindrome if swapping elements at i and j
                    Swap(chars, i, j);

                    string strAfterSwap = new string(chars);

                    if (CheckIfPalindrome(strAfterSwap))
                    {
                        return true;
                    }

                    // if not palindrome, swap back for original string
                    Swap(chars, i, j);
                }
            }

            return false;
        }

        private static bool CheckIfPalindrome(string s)
        {
            int n = s.Length;

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }

        private static void Swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
