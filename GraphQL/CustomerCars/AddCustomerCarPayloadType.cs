using System;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.CustomerCars
{
    public class AddCustomerCarPayloadType : ObjectType<AddCustomerCarPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCustomerCarPayload> descriptor)
        {
            descriptor.Description("Eklenen bir customer car için kayıt işlemini temsil eder");
            descriptor.Field(c => c.customerCar).Description("Eklenen customercar ı temsil eder");
            base.Configure(descriptor);
        }
    }
}
