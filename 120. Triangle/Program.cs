
List<IList<int>> triangle = new() { new List<int>() { 2 }, new List<int>() { 3,4}, new List<int>() {6,5,7}, new List<int>() { 4, 1, 8, 3 } };




var result = MinimumTotal(triangle);

int MinimumTotal(IList<IList<int>> triangle)
{
    int n = triangle.Count;
    int[] prev = new int[n];
    for (int j = 0; j < n; j++)
        prev[j] = triangle[n - 1][j];

    for (int i = n - 2; i >= 0; i--)
    {
        int[] cur = new int[i + 1];
        for (int j = i; j >= 0; j--)
        {
            int bot = triangle[i][j] + prev[j];
            int diagonal = triangle[i][j] + prev[j + 1];
            cur[j] = Math.Min(bot, diagonal);
        }
        prev = cur;
    }
    return prev[0];
}