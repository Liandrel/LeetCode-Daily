List<int[]> nums = new() { new int[] { 1, 2, 3, 1 }, new int[] { 2, 7, 9, 3, 1 } };

for (int i = 0; i < nums.Count; i++)
{
    var result = Rob(nums[i]);
}


int Rob(int[] nums)
{
    int n = nums.Length;

    int prev2 = 0;
    int prev = nums[0];
    int cur = 0;

    for(int i = 1; i < n; i ++)
    {
        int pick = nums[i];
        if(i > 1)
            pick += prev2;

        int notPick = prev;
        cur = Math.Max(pick, notPick);
        (prev2, prev) = (prev, cur);
    }
    return prev;
}
