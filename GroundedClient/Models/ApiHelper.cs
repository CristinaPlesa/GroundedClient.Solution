using System.Threading.Tasks;
using RestSharp;

namespace GroundedClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"resources", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"resources/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}