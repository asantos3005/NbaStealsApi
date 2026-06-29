using CsvHelper;
using NbaStealApi.Models;
using NbaStealsApi.Models;
using System.Globalization;

namespace NbaStealsApi.Data;

public static class NbaDataSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (db.PlayerStealStats.Any())
        {
            Console.WriteLine("Database already has data. Skipping seed.");
            return;
        }

        var csvPath = "nba_player_stats_2026.csv";

        if (!File.Exists(csvPath))
        {
            Console.WriteLine($"CSV file not found at: {csvPath}");
            return;
        }

        using var reader = new StreamReader(csvPath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var rows = csv.GetRecords<PlayerStealCsvRow>().ToList();

        var stats = rows.Select(row => new PlayerStealStat
        {
            PlayerName = row.PLAYER,
            Team = row.TEAM,
            GamesPlayed = row.GP,
            Steals = row.STL
        }).ToList();

        db.PlayerStealStats.AddRange(stats);
        db.SaveChanges();

        Console.WriteLine($"Seeded {stats.Count} player steal records.");
    }
}