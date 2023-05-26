using BookStore.DTO;
using BookStore.DTO.AdminDtos;
using BookStore.DAL.Models;

namespace BookStore.BLL.Services.AdminService;

public interface IAdminSessionService
{
    Admin CurrentAdmin { get; }

    Task<Admin> GetByToken(string token);
    Task<ResponseDto<AdminSessionDto>> Add(LoginDto dto);
    ResponseDto<AdminDto> GetUserCurrentInfo();
    Task<ResponseDto<bool>> Delete();
}