using Microsoft.EntityFrameworkCore;
using System;
using TopTenPresidents.Data.Boilerplate;
using TopTenPresidents.Data.Entities;

namespace TopTenPresidents.Data.DbContexts;

public class TopTenPresidentsDbContext : DbContext
{
     public TopTenPresidentsDbContext(DbContextOptions<TopTenPresidentsDbContext> options) : base(options) {  }

     public DbSet<Name> Names { get; set; } = null!;

     public DbSet<Office> Offices { get; set; } = null!;

     public DbSet<Term> Terms { get; set; } = null!;

     protected override void ConfigureConventions(ModelConfigurationBuilder builder)
     {
          builder.Properties<DateOnly>()
              .HaveConversion<DateOnlyConverter, DateOnlyComparer>()
              .HaveColumnType("date");

          builder.Properties<DateOnly?>()
              .HaveConversion<NullableDateOnlyConverter, NullableDateOnlyComparer>()
              .HaveColumnType("date");
     }

     protected override void OnModelCreating(ModelBuilder builder)
     {
          base.OnModelCreating(builder);
     }
}