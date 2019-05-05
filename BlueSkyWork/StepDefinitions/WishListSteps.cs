using BlueSkyWork.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork.StepDefinitions
{
    [Binding]
    public class WishlistSteps
    {
        Wishlistpage Wishlist;
        public WishlistSteps()
        {
            Wishlist = new Wishlistpage();
        }

        [Given(@"my account is displayed")]
        public void GivenMyAccountIsDisplayed()
        {
           Wishlist.MyAccountIsDisplayed();
        }

        [Given(@"I click on wishlist Link")]
        public void GivenIClickOnWishlistLink()
        {
            Wishlist.ClickOnWishlistElement();
        }

        [Given(@"I click on create")]
        public void GivenIClickOnCreate()
        {
            Wishlist.ClickOnCreateWishlist();
        }

        [When(@"I select radio text")]
        public void WhenISelectRadioText()
        {
            Wishlist.ClickOnRadioButton();
        }

        [When(@"I enter occasion")]
        public void WhenIEnterOccasion()
        {
            Wishlist.EnterOccasionEvent("Wedding");
        }

        [When(@"I select even date")]
        public void WhenISelectEvenDate()
        {
            Wishlist.SelectDate("2019-06-22");
        }

        [When(@"I enter wishlist description")]
        public void WhenIEnterWishlistDescription()
        {
            Wishlist.EnterWishlistDescription("Yes,Yes,Yes");
        }

        [When(@"I select category")]
        public void WhenISelectCategory()
        {
            Wishlist.SelectByValue("103");
        }

        [When(@"I choose wishlist image")]
        public void WhenIChooseWishlistImage()
        {
            Wishlist.ChooseImage();
        }

        [When(@"I click on save wishlist")]
        public void WhenIClickOnSaveWishlist()
        {
            Wishlist.ClickOnSaveWishList();
        }

        [Then(@"the wishlist is created")]
        public void ThenTheWishlistIsCreated()
        {
            Assert.IsNotNull(Wishlist.GetTextMsgDisplayed("Wishlist Created Successfully. No Image Uploaded"));
        }
    }
}
