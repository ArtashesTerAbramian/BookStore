using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models;

[NotMapped]
public class BaseEntity
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModiftyDate {get; set; }
    public bool IsDeleted { get; set; }
}