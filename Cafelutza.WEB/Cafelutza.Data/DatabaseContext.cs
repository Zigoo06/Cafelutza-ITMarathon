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
            .HasMany(c => c.Raports)
            .WithOne(c => c.User);

        modelBuilder.Entity<Raport>()
            .HasOne(c => c.User)
            .WithMany(c=> c.Raports)
            .IsRequired();
    }
}