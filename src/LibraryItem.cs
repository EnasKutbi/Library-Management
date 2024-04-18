public class LibraryItem
{
    public Guid Id { get; }
    public string Title { get; }
    public DateTime CreatedDate { get; }

    public LibraryItem(string title, DateTime? createdDate = null)
    {
        Id = Guid.NewGuid();
        Title = title;
        CreatedDate = createdDate ?? DateTime.Now;
    }
}