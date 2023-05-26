using BookStore.DAL.Models;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;

namespace BookStore.BLL.Services.AdminService;

public class AdminSessionService : IAdminSessionService
{
    public Admin CurrentAdmin { get; }
    public Task<Admin> GetByToken(string token)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<AdminSessionDto>> Add(LoginDto dto)
    {
        throw new NotImplementedException();
    }

    public ResponseDto<AdminDto> GetUserCurrentInfo()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<bool>> Delete()
    {
        throw new NotImplementedException();
    }
}