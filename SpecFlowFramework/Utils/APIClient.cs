using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Utils
{
    internal class APIClient : IAPIClient, IDisposable
    {
        public static RestResponse response;
        public static RestRequest request;
        public static string responsebody;
        public static RestClient restClient;
        const string BASE_URL = "https://petstore.swagger.io";
        public static TestContext _testContext;

        public APIClient()
        {
            var options = new RestClientOptions(BASE_URL);
            restClient = new RestClient(options);
        }

        public static APIClient SetUpRestClient()
        {
            var api = new APIClient();
            return api;
        }

        public async Task<RestResponse> POSTPet<T>(T payload) where T : class
        {
            var request = new RestRequest(EndPoints.CREATE_PET, Method.Post);
            request.AddBody(payload);
            return await restClient.ExecuteAsync<T>(request);
        }

        public async Task<RestResponse> DELETEPet()
        {
            var request = new RestRequest(EndPoints.DELETE_PET, Method.Delete);
            return await restClient.ExecuteAsync(request);
        }

        public async Task<RestResponse> GETPet()
        {
            var request = new RestRequest(EndPoints.GET_PET, Method.Get);
            return await restClient.ExecuteAsync(request);
        }


        public async Task<RestResponse> PUTPet<T>(T payload) where T : class
        {
            var request = new RestRequest(EndPoints.UPDATE_PET, Method.Put);
            request.AddBody(payload);
            return await restClient.ExecuteAsync(request);
        }

        //clear all rest client functions
        public void Dispose()
        {
            restClient?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
