List<int[]> stones = new() { new int[] { 2, 7, 4, 1, 8, 1 }, new int[] { 1 }, new int[] { 10, 10, 7, 2 } };



for (int i = 0;i <= stones.Count;i++)
{
    var result = LastStoneWeight(stones[i]);
}

Console.ReadLine();

int LastStoneWeight(int[] stones)
{
	int count = stones.Length;
	while (count > 1)
	{
        Array.Sort(stones, (x, y) => y.CompareTo(x));

        if (stones[0] == stones[1])
		{
			stones[0] = 0;
			stones[1] = 0;
			count -= 2;
		}
		else
		{
			stones[0] -= stones[1];
			stones[1] = 0;
			if (stones[0] != 0)
				count -= 1;
			else
				count -= 2;

        }
    }
	return stones.Max();
}