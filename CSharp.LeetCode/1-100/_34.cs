namespace CSharp.LeetCode._1_100._34;

//34. Find First and Last Position of Element in Sorted Array
//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        var res = new[] { -1, -1 };
        if (nums.Length == 0) return res;
        var startIndex = 0;
        var endIndex = nums.Length - 1;
        var pos = 0;
        while (startIndex < endIndex)
        {
            pos = (startIndex + endIndex) / 2;
            if (nums[pos] < target)
            {
                startIndex = pos + 1;
            }
            else
            {
                endIndex = pos;
            }
        }

        if (nums[startIndex] != target) return res;
        res[0] = startIndex;
        endIndex = nums.Length - 1;

        while (startIndex < endIndex)
        {
            pos = (startIndex + endIndex + 1) / 2;
            if (nums[pos] > target)
            {
                endIndex = pos - 1;
            }
            else
            {
                startIndex = pos;
            }
        }

        res[1] = endIndex;
        return res;
    }
}