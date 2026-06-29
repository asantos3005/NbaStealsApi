using Microsoft.EntityFrameworkCore;
using NbaStealApi.Models;

namespace NbaStealsApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<PlayerStealStat> PlayerStealStats => Set<PlayerStealStat>();
}