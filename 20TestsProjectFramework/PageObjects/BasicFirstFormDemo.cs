using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class BasicFirstFormDemo
    {
        public BasicFirstFormDemo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-message")]
        public IWebElement InputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Show Message']")]
        public IWebElement ShowButton { get; set; }

        [FindsBy(How = How.Id, Using = "display")]
        public IWebElement Display { get; set; }

        [FindsBy(How = How.Id, Using = "sum1")]
        public IWebElement InputField1 { get; set; }

        [FindsBy(How = How.Id, Using = "sum2")]
        public IWebElement InputField2 { get; set; }

        [FindsBy(How = How.Id, Using = "displayvalue")]
        public IWebElement Value { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#gettotal > button")]
        public IWebElement GetTotal { get; set; }
    }
}