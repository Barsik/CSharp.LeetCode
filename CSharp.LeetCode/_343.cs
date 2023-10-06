namespace CSharp.LeetCode._343;

//343. Integer Break
//https://leetcode.com/problems/integer-break/description
public class Solution
{
    private int[] _dp;

    public int IntegerBreak(int n)
    {
        if (n <= 3) return n - 1;
        _dp = new int[n + 1];

        _dp[1] = 1;
        _dp[2] = 2;
        _dp[3] = 3;

        for (var num = 4; num <= n; num++)
        {
            var ans = num;
            for (var i = 2; i < num; i++)
            {
                ans = Math.Max(ans, i * _dp[num - i]);
            }

            _dp[num] = ans;
        }

        return _dp[n];
    }
}