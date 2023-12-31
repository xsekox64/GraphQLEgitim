using System;
using GraphQLEgitim.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLEgitim.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers{get; set;}
        public DbSet<CustomerCar> CustomerCars{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder
           .Entity<Customer>()
           .HasMany(p => p.CustomerCars)
           .WithOne(p => p.Customer)
           .HasForeignKey(p => p.CustomerId);

           modelBuilder
           .Entity<CustomerCar>()
           .HasOne(p => p.Customer)
           .WithMany(p => p.CustomerCars)
           .HasForeignKey(p => p.CustomerId);
        }
    }
}
