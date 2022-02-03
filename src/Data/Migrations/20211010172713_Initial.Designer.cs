﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(AplicationContext))]
    [Migration("20211010172713_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SlnDom.Domain.Models.Customer.CustomerDomain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnName("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Age")
                        .HasColumnName("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRegister")
                        .HasColumnName("DateRegister")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnName("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnName("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UserAdDeletedId")
                        .HasColumnName("UserAdDeletedId")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UserAdInsertedId")
                        .HasColumnName("UserAdInsertedId")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UserAdUpdatedId")
                        .HasColumnName("UserAdUpdatedId")
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("UserDeletedId")
                        .HasColumnName("UserDeletedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserInsertedId")
                        .HasColumnName("UserInsertedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserUpdatedId")
                        .HasColumnName("UserUpdatedId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
