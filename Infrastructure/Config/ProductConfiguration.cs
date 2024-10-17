
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        /*
        Remove Migration warning from console
        Microsoft.EntityFrameworkCore.Model.Validation[30000]
        No store type was specified for the decimal property 'Price' on entity type 'Product'.
        This will cause values to be silently truncated if they do not fit in the default precision and scale.
        Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating'
        using 'HasColumnType', specify precision and scale using 'HasPrecision',
        or configure a value converter using 'HasConversion'.
         */
        builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        builder.Property(p => p.Name).IsRequired();
    }
}
