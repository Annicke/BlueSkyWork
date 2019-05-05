using BlueSkyWork.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSkyWork.PageObjects
{
    class CommunityPage
    {
        public CommunityPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='breadcrumb-area bg--white-6 breadcrumb-bg-1 pt--60 pb--70 pt-lg--40 pb-lg--50 pt-md--30 pb-md--40']")]
        private IWebElement MyAccount { get; set; }
        public string GetTextyMyAccount()
        {
           return MyAccount.Text;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div/div/div/ul/a[2]")]
        private IWebElement Communitylink { get; set; }
        public void ClickOnCommunityLink()
        {
            Communitylink.Click();
        }
     
        [FindsBy(How = How.XPath, Using = "//*[@id='all - communities']/div[1]/div/a")]
        private IWebElement Createnewelement { get; set; }
        public void ClickOnCreateNewElement()
        {
            Createnewelement.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='name']")]
        private IWebElement Communityname { get; set; }
        public void EnterCommunityName(string Family)
        {
            Communityname.SendKeys(Family);
        }
        [FindsBy(How = How.Id, Using = "")]
        private IWebElement CommunityDescription { get; set; }
        public void EnterCommunityDescription(string Text)
        {
            CommunityDescription.SendKeys(Text);
        }
        [FindsBy(How = How.Id, Using = " multi-select")]
        private SelectElement SelectType { get; set; }
        public void SelectByText(string Text)
        {
            SelectType.SelectByText(Text);

        }
        [FindsBy(How = How.Id, Using = "autocomplete")]
        private IWebElement Autocomplete { get; set; }
        public void EnterLocationAddresssAutocomplete(string LocationAddress)
        {
            Autocomplete.SendKeys(LocationAddress);
        }
        [FindsBy(How = How.Id, Using = "switch")]
        private IWebElement CheckBox { get; set; }
        public void ClickOnPrivate()
        {
            CheckBox.Click();
        }
        [FindsBy(How = How.Id, Using = "files")]
        private IWebElement Communityimage { get; set; }
        public void ChooseFile()
        {
            Communityimage.GetType();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div/div/div/div/div[2]/div/div/form/div[8]/div/input")]
        private IWebElement Createcommunity { get; set; }
        public void ClickOnCreateCommunity()
        {
            Createcommunity.Click();
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='discover']/div[1]/div[1]/h2")]
        private IWebElement Allcommunitycreated { get; set; }
        public string GetTextAllCommunityCreated()
        {
            return Allcommunitycreated.Text;
        }

    }
}
