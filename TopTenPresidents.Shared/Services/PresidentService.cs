using AutoMapper;
using TopTenPresidents.Data.Repositories;
using TopTenPresidents.Shared.TransferDtos;

namespace TopTenPresidents.Shared.Services;

public class PresidentService : IPresidentService
{
     private readonly INameRepository _nameRepository;
     private readonly IMapper _mapper;

     public PresidentService(INameRepository nameRepository, IMapper mapper)
     {
          _nameRepository = nameRepository;
          _mapper = mapper;
     }

     public async Task<IEnumerable<PresidentTransferDto>> GetAllPresidents()
     {
          var presidentNames = await _nameRepository.GetAllNames();
          return _mapper.Map<List<PresidentTransferDto>>(presidentNames);
     }
}
