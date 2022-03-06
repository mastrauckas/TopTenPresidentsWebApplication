using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopTenPresidents.Data.Entities;

public record BaseEntity<TPrimaryKeyTyp> 
     where TPrimaryKeyTyp : struct
{
     public BaseEntity() { }

     public BaseEntity(TPrimaryKeyTyp id) => Id = id;

     [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public TPrimaryKeyTyp Id { get; init; }
}

