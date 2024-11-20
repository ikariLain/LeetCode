/// <summary>
/// Roman numerals are represented by seven different symbols: I, V, X, L, C, D, and M.
///
/// Symbol       Value
/// I             1
/// V             5
/// X             10
/// L             50
/// C             100
/// D             500
/// M             1000
///
/// For example, 2 is written as II in Roman numerals, just two ones added together. 
/// 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, 
/// which is XX + V + II.
///
/// Roman numerals are usually written largest to smallest from left to right. 
/// However, the numeral for four is not IIII. Instead, the number four is written as IV. 
/// Because the one is before the five, we subtract it making four. The same principle applies 
/// to the number nine, which is written as IX. There are six instances where subtraction is used:
///
/// I can be placed before V (5) and X (10) to make 4 and 9. 
/// X can be placed before L (50) and C (100) to make 40 and 90. 
/// C can be placed before D (500) and M (1000) to make 400 and 900.
///
/// Given a Roman numeral, this method converts it to its integer equivalent.

/// </summary>
public class Solution
{
    public int RomanToInt(string s)
    {
        // Create a dictionary to map Roman numerals to their integer values
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        // Loop through the string from left to right
        foreach (char c in s)
        {
            // Get the integer value of the current Roman numeral
            int currentValue = romanMap[c];

            // If the previous value is less than the current value, subtract the previous value twice (undo the addition and subtract)
            if (prevValue < currentValue)
            {
                total += currentValue - 2 * prevValue;
            }
            else
            {
                // Otherwise, add the current value to the total
                total += currentValue;
            }

            // Update the previous value
            prevValue = currentValue;
        }

        return total;
    }
}
