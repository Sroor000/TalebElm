
using Microsoft.EntityFrameworkCore;
using TalebElm.Domain.Entities;


namespace TalebElm.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<UserProgress> UserProGresses => Set<UserProgress>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
      
    }


}
