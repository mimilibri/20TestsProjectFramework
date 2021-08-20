using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework.FeatureFiles
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        //public IWebDriver Driver1 { get; set; }

        //private BasicRadiobuttonDemo rbp;

        #region Given

        [Given(@"i was on home page")]
        public void GivenIWasOnHomePage()
        {
            ObjectRepository.Driver = Actions.InitializeDriver();
        }

        #endregion

        #region When

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

        [When(@"i click on second male labeled radiobutton")]
        public void WhenIClickOnSecondMaleLabeledRadiobutton()
        {
            ObjectRepository.rbp.RadioButton2M.Click();
        }

        [When(@"i click on the age radiobutton")]
        public void WhenIClickOnTheAgeRadiobutton()
        {
            ObjectRepository.rbp.RadioButton0to5.Click();
        }

        [When(@"i click get values button")]
        public void WhenIClickGetValuesButton()
        {
            ObjectRepository.rbp.GetValuesButton.Click();
        }

        #endregion


        #region Then

        [Then(@"radiobutton labeled male should be visible")]
        public void ThenRadiobuttonLabeledMaleShouldBeVisible()
        {
            ObjectRepository.rbp = new BasicRadiobuttonDemo(ObjectRepository.Driver);
            Assert.IsTrue(ObjectRepository.rbp.RadioButton1M.Displayed);
        }


        [Then(@"message contaning string Male should be viisible")]
        public void ThenMessageContaningStringMaleShouldBeViisible()
        {
            Assert.IsTrue(ObjectRepository.rbp.CheckValueDisplay.Text.Contains("Male"));
        }


        [Then(@"right display message should be displayed")]
        public void ThenRightDisplayMessageShouldBeDisplayed()
        {
            StringAssert.Contains("Male", ObjectRepository.rbp.SexAgeDisplay.Text);
            StringAssert.Contains("0 - 5", ObjectRepository.rbp.SexAgeDisplay.Text);
        }

        [Then(@"Check if message does not contain words above")]
        public void ThenCheckIfMessageDoesNotContainWordsAbove()
        {
            StringAssert.DoesNotContain("Male", ObjectRepository.rbp.SexAgeDisplay.Text);
            StringAssert.DoesNotContain("Female", ObjectRepository.rbp.SexAgeDisplay.Text);
            StringAssert.DoesNotContain("0 - 5", ObjectRepository.rbp.SexAgeDisplay.Text);
            StringAssert.DoesNotContain("5 - 15", ObjectRepository.rbp.SexAgeDisplay.Text);
            StringAssert.DoesNotContain("15 - 50", ObjectRepository.rbp.SexAgeDisplay.Text);
        }

        #endregion


        [AfterScenario]
        public void AfterScenario()
        {
            ObjectRepository.Driver.Quit();
        }
    }
}