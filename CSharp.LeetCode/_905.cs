using System.Text;

namespace CSharp.LeetCode._905;

//905. Sort Array By Parity
//https://leetcode.com/problems/sort-array-by-parity/description/
public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var i=0;
        var j=nums.Length-1;

        while(i<j){
            while(i<j && nums[i]%2==0){
                i++;
            }
            while(i<j && nums[j]%2!=0){
                j--;
            }

            if (i >= j) continue;
            (nums[i],nums[j])=(nums[j],nums[i]);
            i++;
            j--;
        }

        return nums;
    }
}