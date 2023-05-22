using BookStore.DTO.AutherDtos;

namespace BookStore.DTO.BookDtos;

public class AddBookDto : BaseDto
{
    public string Name { get; set; }
    public AuthorDto Author { get; set; }
}