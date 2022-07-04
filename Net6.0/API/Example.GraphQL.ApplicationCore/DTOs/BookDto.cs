﻿namespace Example.GraphQL.ApplicationCore.DTOs
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public AuthorDto Author { get; set; }
    }
}