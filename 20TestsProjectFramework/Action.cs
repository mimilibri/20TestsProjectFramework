using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace _20TestsProjectFramework
{
    static class Action
    {
        public static IWebDriver InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }
    }
}