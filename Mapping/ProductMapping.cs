using ApiProduct.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductAPI.Infrastructure.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(x => x.Id);
        builder.Property(e => e.Name).HasColumnName("Name");
        builder.Property(e => e.Stock).HasColumnName("Stock");
        builder.Property(x => x.Description).HasColumnName("Description");
        builder.Property(e => e.CreatedAt).HasColumnName("Created_at");
        builder.Property(e => e.UpdatedAt).HasColumnName("Updated_at");
        builder.Property(e => e.DeletedAt).HasColumnName("Is_deleted");
        
    }
}