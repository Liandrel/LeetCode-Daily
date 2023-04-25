List<int> m = new() { 3, 3 };
List<int> n = new() { 7, 2 };

for(int i = 0; i < m.Count; i++)
{
    var result = UniquePaths(m[i], n[i]);
}


int UniquePaths(int m, int n)
{
    int[] prev = new int[n + 1];
    int[] cur = new int[n + 1];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(i == 0 && j == 0)
            {
                cur[j] = 1;
                continue;
            }

            int up = 0;
            int left = 0;

            if (i > 0)
                up = prev[j];
            if (j > 0)
                left = cur[j - 1];
            cur[j] = up + left;
        }
        prev = cur;
        cur = new int[n + 1];
    }
    return prev[n-1];
}