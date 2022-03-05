using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TopTenPresidents.Data.Boilerplate;

/// <summary>
/// Compares <see cref="DateOnly?" />.
/// </summary>
public class NullableDateOnlyComparer : ValueComparer<DateOnly?>
{
     /// <summary>
     /// Creates a new instance of this converter.
     /// </summary>
     public NullableDateOnlyComparer() : base(
         (d1, d2) => d1 == d2 && d1.GetValueOrDefault().DayNumber == d2.GetValueOrDefault().DayNumber,
         d => d.GetHashCode())
     {
     }
}
