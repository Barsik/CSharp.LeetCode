using System.Text;

namespace CSharp.LeetCode._896;

//896. Monotonic Array
//https://leetcode.com/problems/monotonic-array/description/
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        var increasing = nums[0] < nums[^1];

        for (var i = 1; i < nums.Length; i++)
        {
            switch (increasing)
            {
                case true when nums[i] < nums[i - 1]:
                case false when nums[i] > nums[i - 1]:
                    return false;
            }
        }

        return true;
    }
}