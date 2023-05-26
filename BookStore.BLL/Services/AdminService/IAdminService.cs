using BookStore.BLL.Filters.AdminFilters;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;

namespace BookStore.BLL.Services.AdminService
{
    public interface IAdminService
    {
        Task<ResponseDto<AdminDto>> GetById(int id);
        Task<ResponseDto<PagedModelDto<AdminDto>>> GetAll(AdminFilter filter);
        Task<ResponseDto<AdminDto>> Add(AddAdminDto dto);
        Task<ResponseDto<AdminDto>> Update(UpdateAdminDto dto);
        Task<ResponseDto<bool>> Delete(DeleteAdminDto dto);
    }
}
