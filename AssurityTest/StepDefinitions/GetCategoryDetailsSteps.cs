using System;
using TechTalk.SpecFlow;

namespace AssurityTest.StepDefinitions
{
    [Binding]
    public class GetCategoryDetailsSteps
    {
        [Given(@"I call the GET categories endpoint ""(.*)""")]
        public void GivenICallTheGETCategoriesEndpoint(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should get a response with status code (.*)")]
        public void ThenIShouldGetAResponseWithStatusCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Name in the response should be ""(.*)""")]
        public void ThenTheNameInTheResponseShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"CanRelist value in the response should be ""(.*)""")]
        public void ThenCanRelistValueInTheResponseShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Promotions element with the name ""(.*)"" should have a Description that contains the text ""(.*)""")]
        public void ThenThePromotionsElementWithTheNameShouldHaveADescriptionThatContainsTheText(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
