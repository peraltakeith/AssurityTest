using AssurityTest.Helpers;
using AssurityTest.Models.Common;
using BoDi;
using TechTalk.SpecFlow;

namespace AssurityTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private APIResponse _apiResponse;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Setup()
        {
            GlobalVariables.ClientUrl = "https://api.tmsandbox.co.nz";
            _objectContainer.RegisterInstanceAs(_apiResponse);
        }

        [AfterScenario]
        public void Cleanup()
        {
            GlobalVariables.ClientUrl = null;
        }
    }
}
