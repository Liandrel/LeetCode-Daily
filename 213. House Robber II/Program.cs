List<int[]> nums = new() { new int[] { 2, 3, 2 }, new int[] { 1, 2, 3, 1 }, new int[] { 1, 2, 3 } };

for (int i = 0; i < nums.Count; i++)
{
    var result = Rob(nums[i]);
}


int Rob(int[] nums)
{
    var n = nums.Length;
    if (n == 1) return nums[0];
    int[] withoutFirst = new int[n-1];
    int[] withoutLast = new int[n-1];
    for(int i = 0; i < n; i++)
    {
        if(i != 0)
            withoutFirst[i-1] = nums[i];
        if (i != n - 1)
            withoutLast[i] = nums[i];
    }
    return Math.Max(Job(withoutFirst), Job(withoutLast));
}


int Job(int[] nums)
{
    int n = nums.Length;

    int prev2 = 0;
    int prev = nums[0];
    int cur = 0;

    for (int i = 1; i < n; i++)
    {
        int pick = nums[i];
        if (i > 1)
            pick += prev2;

        int notPick = prev;
        cur = Math.Max(pick, notPick);
        (prev2, prev) = (prev, cur);
    }
    return prev;
}