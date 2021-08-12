using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework
{
    public  class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.CssSelector, Using = "#block-block-57 > div > div > a")]
        public IWebElement DemoSiteButton { get; set; }
    }
}
