using BlueSkyWork.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork.StepDefinitions
{
    [Binding]
    public class CommunitySteps
    {
        CommunityPage Community;

        public CommunitySteps()
        {
            Community = new CommunityPage();
        }
        [Given(@"my account is displayed")]
        public void MyAccountIsDisplayed()
        {
           Community.GetTextyMyAccount();
        }

        [When(@"I click on community link")]
        public void WhenIClickOnCommunityLink()
        {
            Community.ClickOnCommunityLink();
        }

        [When(@"I click on create new")]
        public void WhenIClickOnCreateNew()
        {
            Community.ClickOnCreateNewElement();
        }

        [When(@"I enter community name")]
        public void WhenIEnterCommunityName()
        {
            Community.EnterCommunityName("Family");
        }

        [When(@"I enter community description")]
        public void WhenIEnterCommunityDescription()
        {
            Community.EnterCommunityDescription("This family has the sane heard, vision, and work together toward the the same purpose");
        }

        [When(@"I select type")]
        public void WhenISelectType()
        {
            Community.SelectByText("Religious");
        }

        [When(@"I enter my location")]
        public void WhenIEnterMyLocation()
        {
            Community.EnterLocationAddresssAutocomplete("109 Anstridge Road");
        }

        [When(@"I select the privacy status")]
        public void WhenISelectThePrivacyStatus()
        {
            Community.ClickOnPrivate();
        }

        [When(@"I choose the file for community image")]
        public void WhenIChooseTheFileForCommunityImage()
        {
            Community.ChooseFile();
        }

        [When(@"I click on create community")]
        public void WhenIClickOnCreateCommunity()
        {
            Community.ClickOnCreateCommunity();
        }

        [Then(@"I must view my community created")]
        public void ThenIMustViewMyCommunityCreated()
        {
            Assert.IsNotEmpty(Community.GetTextAllCommunityCreated());
        }
    }
}
