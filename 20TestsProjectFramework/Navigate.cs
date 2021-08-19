

using System;
using _20TestsProjectFramework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace _20TestsProjectFramework
{
    public static class Navigate
    {
        public static void NavigateToTestsDropdownAndDismissBanner(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var home = new HomePage(driver);
            // var testpage = new TestPage();


            home.DemoSiteButton.Click();

            // var element =
            //      wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("image-darkener")));


            var element =
                wait.Until(CustomExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox"))); // element is visible implemented using Func

            var noThanks = driver.FindElement(By.CssSelector("#at-cv-lightbox-button-holder > a.at-cv-button.at-cv-lightbox-yesno.at-cm-no-button"));


            noThanks.Click();

//            
        }

        public static void NavigateToSimpleFormDemo(IWebDriver driver)
        {
            var testpage = new TestPage(driver);


            testpage.DropdownInputForms.Click();
            testpage.SimpleFormLink.Click();
        }

        public static void NavigateToCheckbox(IWebDriver driver)
        {
            var testpage = new TestPage(driver);
            testpage.DropdownInputForms.Click();
            testpage.CheckboxLink.Click();
        }
    }
}
