﻿// <auto-generated />
using System;
using GraphQLEgitim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLEgitim.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphQLEgitim.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AddDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerTcNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GraphQLEgitim.Models.CustomerCar", b =>
                {
                    b.Property<int>("CustomerCarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerCarId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Kilometer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotorNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SasiNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerCarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerCars");
                });

            modelBuilder.Entity("GraphQLEgitim.Models.CustomerCar", b =>
                {
                    b.HasOne("GraphQLEgitim.Models.Customer", "Customer")
                        .WithMany("CustomerCars")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GraphQLEgitim.Models.Customer", b =>
                {
                    b.Navigation("CustomerCars");
                });
#pragma warning restore 612, 618
        }
    }
}
