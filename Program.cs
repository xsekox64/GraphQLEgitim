using GraphQLEgitim.Data;
using GraphQLEgitim.GraphQL;
using GraphQLEgitim.GraphQL.CustomerCars;
using GraphQLEgitim.GraphQL.Customers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.Development.json");

var configuration = builder.Configuration;

var commandConStr = configuration.GetConnectionString("CommandConStr");

builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>{
    options.UseSqlServer(commandConStr);
});
builder.Services
.AddGraphQLServer()
.AddQueryType<Query>()
.AddMutationType<Mutation>()
.AddSubscriptionType<Subscription>()
.AddType<CustomerType>()
.AddType<AddCustomerInputType>()
.AddType<AddCustomerPayloadType>()
.AddType<CustomerCarType>()
.AddType<AddCustomerCarInputType>()
.AddType<AddCustomerCarPayloadType>()
.AddFiltering()
.AddSorting()
.AddInMemorySubscriptions();


var app = builder.Build();
app.UseRouting();
app.UseWebSockets();
app.UseGraphQLVoyager("/graphql-voyager");
#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(endpoints => {
    endpoints.MapGraphQL("/graphql");
});
#pragma warning restore ASP0014 // Suggest using top level route registrations


app.Run();
