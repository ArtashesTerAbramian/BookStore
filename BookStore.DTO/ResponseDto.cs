using System.Collections.Generic;
using System.Linq;

namespace BookStore.DTO;


public class ResponseDto
{
    public bool HasError => Errors != null && Errors.Any();
    public List<ErrorModelDto> Errors { get; set; }
}
public class ResponseDto<T> 
{
    public T Data { get; set; }
    public bool HasError => Errors != null && Errors.Any();
    public List<ErrorModelDto> Errors { get; set; }

    public ResponseDto() : this(default)
    {

    }

    public ResponseDto(T value)
    {
        Data = value;
    }

    public static implicit operator ResponseDto<T>(ResponseDto result)
    {
        return new ResponseDto<T>()
        {
            Errors = result.Errors,
            Data = default
        };
    }
}