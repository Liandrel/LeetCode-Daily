﻿
List<int> members = new() { 5, 10 };
List<int> minProfits = new() { 3, 5 };
List<int[]> groups = new() { new int[] { 2, 2 }, new int[] { 2, 3, 5 } };
List<int[]> profits = new() { new int[] { 2, 3 }, new int[] { 6, 7, 8 } };


int ProfitableSchemes(int membersAvaiable, int minProfit, int[] membersForCrime, int[] profitFromCrime)
{
    int mod = 1000000007;

    int[,] dp = new int[minProfit + 1, membersAvaiable + 1];

    dp[0, 0] = 1;

    int sum;

    for (int i = 0; i < membersForCrime.Length; i++)
    {
        for ( int p = minProfit; p >= 0; p--)
        {
            for ( int j = membersAvaiable - membersForCrime[i]; j >=0; j--)
            {
                sum = Math.Min(minProfit, p + profitFromCrime[i]);
                dp[sum, j + membersForCrime[i]] = (dp[sum, j + membersForCrime[i]] + dp[p, j]) % mod;
            }
        }
    }

    int result = 0;

    for (int j = 0; j <= membersAvaiable; j++)
    {
        result = (result + dp[minProfit, j]) % mod;
    }

    return result;
}



for (int i = 0; i < 2; i++)
{
    var result = ProfitableSchemes(members[i], minProfits[i], groups[i], profits[i]);
}