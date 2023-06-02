namespace BookStore.DTO.BookDtos;

public class BookDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int StoreId { get; set; }
}