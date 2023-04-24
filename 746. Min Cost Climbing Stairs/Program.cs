using System.Runtime.Intrinsics.Arm;

List<int[]> costs = new() { new int[] { 10, 15, 20 }, new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 } };

for (int i = 0;i < costs.Count;i++)
{
    var result = MinCostClimbingStairs(costs[i]);
}


int MinCostClimbingStairs(int[] cost)
{
    var length = cost.Length;
    var dp = new int[length + 1];

    int prev2 = cost[0];
    int prev = cost[1];
    int cur;

    for (int i = 2; i < length; i++)
    {
        cur = cost[i] + Math.Min(prev, prev2);
        (prev2, prev) = (prev, cur);
    }

    return Math.Min(prev, prev2);
}
