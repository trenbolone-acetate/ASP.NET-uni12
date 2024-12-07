using ASPNET12.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET12.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.FirstName).HasColumnType("LONGTEXT");
            entity.Property(e => e.LastName).HasColumnType("LONGTEXT");
        });

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<User> Users { get; set; }
}