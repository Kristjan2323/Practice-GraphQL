using graphql.Models;

namespace graphql.Schema.Query;

public class Query
{
     private static readonly List<Author> Authors = new()
    {
        new Author(1, "Kristi"),
        new Author(2, "John Doe"),
        new Author(3, "Jane Smith")
    };

      private static readonly List<BookResults> BooksList = new()
    {
        new BookResults(new Book (1,"Dy vjet pushime", 345), Authors[0]),
        new BookResults(new Book(2,"The Great Adventure", 280), Authors[1]),
        new BookResults(new Book(3,"Learning GraphQL", 420), Authors[2])
    };

        public List<BookResults> GetBooks() => BooksList;
        public Author GetAuthor(int id) => Authors[id];

}