using System;
using GraphQLEgitim.Data;
using GraphQLEgitim.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQLEgitim.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Customer> GetCustomer([ScopedService] AppDbContext context)
        {
            return context.Customers;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]       
        public IQueryable<CustomerCar> GetCustomerCars([ScopedService] AppDbContext context)
        {
            return context.CustomerCars;
        }
    }
}
