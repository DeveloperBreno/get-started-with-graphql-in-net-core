namespace Model.Book
{
	using Model.Author;
    public class Book
	{

		
		public string Title { get; set; } = string.Empty;

		public Author ?Author { get; set; } = null;
	}
}