using Example.GraphQL.ApplicationCore.DTOs;
using Example.GraphQL.Infrastructure.Data;
using HotChocolate.Subscriptions;

namespace Example.GraphQL.API.Controllers
{
    public class BookMutation
    {
        public async Task<bool> AddBook(BookDto book, [Service] BookRepository repository, [Service] ITopicEventSender topicEventSender)
        {
            await repository.AddBook(book);

            await topicEventSender.SendAsync(nameof(BookSubscription.AddBook), book);
            await topicEventSender.SendAsync($"{book.Id}_{nameof(BookSubscription.AddBookById)}", book);

            return true;
        }
    }
}