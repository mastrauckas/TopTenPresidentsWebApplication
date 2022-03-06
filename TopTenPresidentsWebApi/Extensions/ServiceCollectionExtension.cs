using TopTenPresidents.Data.DbContexts;
using TopTenPresidents.Data.Repositories;
using TopTenPresidents.Shared.Services;

namespace TopTenPresidentsWebApi.Extensions;

internal static class ServiceCollectionExtension
{
     internal static void ConfigureServices(this IServiceCollection services, string connectionString)
     {
          ConfigureInfrastructureServices(services, connectionString);
          ConfigureRepositories(services);
          ConfigureServices(services);
     }

     private static void ConfigureInfrastructureServices(IServiceCollection services, string connectionString)
     {
          // Add services to the container.
          // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
          services.AddEndpointsApiExplorer();
          services.AddSwaggerGen();
          services.AddSqlServer<TopTenPresidentsDbContext>(connectionString);
          services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
     }

     private static void ConfigureRepositories(IServiceCollection services)
     {
          services.AddTransient<INameRepository, NameRepository>();
     }

     private static void ConfigureServices(IServiceCollection services)
     {
          services.AddTransient<IPresidentService, PresidentService>();
     }
}
