namespace BookStore.DAL.Models;

public class Admin : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
}