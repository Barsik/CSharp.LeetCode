namespace CSharp.LeetCode._2390;

//2390. Removing Stars From a String
//https://leetcode.com/problems/removing-stars-from-a-string/description/
public class Solution {
    public string RemoveStars(string s)
    {
        var arr = s.ToCharArray();
        var j = 0;
        for(var i = 0; i < s.Length; i++){
            if(s[i]=='*'){
                j--;
            }else{
                arr[j++] = arr[i];
            }
        }

        return new string(arr[..j]);
    }
}