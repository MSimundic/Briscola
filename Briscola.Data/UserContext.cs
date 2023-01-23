using System;
using Microsoft.EntityFrameworkCore;
using Briscola.Model;
namespace Briscola.Data;

public class UserContext : DbContext
{
    public DbSet <User> Users { get; set; } = null!;
    public DbSet <GameResult> GameResults { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Briscola; Trusted_Connection = True;");
    }
}
