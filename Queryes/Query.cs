namespace Queryes;
using Model.Book;
using Model.Author;
public class Query
{

    public Book GetBook() =>
        new()
        {
            Title = "C# in depth.",
            Author = new Author("Jon Skeet")
        };
}