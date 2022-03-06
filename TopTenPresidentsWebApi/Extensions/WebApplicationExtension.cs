using TopTenPresidents.Data.Repositories;
using TopTenPresidents.Shared.Services;

namespace TopTenPresidentsWebApi.Extensions;

internal static class WebApplicationExtension
{
     internal static void ConfigureApis(this WebApplication webApplication)
     {
          webApplication.MapGet("/GetPresidents", async (IPresidentService presidentService) => await presidentService.GetAllPresidents());
     }
}
