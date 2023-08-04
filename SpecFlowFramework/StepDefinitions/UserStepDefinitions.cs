using SpecFlowFramework.Models.Request;
using SpecFlowFramework.Models.Response;
using SpecFlowFramework.Utils;
using System.Xml.Linq;
using TechTalk.SpecFlow.Infrastructure;

namespace SpecFlowFramework.StepDefinitions
{
    [Binding]
    internal sealed class UserStepDefinitions : APIClient
    {
        private readonly CreatePetReq createPetReq;
        private readonly TestContext _testContext;
        //private string petid = "922337201690012700";

        public UserStepDefinitions(CreatePetReq createPetReq, TestContext _testContext)
        { 
            this.createPetReq = createPetReq;
            this._testContext = _testContext;
        }

        [Given(@"User update payload")]
        public void GivenUserWithName()
        {
            createPetReq.id = 922337201690012700;
        }

        [Given(@"User with job ""([^""]*)""")]
        public void GivenUserWithJob(string job)
        {
            //createPetReq.job = job;
        }

        [When(@"Send request to ""([^""]*)"" user when petid is ""([^""]*)""")]
        public async Task WhenSendRequestToUser(string method, string id)
        {
            switch (method)
            {
                case "POST":
                    response = await SetUpRestClient().POSTPet<CreatePetReq>(createPetReq);
                    break;
                case "PUT":
                    response = await SetUpRestClient().PUTPet<CreatePetReq>(createPetReq);
                    break;
                case "GET":
                    response = await SetUpRestClient().GETPet();
                    break;
                case "DELETE":
                    response = await SetUpRestClient().DELETEPet();
                    break;
                default:
                    break;

            }
           
        }

        [Then(@"Validate status code is (.*)s")]
        public void ThenValidateStatusCodeIsS(int code)
        {
            var statuscode = response.StatusCode;
            var intCode = (int)statuscode;
            Assert.AreEqual(code, intCode);
            _testContext.WriteLine("Status Code is " + intCode);
        }

    }
}