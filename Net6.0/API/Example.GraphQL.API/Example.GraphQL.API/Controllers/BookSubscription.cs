using Example.GraphQL.ApplicationCore.DTOs;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;

namespace Example.GraphQL.API.Controllers
{
    public class BookSubscription
    {
        [Subscribe]
        public async Task<BookDto> AddBook([EventMessage] BookDto book) => book;

        [SubscribeAndResolve]
        public ValueTask<ISourceStream<BookDto>> AddBookById(Guid bookId, [Service] ITopicEventReceiver topicEventReceiver) =>
            topicEventReceiver.SubscribeAsync<string, BookDto>($"{bookId}_{nameof(BookSubscription.AddBookById)}");
    }
}
