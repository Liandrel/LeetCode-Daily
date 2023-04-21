
List<int> members = new() { 5, 10 };
List<int> minProfits = new() { 3, 5 };
List<int[]> groups = new() { new int[] { 2, 2 }, new int[] { 2, 3, 5 } };
List<int[]> profits = new() { new int[] { 2, 3 }, new int[] { 6, 7, 8 } };


int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
{
    int mod = 1000000007;

    int[,] dp = new int[minProfit + 1, n + 1];

    dp[0, 0] = 1;

    int sum;

    for (int i = 0; i < group.Length; i++)
    {
        for ( int p = minProfit; p >= 0; p--)
        {
            for ( int j = n - group[i]; j >=0; j--)
            {
                sum = Math.Min(minProfit, p + profit[i]);
                dp[sum, j + group[i]] = (dp[sum, j + group[i]] + dp[p, j]) % mod;
            }
        }
    }

    int result = 0;

    for (int j = 0; j <= n; j++)
    {
        result = (result + dp[minProfit, j]) % mod;
    }

    return result;
}



for (int i = 0; i < 2; i++)
{
    var result = ProfitableSchemes(members[i], minProfits[i], groups[i], profits[i]);
}