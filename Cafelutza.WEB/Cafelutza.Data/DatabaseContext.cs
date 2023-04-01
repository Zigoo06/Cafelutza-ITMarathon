using Cafelutza.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cafelutza.Data;

public class DatabaseContext : DbContext
{


    public DbSet<User> Users { get; set; }
    public DbSet<Raport> Raports { get; set;}


    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Id)
            .IsUnique();

        modelBuilder.Entity<Raport>()
            .HasIndex(u => u.Id)
            .IsUnique();
    }
}