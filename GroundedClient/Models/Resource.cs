using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GroundedClient.Models
{
  public class Resource
  {
    public int ResourceId { get; set; }
    public string ResourceName { get; set; }
    public string ResourceQuote { get; set; }
    public string ResourceExercise { get; set; }
    public string ResourceMusic { get; set; }
    public string ResourceImage { get; set; }
    public string ResourceLink { get; set; }
    public string AltDescription { get; set; }

    public static List<Resource> GetResources()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Resource> resourceList = JsonConvert.DeserializeObject<List<Resource>>(jsonResponse.ToString());

      return resourceList;
    }

    public static Resource GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Resource resource = JsonConvert.DeserializeObject<Resource>(jsonResponse.ToString());

      return resource;
    }
  }
}