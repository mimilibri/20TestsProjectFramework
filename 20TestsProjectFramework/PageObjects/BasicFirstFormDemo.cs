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
        public IWebElement inputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Show Message']")]
        public IWebElement showButton { get; set; }

        [FindsBy(How = How.Id, Using = "display")]
        public IWebElement display { get; set; }

        [FindsBy(How = How.Id, Using = "sum1")]
        public IWebElement inputField1 { get; set; }

        [FindsBy(How = How.Id, Using = "sum2")]
        public IWebElement inputField2 { get; set; }

        [FindsBy(How = How.Id, Using = "displayvalue")]
        public IWebElement value { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#gettotal > button")]
        public IWebElement getTotal { get; set; }
    }
}