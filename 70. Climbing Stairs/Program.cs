List<int> numbers = new() { 2, 3 };

for (int i = 0; i < numbers.Count; i++)
{
    var result = ClimbStairs(numbers[i]);
}



int ClimbStairs(int n)
{
    if (n <= 3)
        return n;

    int prev2 = 1;
    int prev = 2;
    int cur = 0;
    for (int i = 3; i <= n; i++)
    {
        cur = prev + prev2;
        (prev2, prev) = (prev, cur);
    }
    return cur;
}