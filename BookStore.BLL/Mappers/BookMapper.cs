using AutoMapper;
using BookStore.DAL.Models;
using BookStore.DTO.BookDtos;

namespace BookStore.BLL.Mappers;

public class BookMapper : Profile
{
    public BookMapper()
    {
        CreateMap<BookDto, Book>()
            .ReverseMap();
    }
}