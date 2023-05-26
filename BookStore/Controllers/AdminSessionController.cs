using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BookStore.BLL.Services.AdminService;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;

namespace BookStore.Admin.API.Controllers
{
    [Route("api/admin-session")]
    [ApiController]
    public class AdminSessionController : ControllerBase
    {
        private readonly IAdminSessionService _adminSessionService;

        public AdminSessionController(IAdminSessionService adminSessionService)
        {
            _adminSessionService = adminSessionService;
        }

        [HttpPost("login")]
        public async Task<ResponseDto<AdminSessionDto>> Add(LoginDto dto)
        {
            return await _adminSessionService.Add(dto);
        }

        [Authorize]
        [HttpPost("log-out")]
        public async Task<ResponseDto<bool>> Delete()
        {
            return await _adminSessionService.Delete();
        }

        [Authorize]
        [HttpPost("get-user-info")]
       public async Task<ResponseDto<AdminDto>> GetUserCurrentInfo()
        {
            return await Task.FromResult(_adminSessionService.GetUserCurrentInfo());
        }
    }
}
