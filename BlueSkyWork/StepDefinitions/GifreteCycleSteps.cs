using BlueSkyWork.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyWork.StepDefinitions
{
    [Binding]
    public class GifreteCycleSteps
    {
        GifreteCyclePage GifreteCycle;
        public GifreteCycleSteps()
        {
            GifreteCycle = new GifreteCyclePage();
        }
        [When(@"I click on Giftrete")]
        public void WhenIClickOnGiftrete()
        {
            GifreteCycle.ClickOnGifrete();
        }
        
        [Then(@"the posts should be displayed")]
        public void ThenThePostsShouldBeDisplayed()
        {
            Assert.IsTrue(GifreteCycle.IsMessageIsDisplayed());
        }
    }
}
