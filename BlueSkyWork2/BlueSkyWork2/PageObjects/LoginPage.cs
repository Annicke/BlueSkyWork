using BlueSkyWork2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSkyWork2.PageObjects
{
    class LoginPage
    {
        public LoginPage()
          {
            PageFactory.InitElements(Hooks.Driver, this);
          }
        [FindsBy(How =How.XPath, Using = "//span[@class='font-size-15'][contains(text(),'Login')] ")]
        private IWebElement Login { get; set; }
        public void ClickOnLogin()
        {
            Login.Click();
        }
        //user_email
        [FindsBy(How =How.Id, Using = "user_email")]
        private IWebElement Emailaddress { get; set; }

        public void EnterEmailAddress(string EmailAddress)
        {
            Emailaddress.SendKeys(EmailAddress);
        }
        [FindsBy(How =How.Id, Using = "user_password")]
        private IWebElement PasswordRef { get; set; }
        public void EnterPassword(string Password)
        {
            PasswordRef.SendKeys(Password);
        }
        [FindsBy(How =How.Id, Using = "btn_signin")]
        private IWebElement Signin { get; set; }
        public void ClickOnSignIn()
        {
            Signin.Click();
        }
        [FindsBy(How =How.XPath, Using = "//div[@class='mb--10']//img[@class='brd-img'] ")]
        private IWebElement Profileuser { get; set; }
        public bool ProfileUserDisplayed()
        {
            return Profileuser.Displayed;
        }


    }
}
