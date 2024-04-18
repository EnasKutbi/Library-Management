public class Library {
    private List<Book> _books;
    private List<User> _users;
    
    public Library(){
        _users = new List<User>();
        _books = new List<Book>();
    }

    public List<Book> GetAllBooks(int pageNumber, int limitPerPage){
        return _books.OrderBy(book => book.CreatedDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }
    public List<User> GetAllUsers(int pageNumber, int limitPerPage)
    {
        return _users.OrderBy(user => user.CreatedDate).Skip((pageNumber - 1) * limitPerPage).Take(limitPerPage).ToList();
    }
    public List<Book> FindBooksByTitle(string title){
        return _books.FindAll(book => book.Title.Contains(title));
    }
    public List<User> FindUsersByName(string name)
    {
        return _users.FindAll(user => user.Title.Contains(name));
    }
    public void AddBook(Book book){
        _books.Add(book);
    }
    public void AddUser(User user)
    {
        _users.Add(user);
    }
    public void DeleteBook(Guid id)
    {
        Book bookToDeleted = _books.Find(book => book.Id == id);
        if (bookToDeleted != null)
        {
            _books.Remove(bookToDeleted);
        } else
        {
            Console.WriteLine($"Book with {id} was not found");
        }
    }
    public void DeleteUser(Guid id)
    {
        User userToDeleted = _users.Find(user => user.Id == id);
        if (userToDeleted != null)
        {
            _users.Remove(userToDeleted);
        }
        else
        {
            Console.WriteLine($"User with {id} was not found");
        }
    }

}