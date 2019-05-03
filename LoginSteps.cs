using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my emailaddress")]
        public void WhenIEnterMyEmailaddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on signin")]
        public void WhenIClickOnSignin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my emailaddress ""(.*)""")]
        public void WhenIEnterMyEmailaddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my password ""(.*)""")]
        public void WhenIEnterMyPassword(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My account profile is displayed")]
        public void ThenMyAccountProfileIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My account profile is not displayed")]
        public void ThenMyAccountProfileIsNotDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"messages (.*) is displayed for the (.*)")]
        public void ThenMessagesIsDisplayedForThe(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
