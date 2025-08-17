using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_solutions.arrays.sliding_window
{
    // Given a string and k, return the longest substring where no character appears > k times.

    public class LongestSubstringPirate
    {
        public static void Main(string[] args)
        {
            //string s = "aabbbcccc";
            string s = "aabbccddd";
            int k = 2;
            Console.Write(LongestSubstringPirate.LongestSubstrBrute(s, k));
            Console.Write(LongestSubstringPirate.LongestSubstr(s, k));
        }

        private static int LongestSubstr(string s, int k)
        {
            int maxLen = 0;
            int n = s.Length;
            int l = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int r = 0; r < n; r++)
            {
                // add char in dictionary
                if (!dict.ContainsKey(s[r]))
                {
                    dict[s[r]] = 1;
                }
                else
                {
                    dict[s[r]]++;
                }

                // shrink window if invalid
                while (dict[s[r]] > k)
                {
                    dict[s[r]]--;
                    l++;
                }

                maxLen = Math.Max(maxLen, r - l + 1);

            }

            return maxLen;
        }

        private static int LongestSubstrBrute(string s, int k)
        {
            int maxLen = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                // maintain dictinonary to store freq of char
                Dictionary<char, int> dict = new Dictionary<char, int>();

                for (int j = i; j < n; j++)
                {
                    if (!dict.ContainsKey(s[j]))
                    {
                        dict[s[j]] = 1;
                    }
                    else
                    {
                        dict[s[j]]++;
                    }


                    // Check validity
                    bool IsValid = true;
                    foreach (var count in dict.Values)
                    {
                        if (count > k)
                        {
                            IsValid = false;
                            break;
                        }
                    }

                    if (IsValid)
                    {
                        maxLen = Math.Max(maxLen, j - i + 1);
                    }                
                }
            }

            return maxLen;
        }
    }
}
