using Example.GraphQL.ApplicationCore.DTOs;

namespace Example.GraphQL.Infrastructure.Data
{
    public class BookRepository
    {
        IList<BookDto> Books = new List<BookDto>
        {
            new BookDto
            {
                Id = Guid.NewGuid(),
                Title = "book 1",
                Author = new AuthorDto
                {
                    Id = Guid.NewGuid(),
                    Name = "author 1"
                }
            },
            new BookDto
            {
                Id = Guid.NewGuid(),
                Title = "book 2",
                Author = new AuthorDto
                {
                    Id = Guid.NewGuid(),
                    Name = "author 2"
                }
            }
        };

        public Task<BookDto> GetBookAsync() => Task.FromResult(Books.First());

        public Task<IList<BookDto>> GetBooksAsync() => Task.FromResult(Books);

        public Task AddBook(BookDto book)
        {
            Books.Add(book);
            return Task.CompletedTask;
        }
    }
}