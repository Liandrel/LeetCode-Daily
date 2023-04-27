
int[][] grid = new int[][] { new int[] { 3, 1, 1 }, new int[] { 2, 5, 1 }, new int[] { 1, 5, 5 }, new int[] { 2, 1, 1 } };

var result = CherryPickup(grid);

Console.ReadLine();


int CherryPickup(int[][] grid)
{
    int n = grid.Length;
    int m = grid[0].Length;

    int[,] prevRow = new int[m, m];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            prevRow[i, j] = grid[n - 1][i] + ((i != j) ? grid[n - 1][j] : 0);
        }
    }


    for(int i = n-2; i >= 0; i--)
    {
        int[,] currentRow = new int[m, m];
        for (int j1 = 0; j1 < m; j1++)
        {
            for(int j2 = 0;j2 < m; j2++) 
            {
                int max = 0;

                for (int dj1 = -1; dj1 <= 1; dj1++)
                {
                    for (int dj2 = -1; dj2 <= 1; dj2++)
                    {
                        int cur = grid[i][j1] + ((j1 != j2) ? grid[i][j2] : 0);

                        if (j1 + dj1 < 0 || j1 + dj1 > m - 1 || j2 + dj2 < 0 || j2 + dj2 > m - 1)
                            cur = 0;
                        else
                            cur += prevRow[j1 + dj1, j2 + dj2];
                        max = Math.Max(max, cur);
                    }
                }
                currentRow[j1, j2] = max;
            }
        }
        prevRow = currentRow;
    }
    return prevRow[0,m-1];
}