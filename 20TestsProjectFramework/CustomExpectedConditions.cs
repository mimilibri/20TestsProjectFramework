using System;
using System.Collections.Generic;
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

        public static Func<IWebDriver, IList<IWebElement>> GetAllElements(By locator)
        {
            return ((driver) =>
            {
                return driver.FindElements(locator);
            });
        }
    }
}