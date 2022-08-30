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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            //Customer: benim çoklu siparıişlerim var ve benim çoklu sparişlerim olan tabloda da(orders) benden bir tane var
            builder.HasMany(x => x.Orders).WithOne(x => x.Customer).OnDelete(DeleteBehavior.Restrict);
            //ondelete behaver.restricte silmeye engel koyuyor, biri silinecekse eğer diğeride silinmiş oluyor ve böylece hata vermemmiş oluyor.
        }
    }
}
