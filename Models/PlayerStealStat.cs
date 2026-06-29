namespace NbaStealApi.Models;
public class PlayerStealStat
{
    public int Id { get; set; }

    public string PlayerName { get; set; } = "";
    public string Team { get; set; } = "";

    public int GamesPlayed { get; set; }

    public int Steals { get; set; }   
}