using System.Text;

namespace CSharp.LeetCode._767;

//767. Reorganize String
//https://leetcode.com/problems/reorganize-string/description/
public class Solution {
    class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y-x;
        }
    }
    public string ReorganizeString(string s) {
        var abc = new int[26];
        var queue = new PriorityQueue<char, int>(new Comparer());
        for(var i=0;i<s.Length;i++){
            abc[s[i]-'a']++;
        }
        for(var i=0;i<abc.Length;i++){
            if(abc[i]==0) continue;
            queue.Enqueue((char)(i+'a'),abc[i]);
        }

        var result = new StringBuilder(s.Length);
        var prev = ' ';

        while(queue.Count!=0){
            var first = queue.Dequeue();

            if(prev!=first){
                result.Append(first);
                prev = first;
                if(--abc[first-'a']>0){
                    queue.Enqueue(first,abc[first-'a']);
                }
            }else if(queue.Count!=0){
                var second = queue.Dequeue();
                result.Append(second);
                prev = second;
                if(--abc[second-'a']>0){
                    queue.Enqueue(second,abc[second-'a']);
                }
                queue.Enqueue(first,abc[first-'a']);
            }else{
                return "";
            }
        }

        return result.ToString();
    }
}