List<int[]> stones = new() { new int[] { 0, 1, 3, 5, 6, 8, 12, 17 }, new int[] { 0, 1, 2, 3, 4, 8, 9, 11 }, new int[] { 0, 1, 3, 6, 7 } };


for(int i = 0; i < stones.Count; i++)
{
    var result = CanCross(stones[i]);
}

 bool CanCross(int[] stones)
{
    Dictionary<string, bool> dp = new();
    return rec(0, 1, stones, dp);
}

bool rec(int n, int jump, int[] stones, Dictionary<string, bool> dp)
{
    if (jump == 0)
        return false;

    if (n + jump == stones.Last())
        return true;
    
    if(stones.Any(x => x == ( n + jump )) == false)
        return false;

    string lookup = n + "-" + jump;
    if (dp.ContainsKey(lookup))
        return dp[lookup];

    if(jump == 1)
    {
        bool result = rec(n + jump, jump, stones, dp) || rec(n + jump, jump + 1, stones, dp);
        dp.Add(lookup, result);
        return dp[lookup];
    }
    else
    {
        bool result = rec(n + jump, jump - 1, stones, dp) || rec(n + jump, jump, stones, dp) || rec(n + jump, jump + 1, stones, dp);
        dp.Add(lookup, result);
        return dp[lookup];
    }
}