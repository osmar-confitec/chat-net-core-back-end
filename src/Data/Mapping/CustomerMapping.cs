using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnDom.Domain.Models.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping
{

    public class CustomerMapping : BaseMapping<CustomerDomain>
    {

        public override void Configure(EntityTypeBuilder<CustomerDomain> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(200)")
                ;

            builder.Property(c => c.Age)
                .HasColumnName("Age");

            builder.ToTable("Customer");

        }
    }
}
