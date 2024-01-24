using ApiProduct.Models;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Infrastructure.Mappings;

namespace ApiProduct.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductMapping());
        base.OnModelCreating(modelBuilder);
    }
}
