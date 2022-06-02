namespace BookReviewer.Api.Models;

public class Author 
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public ICollection<Book> Books { get; set; } = default!;
}