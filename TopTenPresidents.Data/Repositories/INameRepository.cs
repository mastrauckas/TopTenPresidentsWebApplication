using TopTenPresidents.Data.Entities;

namespace TopTenPresidents.Data.Repositories;

public interface INameRepository
{
     Task<IEnumerable<Name>> GetAllNames();
}