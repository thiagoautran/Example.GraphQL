using Example.GraphQL.ApplicationCore.DTOs;
using Example.GraphQL.Infrastructure.Data;

namespace Example.GraphQL.API.Controllers
{
    public class BookQuery
    {
        public Task<BookDto> GetBook([Service] BookRepository repository) =>
            repository.GetBookAsync();

        public Task<IList<BookDto>> GetBooks([Service] BookRepository repository) =>
            repository.GetBooksAsync();
    }
}