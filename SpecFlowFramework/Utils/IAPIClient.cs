using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Utils
{
    internal interface IAPIClient
    {
        Task<RestResponse> POSTPet<T>(T payload) where T : class;
        Task<RestResponse> PUTPet<T>(T payload) where T : class;
        Task<RestResponse> GETPet();
        Task<RestResponse> DELETEPet();

    }
}
