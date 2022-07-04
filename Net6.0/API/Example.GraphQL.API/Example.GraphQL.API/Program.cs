using Example.GraphQL.API.Controllers;
using Example.GraphQL.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<BookRepository>()
    .AddGraphQLServer()
    .AddQueryType<BookQuery>()
    .AddMutationType<BookMutation>()
    .AddSubscriptionType<BookSubscription>()
    .AddInMemorySubscriptions();

var app = builder.Build();

app.UseRouting();
app.UseWebSockets();
app.MapGraphQL();

app.Run();