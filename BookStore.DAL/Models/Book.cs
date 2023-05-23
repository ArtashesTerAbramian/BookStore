namespace BookStore.DAL.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public Author Author { get; set; }
    public Category Category { get; set; }
}