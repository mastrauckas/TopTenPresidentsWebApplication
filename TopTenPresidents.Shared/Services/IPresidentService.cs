using TopTenPresidents.Shared.TransferDtos;

namespace TopTenPresidents.Shared.Services;

public interface IPresidentService
{
     Task<IEnumerable<PresidentTransferDto>> GetAllPresidents();
}