using graphql.Models;

namespace graphql.Schema.Query;

[QueryType]
public static class Query
{
    public static Book GetBooks() => new Book( "Dy vjet pushime",345, new Author( "Kristi"));
}