﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210706175625_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar2(16)");

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar2(100)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("Date");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("Paymentdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
