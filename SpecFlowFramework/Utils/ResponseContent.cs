using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Utils
{
    internal class ResponseContent
    {
        public static T GetResponseContent<T>(RestResponse response)
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
