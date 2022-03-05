using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace TopTenPresidents.Data.Entities;

public record BaseEntity<T> where T : struct
{
     public BaseEntity() { }

     public BaseEntity(T id) => Id = id;

     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public T Id { get; init; }
}

