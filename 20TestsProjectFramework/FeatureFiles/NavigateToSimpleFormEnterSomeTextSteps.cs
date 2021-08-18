using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework.FeatureFiles
{
    [Binding]
    public class NavigateToSimpleFormEnterSomeTextSteps
    {
        private HomePage hpaPage;
        private TestPage tpPage;
       // private BasicFirstFormDemo bf;


       [BeforeScenario]
       public void BeforeScenario()
       {
           Actions.InitializeDriver();
        }

       [Given(@"user is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
           
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
        }
        
        [When(@"I click on Demo Website button and dismiss annoying banner")]
        public void WhenIClickOnDemoWebsiteButtonAndDismissAnnoyingBanner()
        {
           
            Navigate.NavigateToTestsDropdownAndDismissBanner();
            Navigate.NavigateToSimpleFormDemo();
        }
        
        [Then(@"input field should be visible")]
        public void ThenInputFieldShouldBeVisible()
        {
            var bf = new BasicFirstFormDemo();
            Assert.IsTrue(bf.inputField.Displayed);
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Quit();
        }

    }
}




