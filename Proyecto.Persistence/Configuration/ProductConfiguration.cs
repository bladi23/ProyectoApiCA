using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<ProductEntity>entityBuilder) {
            entityBuilder.HasKey(x => x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Description).IsRequired();

            entityBuilder.HasMany(x => x.Bookings)
            .WithOne(x => x.Products)
            .HasForeignKey(x => x.ProductId);
        }
    }
}
