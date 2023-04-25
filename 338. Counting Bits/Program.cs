List<int> numbers = new() { 2, 5 };


for(int i = 0; i < numbers.Count; i++)
{
    var result = CountBits(numbers[i]);
}

int[] CountBits(int n)
{
    int[] dp = new int[n + 1];
    for(int i = 0; i < dp.Length; i++)
    {
        dp[i] = i % 2 == 0 ? dp[i / 2] : dp[i - 1] + 1;
    }
    return dp;
}