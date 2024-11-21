///<summary>
///
/// Given an integer x, return true if x is a palindrome, and false otherwise. ?
/// 
/// </summary>

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


        // This method checks if an integer is a palindrome without converting it to a string.
        public bool IsPalindrome_nostring(int x)
        {
            // Initialize variables:
            // 'r' will store the reversed number, initially 0.
            // 'c' is a copy of 'x', used for processing.
            int r = 0, c = x;

            // Loop to reverse the digits of the number while 'c' is greater than 0.
            while (c > 0)
            {
                // Add the last digit of 'c' to 'r' (shifting existing digits left).
                r = r * 10 + c % 10;

                // Remove the last digit from 'c' by integer division.
                c /= 10;
            }

            // Check if the reversed number 'r' is equal to the original number 'x'.
            // If they are equal, 'x' is a palindrome.
            return r == x;
        }

    }
}
