using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopTenPresidents.Data.Entities;

public record Office : BaseEntity<short>
{
     [Required]
     public Name PresidentName { get; set; } = null!;

     [Required]
     public Name VicePresidentName { get; set; } = null!;

     [Required, MaxLength(100)]
     public string PolicitalParty { get; set; } = null!;

     [Required]
     public List<Term> Terms { get; set; } = null!;
}
