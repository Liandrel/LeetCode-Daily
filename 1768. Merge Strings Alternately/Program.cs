


using System;
using System.Text;

string[] firstWords = new string[] { "abc", "ab", "abcd" };
string[] secondWords = new string[] { "pqr", "pqrs", "pq" };

List<string> results = new();

string MergeAlternately(string word1, string word2)
{
    int word1Length = word1.Length;
    int word2Length = word2.Length;
    int max = Math.Max(word1Length, word2Length);

    StringBuilder result = new();

    for (int i = 0; i < max; i++)
    {
        if (i < word1Length)
            result.Append(word1[i]);
        if (i < word2Length)
            result.Append(word2[i]);
    }

    return result.ToString();
}

    for (int i = 0; i < firstWords.Length; i++)
{
    results.Add(MergeAlternately(firstWords[i], secondWords[i]));
}


Console.ReadLine();