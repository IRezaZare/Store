using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.PictureUrl).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Price).IsRequired().HasColumnName("Desimal(18,2)");
        builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x => x.ProductBrandId);
        builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x => x.ProductTypeId);
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.Title).HasMaxLength(100);
        builder.Property(x => x.Summary).HasMaxLength(100);

    }
}
