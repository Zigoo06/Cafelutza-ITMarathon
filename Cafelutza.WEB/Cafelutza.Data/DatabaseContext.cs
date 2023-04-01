using Cafelutza.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cafelutza.Data;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    DbSet<User> Users { get; set; }
    DbSet<Raport> Raports { get; set;}

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