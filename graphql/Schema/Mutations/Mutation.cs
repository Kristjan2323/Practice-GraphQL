using graphql.Models;

namespace graphql.Schema.Mutations;

public class Mutation
{
    public static List<BookResults> Books { get; set; } = new();
    
    public List<BookResults> AddBook(BookInput bookInput, Author author)
    {
        var book = new BookResults(
            new Book(
                Id:bookInput.Id,
                Title: bookInput.Title,
                Pages: bookInput.Pages
            ),
            author
        );
        Books.Add(book);
        return Books;
    }
}