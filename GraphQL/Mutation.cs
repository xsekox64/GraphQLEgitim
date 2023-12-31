using System;
using GraphQLEgitim.Data;
using GraphQLEgitim.GraphQL.CustomerCars;
using GraphQLEgitim.GraphQL.Customers;
using GraphQLEgitim.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;

namespace GraphQLEgitim.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddCustomerPayload> AddCustomerAsycn(AddCustomerInput input,
        [ScopedService] AppDbContext context,
        [Service] ITopicEventSender eventSender,
        CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                CustomerName = input.CustomerName,
                CustomerSurname = input.CustomerSurname,
                CustomerPhone = input.CustomerPhone,
                CustomerEmail = input.CustomerEmail,
                CustomerAddress = input.CustomerAddress,
                AddDateTime = DateTime.Now,
                CustomerTcNo = input.CustomerTcNo,
                Active = input.Active
            };
            context.Customers.Add(customer);
            await context.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnCustomerAdded), customer, cancellationToken);

            return new AddCustomerPayload(customer);
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddCustomerCarPayload> AddCustomerCarAsycn(AddCustomerCarInput input,
                [ScopedService] AppDbContext context, [Service] ITopicEventSender eventSender,
        CancellationToken cancellationToken)
        {
            var customerCar = new CustomerCar
            {
                CustomerId = input.CustomerId,
                Marka = input.Marka,
                Model = input.Model,
                ModelYear = input.ModelYear,
                Kilometer = input.Kilometer,
                Plaka = input.Plaka,
                SasiNo = input.SasiNo,
                MotorNo = input.MotorNo
            };

            context.CustomerCars.Add(customerCar);
            await context.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnCustomerCarAdded), customerCar, cancellationToken);

            return new AddCustomerCarPayload(customerCar);
        }
    }
}
