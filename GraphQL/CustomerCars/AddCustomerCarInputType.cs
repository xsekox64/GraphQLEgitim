using System;
using HotChocolate.Types;

namespace GraphQLEgitim.GraphQL.CustomerCars
{
    public class AddCustomerCarInputType : InputObjectType<AddCustomerCarInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCustomerCarInput> descriptor)
        {
            descriptor.Description("Bir customer car tablosuna eklenecek girişi temsil eder.");
            descriptor.Field(c => c.CustomerId)
            .Description("Customer car tablosunun ait olduğu customer tablosunun id sini temsil eder.");
            base.Configure(descriptor);
        }
    }
}
