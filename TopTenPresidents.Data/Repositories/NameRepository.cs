using Microsoft.EntityFrameworkCore;
using System;
using TopTenPresidents.Data.DbContexts;
using TopTenPresidents.Data.Entities;

namespace TopTenPresidents.Data.Repositories;

public class NameRepository : RepositoryBase<short, Name>, INameRepository
{
     public NameRepository(TopTenPresidentsDbContext context) : base(context)
     {
     }

     public async Task<IEnumerable<Name>> GetAllNames()
     {
          return await DbSet.ToListAsync();
     }
}
