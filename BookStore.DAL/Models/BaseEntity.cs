using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Models;

[NotMapped]
public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifyDate {get; set; }
    public bool IsDeleted { get; set; }
}