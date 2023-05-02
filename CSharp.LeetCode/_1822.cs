namespace CSharp.LeetCode._1822;

//1822. Sign of the Product of an Array
//https://leetcode.com/problems/sign-of-the-product-of-an-array/
public class Solution {
    public int ArraySign(int[] nums) {
        var result = 1;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i]==0) return 0;
            if (nums[i] < 0)
            {
                result = -result;
            }
        }
        return result;
    }
}