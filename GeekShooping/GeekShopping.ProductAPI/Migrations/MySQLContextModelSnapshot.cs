﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-Shirt",
                            Description = "Description",
                            ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                            Nome = "Name2",
                            Price = 79.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Action figure",
                            Description = "Description3",
                            ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                            Nome = "Name3",
                            Price = 999.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Picture",
                            Description = "Description4",
                            ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                            Nome = "Name4",
                            Price = 99.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-Shirt",
                            Description = "Description5",
                            ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                            Nome = "Name5",
                            Price = 79.25m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Pants",
                            Description = "Description6",
                            ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                            Nome = "Name6",
                            Price = 129.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
