using BookStore.BLL.Services.AdminService;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        
       
        [HttpGet("get-by-id")]
        public async Task<ResponseDto<AdminDto>> Get(int id)
        {
            return await _adminService.GetById(id);
        }

        // POST: api/Admin
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
