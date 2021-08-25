
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class JavascriptAlertBoxPage
    {
        public JavascriptAlertBoxPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath,Using = "//a[text()='Alerts & Modals']")]
        public IWebElement AlertsAndModalsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(5) > ul > li:nth-child(5) > a")]
        public IWebElement JavaScriptAlertsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > button")]
        public IWebElement ClickMe2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#confirm-demo")]
        public IWebElement Display1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#easycont > div > div.col-md-6.text-left > div:nth-child(6) > div.panel-body > button")]
        public IWebElement ClickForPromptBoxButton { get; set; }

        [FindsBy(How = How.Id, Using = "prompt-demo")]
        public IWebElement PromptDemoDisplay { get; set; }
    }
}
