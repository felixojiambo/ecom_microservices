﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mserve.Services.CouponAPI.Data;

#nullable disable

namespace Mserve.Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240418181005_seedcoupontables")]
    partial class seedcoupontables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mserve.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "fe3",
                            DiscountAmount = 10.0,
                            MinAmount = 500
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "erhf",
                            DiscountAmount = 60.0,
                            MinAmount = 999
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "20off",
                            DiscountAmount = 55.0,
                            MinAmount = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}