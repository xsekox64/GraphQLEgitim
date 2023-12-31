using System;
using GraphQLEgitim.Data;
using GraphQLEgitim.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.Customers
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Description("Müşteri araçları arayüzüne sahip herhangi bir sistemi temsil eder.");
            descriptor.Field(p => p.CustomerCars)
            .ResolveWith<Resolvers>(p => p.GetCustomerCarsType(default!, default!))
            .UseDbContext<AppDbContext>()
            .Description("Bu müşteri için mevcut araçların listesidir");

            base.Configure(descriptor);
        }

        private class Resolvers
        {
            public IQueryable<CustomerCar> GetCustomerCarsType(Customer customer, [ScopedService] AppDbContext context)
            {
                return context.CustomerCars.Where(p => p.CustomerId == customer.CustomerId);
            }
        }
    }
}
