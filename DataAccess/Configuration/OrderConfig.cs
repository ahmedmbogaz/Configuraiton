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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);

            builder.HasOne(x=>x.Customer).WithMany(x=>x.Orders).HasForeignKey(x=>x.CustomerId).OnDelete(DeleteBehavior.Restrict);
            //Order: benim bir tane custoermer var, buna karşılık customer tablosunda benden çoklu/cok var aynı zamanda benim içimdeki customerId bana ait değil, cutomer tablosuna aittir(forenignkey) ..

            builder.HasMany(x => x.Products).WithMany(x => x.Orders);
            
        }
    }
}
