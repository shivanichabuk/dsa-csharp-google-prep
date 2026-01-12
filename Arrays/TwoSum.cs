using System;
using System.Collections.Generic;

public class TwoSum
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public int[] FindTwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
