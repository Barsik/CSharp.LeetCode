namespace CSharp.LeetCode._229;

//229. Majority Element II
//https://leetcode.com/problems/majority-element-ii/description
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var n1 = nums[0];
        var n2 = 0;
        var count1 = 1;
        var count2 = 0;
        var limit = nums.Length/3;
        for(var i=1;i<nums.Length;i++){
            if(nums[i]!=n2 && count1==0){
                n1 = nums[i];
                count1 = 1;
            }else if(nums[i]!=n1 && count2==0){
                n2 = nums[i];
                count2=1;
            }else if(n1==nums[i]){
                count1++;
            }else if(n2==nums[i]){
                count2++;
            }else{
                count1--;
                count2--;
            }
        }
        var result = new List<int>();
        (count1,count2) = (0,0);
        for(var i=0;i<nums.Length;i++){
            if(nums[i]==n1){
                count1++;
            }else if(nums[i]==n2){
                count2++;
            }
        }

        if(count1>limit) result.Add(n1);
        if(count2>limit) result.Add(n2);
        return result;
    }

    public IList<int> MajorityElementByHashtable(int[] nums) {
        
        var buffer = new Dictionary<int,int>();
        var f = nums.Length/3;
        for(var i=0;i<nums.Length;i++){
            if(buffer.ContainsKey(nums[i])){
                buffer[nums[i]]++;
            }else{
                buffer.Add(nums[i],1);
            }

        }

        return buffer.Where(e=>e.Value>f).Select(e=>e.Key).ToList();
    }
}