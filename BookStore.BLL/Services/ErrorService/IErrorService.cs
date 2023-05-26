using BookStore.DTO;

namespace BookStore.BLL.Services.ErrorService;

public interface IErrorService
{
    Task<ErrorModelDto> GetById(int id);
}