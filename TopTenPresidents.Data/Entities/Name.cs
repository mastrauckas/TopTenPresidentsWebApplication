using System.ComponentModel.DataAnnotations;

namespace TopTenPresidents.Data.Entities;

public record Name : BaseEntity<short>
{
     [Required, MaxLength(100)]
     public string FirstName { get; set; } = null!;

     [MaxLength(100)]
     public string? MiddleName { get; set; }

     [Required, MaxLength(100)]
     public string LastName { get; set; } = null!;

     [Required]
     public DateOnly DateOfBirth { get; set; }

     public DateOnly? DateOfDeath { get; set; }
}