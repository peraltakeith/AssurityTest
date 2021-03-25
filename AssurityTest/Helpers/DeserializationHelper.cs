using Newtonsoft.Json;
using RestSharp;

namespace AssurityTest.Helpers
{
    public static class DeserializationHelper
    {
        public static T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
