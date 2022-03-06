using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopTenPresidents.Data.Entities;

public record BaseEntity<T> where T : struct
{
     public BaseEntity() { }

     public BaseEntity(T id) => Id = id;

     [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public T Id { get; init; }
}

