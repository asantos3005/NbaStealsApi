
using Microsoft.EntityFrameworkCore;
using NbaStealApi.Models;
using NbaStealsApi.Data;

public class PlayerStealService
{
    private readonly AppDbContext _db;

    public PlayerStealService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<PlayerStealStat>> getPlayersAsync()
    {
        var players = await _db.PlayerStealStats.AsNoTracking().ToListAsync();
        return players;
    }

}