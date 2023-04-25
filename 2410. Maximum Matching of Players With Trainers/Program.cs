List<int[]> players = new() { new int[] { 1, 1000000000 }, new int[] { 4, 7, 9 }, new int[] { 1, 1, 1 } };
List<int[]> trainers = new() { new int[] { 1000000000, 1 }, new int[] { 8, 2, 5, 8 }, new int[] { 10 } };

for(int i = 0; i < players.Count; i++)
{
    var result = MatchPlayersAndTrainers(players[i], trainers[i]);
}

int MatchPlayersAndTrainers(int[] players, int[] trainers)
{
    if (players.Length == 0 || trainers.Length == 0)
        return 0;
    int matches = 0;
    Array.Sort(players);
    Array.Sort(trainers);
    int playerId = 0;
    int trainerId = 0;
    while(playerId < players.Length && trainerId < trainers.Length)
    {
        if (players[playerId] <= trainers[trainerId])
        {
            playerId++;
            trainerId++;
            matches++;
        }
        else 
        {
            trainerId++;
        }
    }
    return matches;
}