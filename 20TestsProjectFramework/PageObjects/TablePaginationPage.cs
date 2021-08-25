using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class TablePaginationPage
    {
        public TablePaginationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }


        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(3) > a")]
        public IWebElement TableLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(3) > ul > li:nth-child(1) > a")]
        public IWebElement TablePaginationLink { get; set; }
    }
}
