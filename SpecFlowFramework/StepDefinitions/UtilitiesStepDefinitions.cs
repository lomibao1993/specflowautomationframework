using SpecFlowFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.StepDefinitions
{
    [Binding]
    internal sealed class UtilitiesStepDefinitions : APIClient
    {
        [Then(@"Close rest client")]
        public void ThenCloseRestClient()
        {
            Dispose();
        }

    }
}
