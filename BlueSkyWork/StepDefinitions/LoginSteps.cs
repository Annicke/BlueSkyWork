using BlueSkyWork.PageObjects;
using BlueSkyWork.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage Login;
        public LoginSteps()
        {
            Login = new LoginPage();
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("http://qa1.giftrt.com");
            Hooks.driver.Manage().Window.Maximize();
            Hooks.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(10));
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Login.ClickOnLogin();
        }
        
        [When(@"I enter my emailaddress")]
        public void WhenIEnterMyEmailaddress()
        {
            Login.EnterEmailAddress("sibaveun2016@gmail.com");
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            Login.EnterPassword("Sibaveun2016");
        }
        
        [When(@"I click on signin")]
        public void WhenIClickOnSignin()
        {
           Login.ClickOnSignIn ();
        }
        
        [When(@"I enter my emailaddress ""(.*)""")]
        public void WhenIEnterMyEmailaddress(string email)
        {
           Login.EnterEmailAddress2("sihanen@gmail.com");
        }
        
        [When(@"I enter my password ""(.*)""")]
        public void WhenIEnterMyPassword(int password)
        {
            Login.EnterPassword1("123");
        }
        
        [Then(@"My account profile is displayed")]
        public void ThenMyAccountProfileIsDisplayed()
        {
           Assert.IsTrue(Login.AccountProfileDisplayed());
        }
        
        [Then(@"My account profile is not displayed")]
        public void ThenMyAccountProfileIsNotDisplayed()
        {
            Assert.IsNotNull(Login.GetTextErrorMessage());
        }
        
        [Then(@"messages (.*) is displayed for the (.*)")]
        public void ThenMessagesIsDisplayedForThe(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
