using System;
using GraphQLEgitim.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL
{
    [GraphQLDescription("Mevcut sorguları anlık olarak bildirir.")]
    public class Subscription
    {
        [Subscribe]
        [Topic]
        [GraphQLDescription("Eklenen müşterinin anlık bildirimi.")]
        public Customer OnCustomerAdded([EventMessage] Customer customer)
        {
            return customer;
        }

        public CustomerCar OnCustomerCarAdded([EventMessage] CustomerCar customerCar)
        {
            return customerCar;
        }
    }
}
