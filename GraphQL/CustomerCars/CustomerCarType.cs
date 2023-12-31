using System;
using GraphQLEgitim.Data;
using GraphQLEgitim.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.CustomerCars
{
    public class CustomerCarType : ObjectType<CustomerCar>
    {
        protected override void Configure(IObjectTypeDescriptor<CustomerCar> descriptor)
        {
            descriptor.Description("Herhangi bir müşteri aracını temsil eder.");
            descriptor.Field(c => c.Customer)
            .ResolveWith<Resolvers>(c => c.GetCustomerType(default!, default!))
            .UseDbContext<AppDbContext>()
            .Description("Bu, müşteri araçlarının ait olduğu müşteridir.");
            base.Configure(descriptor);
        }

        private class Resolvers
        {
            public Customer GetCustomerType(CustomerCar customerCar, [ScopedService] AppDbContext context)
            {
                return context.Customers.FirstOrDefault(p => p.CustomerId == customerCar.CustomerId);
            }
        }
    }
}
