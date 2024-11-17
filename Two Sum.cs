/// <summary>
/// 1. Two Sum
/// 
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
///  Source: https://leetcode.com/problems/two-sum/description/
///  
/// </summary>

public class Two_Sum
{   
    public int[] TwoSum(int[] nums, int target)
    {
        // Makes a HashMap to storage values and idexes.
        Dictionary<int, int> map = new Dictionary<int, int>();

        // Goes through with numebers array
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate what number is need to get to target. 
            int temp = target - nums[i];

            // This checks if the value is already in the map. 
            if (map.ContainsKey(temp))
            {
                // If it contains value, return index as result 
                return new int[] { map[temp], i };
            }

            // If not , add to the relevent value and the index in map
            map[nums[i]] = i;
        }
        // If a solution is not found then return the array as empty 
        return new int[0];
    }
}
