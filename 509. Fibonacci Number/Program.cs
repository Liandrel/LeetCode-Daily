List<int> numbers = new() { 2, 3, 4 };

for(int i = 0; i <= numbers.Count; i++)
{
    var result = Fib(numbers[i]);
}


int Fib(int n)
{
    if (n == 0)
        return 0;
    if(n == 1 || n == 2)
        return 1;

    int prev2 = 0;
    int prev = 1;
    int cur = 0;
    for (int i = 2; i <= n; i++)
    {
        cur = prev2 + prev;
        (prev2, prev) = (prev, cur);
    }
    return cur;
}