using System;

namespace GraphQLEgitim.GraphQL.CustomerCars
{
    public record AddCustomerCarInput
    (
        int CustomerId,
        string Marka,
        string Model,
        string ModelYear,
        string Kilometer,
        string Plaka,
        string SasiNo,
        string MotorNo
    );
}
