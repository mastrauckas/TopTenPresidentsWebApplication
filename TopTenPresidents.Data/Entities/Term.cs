using System.ComponentModel.DataAnnotations;

namespace TopTenPresidents.Data.Entities;

public record Term : BaseEntity<short>
{
     [Required]
     public DateOnly InaugurationDate { get; set; }

     public DateOnly? LastDayInOffice { get; set; }

     [Required]
     public short ElectionNumber { get; set; }

     [Required]
     public Office Office { get; set; } = null!;
}