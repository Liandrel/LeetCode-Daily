using System.Runtime.InteropServices.JavaScript;

int[][] obstacles = new int[][] { new int[]{ 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } };


var result = UniquePathsWithObstacles(obstacles);

Console.ReadLine();
int UniquePathsWithObstacles(int[][] obstacleGrid)
{
    obstacleGrid = new int[][] { new int[] { 0, 0 } };
    int n = obstacleGrid.Length;
    int m = obstacleGrid[0].Length;
    int[] prev = new int[m];
    int[] cur = new int[m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (obstacleGrid[i][j] == 1)
            {
                cur[j] = 0;
                continue;
            }
            if(i == 0 && j == 0)
            {
                cur[j] = 1;
                continue;
            }
            int left = 0;
            int top = 0;
            if (i > 0)
                left = prev[j];
            if (j > 0)
                top = cur[j - 1];
            cur[j] = left + top; 
        }
        prev = cur;
    }
    return prev[m - 1];
}
