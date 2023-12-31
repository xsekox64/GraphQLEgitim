using System;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.Customers
{
    public class AddCustomerPayloadType : ObjectType<AddCustomerPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCustomerPayload> descriptor)
        {
            descriptor.Description("Eklenen müşterileri hepsini temsil eder.");

            descriptor.Field(p => p.customer).Description("Ekleme yapılan müşteriyi temsil eders.");


            base.Configure(descriptor);
        }
    }
}
