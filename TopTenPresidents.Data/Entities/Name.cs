using System.ComponentModel.DataAnnotations;

namespace TopTenPresidents.Data.Entities;

public record Name : BaseEntity<short>
{
     [Required, MaxLength(100)]
     public string FirstName { get; set; } = null!;

     [Required, MaxLength(100)]
     public string MiddleName { get; set; } = null!;

     [Required, MaxLength(100)]
     public string LastName { get; set; } = null!;

     public DateTime DateOfBirth { get; set; }

     public DateTime DateOfDeath { get; set; }
}