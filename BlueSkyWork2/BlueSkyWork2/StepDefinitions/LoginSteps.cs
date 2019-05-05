using BlueSkyWork2.PageObjects;
using BlueSkyWork2.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork2.StepDefinitions
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
            Hooks.Driver.Navigate().GoToUrl("http://qa1.giftrt.com");
            Hooks.Driver.Manage().Window.Maximize();
            Hooks.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(20));
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
           Login.ClickOnLogin();
        }
        
        [When(@"I input my email address")]
        public void WhenIInputMyEmailAddress()
        {
           Login.EnterEmailAddress("sibaveun2016@gmail.com");
        }
        
        [When(@"I input my password")]
        public void WhenIInputMyPassword()
        {
           Login.EnterPassword("Sibaveun2016");
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            Login.ClickOnSignIn();
        }
        
        [Then(@"my user profile is displayed")]
        public void ThenMyUserProfileIsDisplayed()
        {
            Assert.IsTrue(Login.ProfileUserDisplayed());
        }
    }
}
