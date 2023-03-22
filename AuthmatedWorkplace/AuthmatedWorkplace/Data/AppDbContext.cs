using AuthmatedWorkplace.Data.Models;
using Microsoft.EntityFrameworkCore;

public sealed class AppDbContext : DbContext
{
    public string ConnectionString { get; set; } = "Data Source=app.db";

    public DbSet<Entity> Entities { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext()
    {
        Database.EnsureCreated();
    }

    public AppDbContext(string connectionString) : base()
    {
        ConnectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(ConnectionString);
    }
}
