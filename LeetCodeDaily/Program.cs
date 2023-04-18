using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int NumWays(string[] words, string target)
    {
        int wordLength = words[0].Length;
        int targetLength = target.Length;
        int mod = 1000000007;
        int[] dp = new int[targetLength + 1];
        dp[0] = 1;

        int[][] count = new int[wordLength][];
        for (int i = 0; i < wordLength; i++)
        {
            count[i] = new int[26];
        }

        foreach (string word in words)
        {
            for (int i = 0; i < wordLength; i++)
            {
                count[i][word[i] - 'a']++;
            }
        }

        for (int i = 0; i < wordLength; i++)
        {
            for (int j = targetLength - 1; j >= 0; j--)
            {
                dp[j + 1] += (int)((long)dp[j] * count[i][target[j] - 'a'] % mod);
                dp[j + 1] %= mod;
            }
        }

        return dp[targetLength];
    }
}