using System;

namespace GraphQLEgitim.GraphQL.Customers
{
    public record AddCustomerInput
    (string CustomerName,
    string CustomerSurname,
    string CustomerPhone,
    string CustomerEmail, 
    string CustomerAddress,
    string CustomerTcNo,
    bool Active);
}
