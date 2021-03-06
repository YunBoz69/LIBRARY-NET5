﻿// <auto-generated />
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200522173945_editListAddr")]
    partial class editListAddr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("FirstAddress");

                    b.Property<bool>("IsBill");

                    b.Property<bool>("IsDelivery");

                    b.Property<string>("PostalCode");

                    b.Property<int?>("UserId");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Ecommerce.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<int>("UserId");

                    b.HasKey("CartId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Ecommerce.Models.CartProduct", b =>
                {
                    b.Property<int>("CartProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartId");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("CartProductId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ecommerce.Models.Address", b =>
                {
                    b.HasOne("Ecommerce.Models.User", "User")
                        .WithMany("ListAddresses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ecommerce.Models.Cart", b =>
                {
                    b.HasOne("Ecommerce.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce.Models.CartProduct", b =>
                {
                    b.HasOne("Ecommerce.Models.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("CartId");

                    b.HasOne("Ecommerce.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
