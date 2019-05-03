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
    class GifreteCyclePage
    {
        public GifreteCyclePage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//span[contains(text(),'Giftretecycle')]")]
        private IWebElement Gifretetext { get; set; }
        public void ClickOnGifrete()
        {
            Gifretetext.Click();
        }
        [FindsBy(How =How.XPath, Using = "//*[@id='content']/section[1]/div/div/div/h3")]
        private IWebElement Messageisdisplayed { get; set; }
        public bool IsMessageIsDisplayed()
        {
           return Messageisdisplayed.Displayed;
        }


    }
}
