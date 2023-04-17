using System;

List<int[]> candiesSamples = new() {
    new int[] { 2, 3, 5, 1, 3 },
    new int[] { 4, 2, 1, 1, 2 },
    new int[] { 12, 1, 12 }
};
List<int> extraCandiesSamples = new() { 3, 1, 10 };



IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
    var result = new List<bool>();
    int max = candies.Max();

    foreach(var kid in candies)
    {
        result.Add(kid + extraCandies >= max);
    }

    return result;
}

List<IList<bool>> results = new();
for (int i = 0; i < candiesSamples.Count; i++)
{
    results.Add(KidsWithCandies(candiesSamples[i], extraCandiesSamples[i]));

}

Console.ReadLine();


