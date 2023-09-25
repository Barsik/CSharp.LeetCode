namespace CSharp.LeetCode._389;

//389. Find the Difference
//https://leetcode.com/problems/find-the-difference/description/
public class Solution {
    public char FindTheDifference(string s, string t) {
        var buffer = new int[26];
        
        foreach(var cs in s){
            buffer[cs-'a']++;
        }

        int index = 0;
        foreach(var ct in t){
            index = ct-'a';
            if(buffer[index]==0){
                return ct;
            }
            buffer[ct-'a']--;
        }

        return ' ';
    }
}