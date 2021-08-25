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
            ObjectRepository.HomePage = new HomePage(driver);
            ObjectRepository.HomePage.DemoSiteButton.Click();

            //      wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("image-darkener")));


            wait.Until(CustomExpectedConditions
                .ElementIsVisible(By.Id("at-cv-lightbox"))); // element is visible implemented using Func

            var noThanks =
                driver.FindElement(By.CssSelector(
                    "#at-cv-lightbox-button-holder > a.at-cv-button.at-cv-lightbox-yesno.at-cm-no-button"));

            noThanks.Click();
        }

        public static void NavigateToSimpleFormDemo(IWebDriver driver)
        {
            ObjectRepository.TestPage = new TestPage(driver);


            ObjectRepository.TestPage.DropdownInputForms.Click();
            ObjectRepository.TestPage.SimpleFormLink.Click();
        }

        public static void NavigateToInputForms(IWebDriver driver)
        {
            ObjectRepository.TestPage = new TestPage(driver);


            ObjectRepository.TestPage.DropdownInputForms.Click();
        }

        public static void NavigateToCheckbox(IWebDriver driver)
        {
            ObjectRepository.TestPage = new TestPage(driver);
            ObjectRepository.TestPage.DropdownInputForms.Click();
            ObjectRepository.TestPage.CheckboxLink.Click();
        }

        public static void NavigateToRadiobuttons(IWebDriver driver)
        {
            ObjectRepository.TestPage = new TestPage(driver);
            ObjectRepository.TestPage.DropdownInputForms.Click();
            ObjectRepository.TestPage.RadioButtonDemoLink.Click();
        }

        public static void NavigateToPaginationTable(IWebDriver driver)
        {
            NavigateToTestsDropdownAndDismissBanner(driver);
            ObjectRepository.tpp.TableLink.Click();
            ObjectRepository.tpp.TablePaginationLink.Click();
        }

        public static void NavigateToDropdown(IWebDriver driver)
        {
            NavigateToTestsDropdownAndDismissBanner(driver);
            NavigateToInputForms(driver);
            ObjectRepository.bd = new BasicDropdown(driver);
            ObjectRepository.bd.SelectDropdownListLink.Click();
        }

        public static void NavigateToJSAlerts(IWebDriver driver)
        {
            NavigateToTestsDropdownAndDismissBanner(driver);
            ObjectRepository.jsa = new JavascriptAlertBoxPage(driver);
            ObjectRepository.jsa.AlertsAndModalsLink.Click();
            ObjectRepository.jsa.JavaScriptAlertsLink.Click();
        }
    }
}