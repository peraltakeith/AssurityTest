using AssurityTest.Helpers;
using AssurityTest.Models.Category;
using AssurityTest.Models.Common;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AssurityTest.StepDefinitions
{
    [Binding]
    public class GetCategoryDetailsSteps
    {
        private APIResponse _apiResponse;
        private Category _categoryResponse;

        public GetCategoryDetailsSteps(APIResponse apiResponse)
        {
            _apiResponse = apiResponse;
        }

        #region GivenSteps
        [Given(@"I call the GET categories endpoint ""(.*)""")]
        public void GivenICallTheGETCategoriesEndpoint(string endpoint)
        {
            _apiResponse.Response = RestHelper.GetRequest(endpoint);
        }
        #endregion

        #region ThenSteps
        [Then(@"I should get a response with status code (.*)")]
        public void ThenIShouldGetAResponseWithStatusCode(int expectedStatusCode)
        {
            int actualStatusCode = Convert.ToInt32(_apiResponse.Response.StatusCode);
            Assert.AreEqual(expectedStatusCode, actualStatusCode, "The http status code in the response should be 200.");
        }
        
        [Then(@"the Name in the response should be ""(.*)""")]
        public void ThenTheNameInTheResponseShouldBe(string expectedName)
        {
            _categoryResponse = DeserializationHelper.Deserialize<Category>(_apiResponse.Response);
            Assert.AreEqual(expectedName, _categoryResponse.Name, $"The Name in the response should be {expectedName}.");
        }

        [Then(@"CanRelist value in the response should be true")]
        public void ThenCanRelistValueInTheResponseShouldBeTrue()
        {
            Assert.IsTrue(_categoryResponse.CanRelist, "The CanRelist value in the response should be true.");
        }
        
        [Then(@"the Promotions element with the name ""(.*)"" should have a Description that contains the text ""(.*)""")]
        public void ThenThePromotionsElementWithTheNameShouldHaveADescriptionThatContainsTheText(string promotionName, string expectedDescription)
        {
            foreach (Promotion promotion in _categoryResponse.Promotions)
            {
                if (promotionName.Equals(promotion.Name))
                {
                    StringAssert.Contains(expectedDescription, promotion.Description, 
                        $"The description in the Gallery promotion does not contain {expectedDescription}");
                }
            }
        }
        #endregion
    }
}
