namespace BookStore.DAL.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
    public Category Category { get; set; }
}