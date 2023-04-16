using AbelAndCole.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AbelAndCole.StepDefinitions
{
    [Binding]
    public class AbleAndColeStepDefinitions
    {

        AbelAndColePage abelAndColePage;

        public AbleAndColeStepDefinitions ()
        {
            abelAndColePage = new AbelAndColePage ();
        }

        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            abelAndColePage.NavigateToWebsite(url);
        }

        [Given(@"I Click Accept cookies")]
        public void GivenIClickAcceptCookies()
        {
            abelAndColePage.ClickOnAcceptButton();
        }

        [Given(@"I Click on search space")]
        public void GivenIClickOnSearchSpace()
        {
           abelAndColePage.ClickOnSearchSpace();
        }

        [Given(@"I Input product ""([^""]*)""")]
        public void GivenIInputProduct(string item1)
        {
            abelAndColePage.InputProduct1(item1);
        }

        [Given(@"I Click on search button")]
        public void GivenIClickOnSearchButton()
        {
            abelAndColePage.ClickOnSearchButton();
        }

        [Given(@"I click on add button")]
        public void GivenIClickOnAddButton()
        {
            abelAndColePage.ClickOnAddButton();
        }

        [Given(@"I input product in the search space ""([^""]*)""")]
        public void GivenIInputProductInTheSearchSpace(string item2)
        {
            abelAndColePage.InputProduct2(item2);
        }
        [Given(@"I click  search button")]
        public void GivenIClickSearchButton()
        {
            abelAndColePage.ClickOnSearchButton();
        }

        [Given(@"I click on Addhumus button")]
        public void GivenIClickOnAddhumusButton()
        {
            abelAndColePage.AddHumusButton();
        }

        [Given(@"I click on plus button")]
        public void GivenIClickOnPlusButton()
        {
            abelAndColePage.ClickPlusButton();
        }

        [Given(@"I click on plushummus button")]
        public void GivenIClickOnPlushummusButton()
        {
            abelAndColePage.ClickPlusHumusButton();
        }

        [Given(@"I input product in the search  ""([^""]*)""")]
        public void GivenIInputProductInTheSearch(string item3)
        {
           abelAndColePage.InputProduct3(item3);
        }

        [Given(@"I Click  search key")]
        public void GivenIClickSearchKey()
        {
            abelAndColePage.ClickOnSearchButton();
        }

        [Given(@"I click on Addpopcorn button")]
        public void GivenIClickOnAddpopcornButton()
        {
            abelAndColePage.AddPopcornButton();
        }

        [Given(@"I click on pluspopcorn button")]
        public void GivenIClickOnPluspopcornButton()
        {
            abelAndColePage.ClickPluspopcornButton();
        }

        [When(@"I Click on basket button")]
        public void WhenIClickOnBasketButton()
        {
            abelAndColePage.ClickBasketButton();
        }

        [Then(@"the basket should display six items")]
        public void ThenTheBasketShouldDisplaySixItems()
        {
            Thread.Sleep(5000);
           Assert.That(abelAndColePage.IsItemInTheBasketDisplayed);
        }












    }
}
