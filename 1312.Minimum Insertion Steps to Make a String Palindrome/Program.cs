﻿List<string> texts = new() { "zzazz", "mbadm", "leetcode" };


for (int i = 0; i < texts.Count; i++)
{
    var result = MinInsertions(texts[i]);
}




int MinInsertions(string s)
{

    string reversedString = new(s.Reverse().ToArray());
    return s.Length - LongestCommonSubsequence(s, reversedString);

}


int LongestCommonSubsequence(string text1, string text2)
{
    int n = text1.Length;
    int m = text2.Length;

    int[,] dp = new int[n + 1, m + 1];

    for (int j = 0; j <= m; j++)
        dp[0, j] = 0;
    for (int i = 0; i < n; i++)
        dp[i, 0] = 0;

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            if (text1[i - 1] == text2[j - 1])
            {
                dp[i, j] = 1 + dp[i - 1, j - 1];
            }
            else
            {
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
    }

    return dp[n, m];
}