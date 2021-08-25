using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework.FeatureFiles
{
    [Binding]
    public class JavaScriptAlertTestsSteps
    {
        [When(@"user clicks on the second button on the screen")]
        public void WhenUserClicksOnTheSecondButtonOnTheScreen()
        {
            ObjectRepository.jsa.ClickMe2.Click();
        }

        [When(@"click ok on the alert")]
        public void WhenClickOkOnTheAlert()
        {
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }

        [When(@"click cancel on the alert")]
        public void WhenClickCancelOnTheAlert()
        {
            ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
        }

        [When(@"user clicks on the bottom last button on the screen")]
        public void WhenUserClicksOnTheBottomLastButtonOnTheScreen()
        {
            ObjectRepository.jsa.ClickForPromptBoxButton.Click();
        }

        [When(@"enter his name in the prompt box")]
        public void WhenEnterHisNameInThePromptBox()
        {
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys("Milovan");
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }

        [Then(@"message contaning ok should be visible")]
        public  void ThenMessageContaningOkShouldBeVisible()
        {
            Assert.IsTrue(ObjectRepository.jsa.Display1.Displayed);
            Assert.IsTrue(ObjectRepository.jsa.Display1.Text.Contains("OK"));
        }

        [Then(@"message contaning cancel should be visible")]
        public void ThenMessageContaningCancelShouldBeVisible()
        {
            Assert.IsTrue(ObjectRepository.jsa.Display1.Displayed);
            Assert.IsTrue(ObjectRepository.jsa.Display1.Text.Contains("Cancel"));
        }

        [Then(@"message contaning Milovan should be visible")]
        public void ThenMessageContaningHisNameShouldBeVisible()
        {
            Assert.IsTrue(ObjectRepository.jsa.PromptDemoDisplay.Displayed);
            Assert.IsTrue(ObjectRepository.jsa.PromptDemoDisplay.Text.Contains("Milovan"));
        }

        [Given(@"user navigates to Javascript alert boxes page")]
        public void GivenUserNavigatesToJavascriptAlertBoxesPage()
        {
            ObjectRepository.Driver = Action.InitializeDriver();

            Navigate.NavigateToJSAlerts(ObjectRepository.Driver);
        }
    }
}