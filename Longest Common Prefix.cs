using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Longest_Common_Prefix
    {
        ///<summary>
        /// Write a function to find the longest common prefix string amongst an array of strings. 
        /// If there is no common prefix, return an empty string "".
        /// 
        /// 
        /// 
        /// </summary>-->
        
            public string LongestCommonPrefix(string[] strs)
            {
                // Edge case: if the array is empty, return an empty string
                if (strs == null || strs.Length == 0)
                {
                    return "";
                }

                // Start with the first string as the assumed prefix
                string prefix = strs[0];

                // Loop through the array, updating the prefix
                for (int i = 1; i < strs.Length; i++)
                {
                    // Reduce the prefix until it matches the beginning of strs[i]
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        prefix = prefix.Substring(0, prefix.Length - 1);
                        // If prefix becomes empty, return empty string
                        if (prefix == "")
                        {
                            return "";
                        }
                    }
                }

                return prefix;
            }
            // Runtime: 8 ms 


    }
}
