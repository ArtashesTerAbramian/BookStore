using BookStore.BLL.Filters.BookFilters;
using BookStore.DTO;
using BookStore.DTO.BookDtos;

namespace BookStore.BLL.Services.BookService;

public interface IBookService
{
    Task<ResponseDto<BookDto>> GetById(int Id);
    Task<ResponseDto<PagedModelDto<BookDto>>> GetAll(BookFilter filter);
    Task<ResponseDto<BookDto>> Add(AddBookDto dto);
    Task<ResponseDto<BookDto>> Update(UpdateBookDto dto);
    Task<ResponseDto<bool>> Delete(int Id);
}