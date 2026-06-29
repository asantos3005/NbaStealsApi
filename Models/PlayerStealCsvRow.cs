namespace NbaStealsApi.Models;

public class PlayerStealCsvRow
{
    public string PLAYER { get; set; } = "";
    public string TEAM { get; set; } = "";
    public int GP { get; set; }
    public int STL { get; set; }
}