using Microsoft.EntityFrameworkCore;
using TopTenPresidents.Data.DbContexts;
using TopTenPresidents.Data.Entities;

namespace TopTenPresidents.Data.Repositories;

public class RepositoryBase<TPrimaryKeyTyp, TEntity> 
     where TPrimaryKeyTyp : struct
     where TEntity : BaseEntity<TPrimaryKeyTyp>
{
     protected TopTenPresidentsDbContext Context { get; init; }

     protected DbSet<TEntity> DbSet { get; init; }

     public RepositoryBase(TopTenPresidentsDbContext context)
     {
          Context = context ?? throw new ArgumentNullException(nameof(context));
          DbSet = context.Set<TEntity>();
     }
}
