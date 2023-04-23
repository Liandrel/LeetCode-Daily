List<string> strings = new() { "1000", "1000", "1317" };
List<int> keys = new() { 10000 , 10, 2000 };


for (int i = 0; i < strings.Count; i++)
{
    var result = NumberOfArrays(strings[i], keys[i]);

}

int NumberOfArrays(string s, int k)
{
    int mod = 1000000007;
    int m = s.Length;
    int[] dp = new int[m + 1];

    dp[0] = 1;

    for(int start = 0; start < m; start++)
    {
        if (s[start] == '0')
            continue;

        for(int end = start; end < m; ++end)
        {
            string current = s.Substring(start, end - start + 1);
            if (long.Parse(current) > k)
                break;
            dp[end + 1] = (dp[end + 1] + dp[start]) % mod;
        }
    }
    return dp[m];
}

//int DeepFirstSearch(int[] dp, string s, int k, int start)
//{
//    if (dp[start] != 0)
//        return dp[start];

//    if (start == s.Length)
//        return 1;

//    if (s[start] == '0')
//        return 0;

    
//    long count = 0;
//    for (int i = start; i < s.Length; ++i)
//    {
//        string number = s.Substring(start, i - start + 1);
//        if (long.Parse(number) > k)
//        {
//            break;
//        }
//        count = (count + DeepFirstSearch(dp, s, k, i + 1)) % mod;
//    }
//    dp[start] = (int)count;
//    return dp[start];
//}