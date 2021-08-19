using System;
using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework.FeatureFiles
{
    [Binding]
    
    public class SpecFlowFeature1Steps
    {
        //public IWebDriver Driver1 { get; set; }

        //private BasicRadiobuttonDemo rbp;

        
            
        

        [Given(@"i was on home page")]
        public void GivenIWasOnHomePage()
        {
            ObjectRepository.Driver = Actions.InitializeDriver();
            
        }
        
        [When(@"i navigate to testpage and dismiss banner")]
        public void WhenINavigateToTestpageAndDismissBanner()
        {
            Navigate.NavigateToTestsDropdownAndDismissBanner(ObjectRepository.Driver);
        }
        
        [When(@"i click the link to radiobuttons page")]
        public void WhenIClickTheLinkToRadiobuttonsPage()
        {
            Navigate.NavigateToRadiobuttons(ObjectRepository.Driver);
            
        }
        
        [Then(@"radiobutton labeled male should be visible")]
        public void ThenRadiobuttonLabeledMaleShouldBeVisible()
        {
            ObjectRepository.rbp = new BasicRadiobuttonDemo(ObjectRepository.Driver);
            Assert.IsTrue(ObjectRepository.rbp.RadioButton1M.Displayed);
            
        }

        [When(@"I click on Male labeled radiobutton")]
        public void WhenIClickOnMaleLabeledRadiobutton()
        {
            ObjectRepository.rbp.RadioButton1M.Click();
        }

        [When(@"i click on GetCheckedValue button")]
        public void WhenIClickOnGetCheckedValueButton()
        {
            ObjectRepository.rbp.CheckButton.Click();
        }

        [Then(@"message contaning string Male should be viisible")]
        public void ThenMessageContaningStringMaleShouldBeViisible()
        {
            Assert.IsTrue(ObjectRepository.rbp.CheckValueDisplay.Text.Contains("Male"));
        }

        [AfterScenario]
        
        public void AfterScenario()
        {
            ObjectRepository.Driver.Quit();
            
            
        }



    }
}
