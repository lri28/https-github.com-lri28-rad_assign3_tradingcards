public class Player
{
    public int PlayerId { get; set; }
    public string PlayerName { get; set; }
    public string TeamName { get; set; }
    public string PlayerImage { get; set; } // Correct property to hold the image URL
    public int Goals { get; set; }
    public int Assists { get; set; }
    public int MatchesPlayed { get; set; }
    public decimal PassAccuracy { get; set; }

    public Player(int playerId, string playerName, string teamName, string playerImage, int goals, int assists, int matchesPlayed, decimal passAccuracy)
    {
        PlayerId = playerId;
        PlayerName = playerName;
        TeamName = teamName;
        PlayerImage = playerImage; // Set the image property correctly
        Goals = goals;
        Assists = assists;
        MatchesPlayed = matchesPlayed;
        PassAccuracy = passAccuracy;
    }
}
