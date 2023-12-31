using System;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.Customers
{
    public class AddCustomerInputType : InputObjectType<AddCustomerInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCustomerInput> descriptor)
        {
            descriptor.Description("Bir müşteri eklemek için kullanılır.");

            descriptor.Field(p => p.CustomerName).Description("Müşterinin adını temsil eder.");

            base.Configure(descriptor);
        }
    }
}
