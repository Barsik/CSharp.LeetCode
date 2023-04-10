namespace CSharp.LeetCode._1_100._20;

//20. Valid Parentheses
//https://leetcode.com/problems/valid-parentheses/description/
public class Solution
{
    private static readonly Dictionary<char, char> OpenCloseMap = new()
    {
        { '(', ')' },
        { '{', '}' },
        { '[', ']' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (OpenCloseMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (!stack.TryPop(out var start) || !OpenCloseMap.TryGetValue(start, out var close) || close != c)
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}