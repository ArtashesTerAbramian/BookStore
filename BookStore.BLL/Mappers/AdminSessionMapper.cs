using AutoMapper;
using BookStore.DAL.Models;
using BookStore.DTO.AdminDtos;

namespace BookStore.BLL.Mappers;

public class AdminSessionMapper : Profile
{
    public AdminSessionMapper()
    {
        CreateMap<AdminSession, AdminSessionDto>()
            .ReverseMap();
    }
}