using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework.FeatureFiles
{
    [Binding]
    public class NavigateToSimpleFormEnterSomeTextSteps
    {
        public IWebDriver Driver { get; set; }
        private HomePage hpaPage;
        private TestPage tpPage;
       // private BasicFirstFormDemo bf;


       [BeforeScenario]
       public void BeforeScenario()
       {
           Driver=Actions.InitializeDriver();
        }

       [Given(@"user is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
           
            Driver.Navigate().GoToUrl(Config.baseUrl);
        }
        
        [When(@"I click on Demo Website button and dismiss annoying banner")]
        public void WhenIClickOnDemoWebsiteButtonAndDismissAnnoyingBanner()
        {
           
            Navigate.NavigateToTestsDropdownAndDismissBanner(Driver);
            Navigate.NavigateToSimpleFormDemo(Driver);
        }
        
        [Then(@"input field should be visible")]
        public void ThenInputFieldShouldBeVisible()
        {
            var bf = new BasicFirstFormDemo(Driver);
            Assert.IsTrue(bf.inputField.Displayed);
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }

    }
}




