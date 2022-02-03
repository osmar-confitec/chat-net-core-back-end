using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnDom.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
   public class UserMapping : BaseMapping<UserDomain>
    {


        public override void Configure(EntityTypeBuilder<UserDomain> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
             .HasColumnName("Name")
             .HasColumnType("varchar(200)")
             ;


            builder.Property(c => c.Email)
             .HasColumnName("Email")
             .HasColumnType("varchar(200)")
             ;

            builder.Property(c => c.Password)
                .HasColumnName("Password")
                 .HasColumnType("varchar(200)")
             ;
            ;

            builder.ToTable("User");

        }

    }
}
