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
    class Wishlistpage
    {
        public Wishlistpage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='breadcrumb-area bg--white-6 breadcrumb-bg-1 pt--60 pb--70 pt-lg--40 pb-lg--50 pt-md--30 pb-md--40'] ")]
        private IWebElement MyAccount { get; set; }
        public string MyAccountIsDisplayed()
        {
            return MyAccount.Text;
        }
        
        [FindsBy(How = How.XPath, Using = "//a[@class='nav-link'][contains(text(),'Wishlist')]")]
        private IWebElement Wishlistelement { get; set; }
        public void ClickOnWishlistElement()
        {
            Wishlistelement.Click();
        }
        [FindsBy(How = How.XPath, Using = "//a[@class='add-new plr--15 mr--10 mr-sm--1-']")]
        private IWebElement Createwishlist { get; set; }
        public void ClickOnCreateWishlist()
        {
            Createwishlist.Click();
        }
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Myself')]")]
        private IWebElement Radiobutton { get; set; }
        public void ClickOnRadioButton()
        {
            Radiobutton.Click();
        }
        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement Entername { get; set; }
        public void EnterName(string Name)
        {
            Entername.SendKeys(Name);
        }
        [FindsBy(How = How.Id, Using = "event")]
        private IWebElement Occasionevent { get; set; }
        public void EnterOccasionEvent(string OccasionName)
        {
            Occasionevent.SendKeys(OccasionName);
        }

        [FindsBy(How = How.Id, Using = "eventdate")]
        private IWebElement SelectCalendar { get; set; }
        public void SelectDate(string Date)
        {
            SelectCalendar.GetProperty(Date);
        }

        [FindsBy(How = How.Id, Using = "description")]
        private IWebElement WishlistDescrp { get; set; }
        public void EnterWishlistDescription(string Description)
        {
            WishlistDescrp.SendKeys(Description);
        }

        [FindsBy(How = How.Id, Using = "product_category")]
        private SelectElement SelectCategory { get; set; }
        public void SelectByValue(string Value)
        {
            SelectCategory.SelectByValue(Value);
        }

        [FindsBy(How = How.Id, Using = "files")]
        private IWebElement Wishlistimage { get; set; }
        public void ChooseImage()
        {
            Wishlistimage.GetType();
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='add-p']")]
        private IWebElement SaveWishlist { get; set; }
        public void ClickOnSaveWishList()
        {
            SaveWishlist.Click();
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Wishlist Created Successfully. No Image Uploaded')] ")]
        private IWebElement MesgDisplayed { get; set; }
        public string GetTextMsgDisplayed(string Message)
        {
            return MesgDisplayed.Text;
        }


    }
}
