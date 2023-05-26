using SmartFormat;
using BookStore.BLL.Services.ErrorService;
using BookStore.DTO;

namespace BookStore.BLL.Helpers
{
    public class ErrorHelper
    {
        private readonly IErrorService _errorService;

        public ErrorHelper(IErrorService errorService)
        {
            _errorService = errorService;
        }

        public async Task<ResponseDto<T>> SetError<T>(ResponseDto<T> response, int id)
        {
            var error = await _errorService.GetById(id);


            return await SetError(response, error);
        }

        public async Task<ResponseDto> SetError(ResponseDto response, int id, object arg = null)
        {
            var error = await _errorService.GetById(id);
            if (arg is not null)
            {
                error.Description = Smart.Format(error.Description, arg);
            }

            response.Errors = new List<ErrorModelDto>() { error };

            return response;
        }

        public async Task<ResponseDto<T>> SetError<T>(ResponseDto<T> response, int id, object arg)
        {
            var error = await _errorService.GetById(id);

            error.Description = Smart.Format(error.Description, arg);

            return await SetError(response, error);
        }

        public async Task<ResponseDto<T>> SetError<T>(ResponseDto<T> response, ErrorModelDto error)
        {
            response.Data = default;
            response.Errors = new List<ErrorModelDto>() { error };

            return await Task.FromResult(response);
        }
    }
}
