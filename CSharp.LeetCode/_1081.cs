using System.Text;

namespace CSharp.LeetCode._1081;

//1081. Smallest Subsequence of Distinct Characters
//https://leetcode.com/problems/smallest-subsequence-of-distinct-characters/description/
public class Solution {
    public string SmallestSubsequence(string s) {
        var stack = new Stack<char>();
        var lastIndex = new int[26];
        var checker = new bool[26];

        for(var i=0;i<s.Length;i++){
            lastIndex[s[i]-'a'] = i;
        }

        for(var i=0;i<s.Length;i++){
            if(!checker[s[i]-'a']){

                while(stack.Count > 0 && stack.Peek() > s[i] && lastIndex[stack.Peek()-'a']>i){
                    checker[stack.Pop()-'a'] = false;
                }

                stack.Push(s[i]);
                checker[s[i]-'a'] = true;
            }
        }

        var sb = new StringBuilder();

        while(stack.Count!=0){
            sb.Insert(0,stack.Pop());
        }

        return sb.ToString();
    }
}