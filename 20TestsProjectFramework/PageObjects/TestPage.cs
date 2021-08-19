using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class TestPage
    {
        public TestPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(1) > a")]
        public IWebElement DropdownInputForms { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(1) > ul > li:nth-child(1) > a")]
        public IWebElement SimpleFormLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(1) > ul > li:nth-child(2) > a")]
        public IWebElement CheckboxLink { get; set; }
    }
}