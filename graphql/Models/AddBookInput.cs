namespace graphql.Models;

public record AddBookInput
(
    BookInput Book,
    Author Author
);