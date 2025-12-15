using graphql.Schema.Mutations;
using graphql.Schema.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services
    .AddGraphQLServer()
    .AddDefaultTransactionScopeHandler()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGraphQL();

app.UseHttpsRedirection();

app.Run();

