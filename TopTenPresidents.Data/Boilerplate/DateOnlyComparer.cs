
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TopTenPresidents.Data.Boilerplate;

public class DateOnlyComparer : ValueComparer<DateOnly>
{
     /// <summary>
     /// Creates a new instance of this converter.
     /// </summary>
     public DateOnlyComparer() : base(
         (d1, d2) => d1 == d2 && d1.DayNumber == d2.DayNumber,
         d => d.GetHashCode())
     {
     }
}