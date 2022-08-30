using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);

            builder.Property(x=> x.Name).IsRequired().HasMaxLength(100);

            builder.Property(x=> x.Description).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Price).IsRequired().HasPrecision(18, 2);
        }
    }
}
