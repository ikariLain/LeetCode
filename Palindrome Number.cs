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
        //---------------------- Whithout convert to string ----------------------//

        
        
            public bool IsPalindrome_nostring(int x)
            {
                int r = 0, c = x;
                while (c > 0)
                {
                    r = r * 10 + c % 10;
                    c /= 10;
                }
                return r == x;
            }
        
    }
}
