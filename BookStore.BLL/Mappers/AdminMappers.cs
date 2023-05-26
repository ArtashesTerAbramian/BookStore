using AutoMapper;
using BookStore.DAL.Models;
using BookStore.DTO.AdminDtos;

namespace BookStore.BLL.Mappers;

public class AdminMappers : Profile
{
    public AdminMappers()
    {
        CreateMap<Admin, AdminDto>();
    }
}