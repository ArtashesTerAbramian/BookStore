using AutoMapper;
using BookStore.BLL.Constants;
using BookStore.BLL.Filters.BookFilters;
using BookStore.BLL.Helpers;
using BookStore.DAL;
using BookStore.DAL.Enums;
using BookStore.DAL.Models;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;
using BookStore.DTO.BookDtos;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services.BookService;

public class BookService : IBookService
{
    private readonly AppDbContext _db;
    private readonly IMapper _mapper;
    private readonly ErrorHelper _error;

    public BookService(AppDbContext db,
        IMapper mapper,
        ErrorHelper error)
    {
        _db = db;
        _mapper = mapper;
        _error = error;
    }
    
    public async Task<ResponseDto<BookDto>> GetById(int Id)
    {
        var respone = new ResponseDto<BookDto>();

        var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == Id);
        if (book is null || book.IsDeleted)
        {
            return await _error.SetError(respone, ErrorConstants.ItemNotFound);
        }

        respone.Data = _mapper.Map<BookDto>(book);

        return respone;

    }

    public async Task<ResponseDto<PagedModelDto<BookDto>>> GetAll(BookFilter filter)
    {
        var response = new ResponseDto<PagedModelDto<BookDto>>();

        var query = _db.Books.AsQueryable();

        var books = _mapper.Map<List<BookDto>>(await filter.FilterObjects(query).ToListAsync());
        
        response.Data = new PagedModelDto<BookDto>()
        {
            Entities = books,
            Count = await filter.CountAsync(query)
        };
        
        return response;
    }

    public async Task<ResponseDto<BookDto>> Add(AddBookDto dto)
    {
        var response = new ResponseDto<BookDto>();

        var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == dto.CategoryId);
        if (category is null)
        {
            return await _error.SetError(response, ErrorConstants.CategoryNotFound);
        }

        var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == dto.AuthorId);
        if (author is null)
        {
            return await _error.SetError(response, ErrorConstants.AuthorNotFound);
        }

        var store = await _db.Stores.FirstOrDefaultAsync(x => x.Id == dto.StoreId);
        if (store is null)
        {
            return await _error.SetError(response, ErrorConstants.StoreNotFound);
        }
        var book = new Book()
        {
            CategoryId = category.Id,
            AuthorId = author.Id,
            Name = dto.Name,
            Description = dto.Description,
            Title = dto.Title,
            StoreId = dto.StoreId
        };

        await _db.Books.AddAsync(book);
        await _db.SaveChangesAsync();
        
        return response;
    }

    public Task<ResponseDto<BookDto>> Update(UpdateBookDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<bool>> Delete(int Id)
    {
        throw new NotImplementedException();
    }
}