namespace BookStore.DAL.Models;

public class AdminSession : BaseEntity
{
    public int AdminId { get; set; }
    public string Token { get; set; }
    public bool IsExpired { get; set; }
    public Admin Admin { get; set; }
}