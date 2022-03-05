
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace TopTenPresidents.Test.Integration;

public class IntegrationTestApiCalls
{
     [Fact]
     public async Task TestGetPresidents()
     {
          var expected = 45;
          var presidents = await CallCleint<IEnumerable<string>>();

          Assert.NotNull(presidents);
          Assert.Equal(expected, presidents?.Count());
     }

     private static async Task<T?> CallCleint<T>(HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
     {
          var application = new TopTenPresidentsApplication();
          var client = application.CreateClient();
          var results = await client.GetAsync("/GetPresidents");

          Assert.NotNull(results);
          Assert.Equal(expectedStatusCode, results.StatusCode);

          if(results.IsSuccessStatusCode)
          {
               var content = await results.Content.ReadFromJsonAsync<T?>();
               return content;
          }
          
          return default;
     }
}
