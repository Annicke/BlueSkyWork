using BlueSkyWork.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSkyWork.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[@class='font-size-15'][contains(text(),'Login')]")]
        private IWebElement Login { get; set; }
        public void ClickOnLogin()
        {
            Login.Click();
        }
        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement Emailaddress { get; set; }
        public void EnterEmailAddress(string EmailAddress)
        {
            Emailaddress.SendKeys(EmailAddress);
        }
        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement Emailaddress2 { get; set; }
        public void EnterEmailAddress2(string EmailAddress2)
        {
            Emailaddress2.SendKeys(EmailAddress2);
        }
        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement Password1 { get; set; }
        public void EnterPassword(string Password)
        {
            Password1.SendKeys(Password);
        }
        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement Password2 { get; set; }
        public void EnterPassword1(string Password1)
        {
            Password2.SendKeys(Password1);
        }

        [FindsBy(How = How.Id, Using = "btn_signin")]
        private IWebElement Signin { get; set; }
        public void ClickOnSignIn()
        {
            Signin.Click();
        }
        [FindsBy(How = How.XPath, Using = "//span[@class='font-size-15']")]
        private IWebElement Accountprofile { get; set; }
        public bool AccountProfileDisplayed()
        {
            return Accountprofile.Displayed;
        }

        [FindsBy(How = How.Id, Using = "dng_id_t")]
        private IWebElement Errormessage { get; set; }
        public string GetTextErrorMessage()
        {
            return Errormessage.Text;
        }
    }
}
