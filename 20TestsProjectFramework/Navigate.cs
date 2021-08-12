

using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace _20TestsProjectFramework
{
    public static class Navigate
    {
        public static void NavigateToTestsDropdownAndDismissBanner()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver,TimeSpan.FromSeconds(5));
            var home = new HomePage();
            // var testpage = new TestPage();
            

           
            
            home.DemoSiteButton.Click();

            var element =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox")));

            
            
            
            
            
            // var element = wait.Until(CustomExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox")));  // element is visible implemented using Func
                
            var noThanks = Driver.driver.FindElement(
                By.CssSelector("#at-cv-lightbox-button-holder > a.at-cv-button.at-cv-lightbox-yesno.at-cm-no-button"));


            noThanks.Click();

//             Thread.Sleep(5000)
// ;            
//             
//             testpage.DropdownInputForms.Click();
//             testpage.SimpleFormLink.Click();
        }

        public static void NavigateToSimpleFormDemo()
        {
            var testpage = new TestPage();

            testpage.DropdownInputForms.Click();
            testpage.SimpleFormLink.Click();

        }

        public static void NavigateToCheckbox()
        {
            var testpage = new TestPage();
            testpage.DropdownInputForms.Click();
            testpage.CheckboxLink.Click();
        }
    }
}
