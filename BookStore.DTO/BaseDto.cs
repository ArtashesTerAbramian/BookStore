namespace BookStore.DTO;

public class BaseDto
{
    public int Id { get; set; }
}
public class BaseDtoWithDate : BaseDto
{
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate { get; set; }
}

public class BaseAdminDtoWithDate : BaseDtoWithDate
{
    public bool IsDeleted { get; set; }
}
