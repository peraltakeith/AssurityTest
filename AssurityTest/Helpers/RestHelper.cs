using RestSharp;

namespace AssurityTest.Helpers
{
    public static class RestHelper
    {
        public static IRestResponse GetRequest(string endpoint)
        {
            var client = new RestClient(GlobalVariables.ClientUrl);
            var request = new RestRequest(endpoint, Method.GET);
            //request.AddHeader("Authorization", GlobalVariables.Token);
            var response = client.Execute(request);
            return response;
        }

        public static IRestResponse CreateOrUpdateRequest(string method, string endpoint, dynamic payload)
        {
            var client = new RestClient(GlobalVariables.ClientUrl);
            RestRequest request = new RestRequest();
            switch (method)
            {
                case "POST":
                    request = new RestRequest(endpoint, Method.POST);
                    break;
                case "PUT":
                    request = new RestRequest(endpoint, Method.PUT);
                    break;
                case "PATCH":
                    request = new RestRequest(endpoint, Method.PATCH);
                    break;
            }

            request.RequestFormat = DataFormat.Json;
            //request.AddHeader("Authorization", GlobalVariables.Token);
            request.AddJsonBody(payload);
            var response = client.Execute(request);
            return response;
        }

        public static IRestResponse DeleteRequest(string endpoint)
        {
            var client = new RestClient(GlobalVariables.ClientUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            //request.AddHeader("Authorization", GlobalVariables.Token);
            var response = client.Execute(request);
            return response;
        }
    }
}
