using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            // Negative numbers are not palindromes
            if (x < 0) return false;

            // Convert the number to a string
            string str = x.ToString();

            // Use two pointers to check for palindrome
            int left = 0, right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false; // Not a palindrome
                }
                left++;
                right--;
            }

            return true; // It's a palindrome
        }
    }
}
