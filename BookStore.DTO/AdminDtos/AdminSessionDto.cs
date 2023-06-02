namespace BookStore.DTO.AdminDtos;

public class AdminSessionDto
{
    public long AdminId { get; set; }
    public string Token { get; set; }
    public bool IsExpired { get; set; }
}