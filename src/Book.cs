public class Book : LibraryItem
{
    public Book(string title, DateTime? createdDate = null) : base(title, createdDate)
    { }
}