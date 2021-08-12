using System;
using OpenQA.Selenium;

namespace _20TestsProjectFramework
{
     static class CustomExpectedConditions
    {

        public static Func<IWebDriver, IWebElement> ElementIsVisible(By locator)
        {
            return (driver) =>
            {
                IWebElement element = driver.FindElement(locator);
                if (element.Displayed
                    && element.Enabled)
                {
                    return element;
                }

                return null;
            };

        }
        
    }
}