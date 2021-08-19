using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class BasicRadiobuttonDemo
    {
        public BasicRadiobuttonDemo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector,
            Using = "#easycont > div > div.col-md-6.text-left > div:nth-child(4) > div.panel-body > label:nth-child(2) > input[type=radio]")]
        public IWebElement RadioButton1M { get; set; }

        [FindsBy(How = How.CssSelector,
            Using = "#easycont > div > div.col-md-6.text-left > div:nth-child(4) > div.panel-body > label:nth-child(3) > input[type=radio]")]
        public IWebElement RadioButton1F { get; set; }

        [FindsBy(How = How.Id, Using = "buttoncheck")]
        public IWebElement CheckButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#easycont > div > div.col-md-6.text-left > div:nth-child(4) > div.panel-body > p.radiobutton")]
        public IWebElement CheckValueDisplay { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Male' and @name='gender']")]
        public IWebElement RadioButton2M { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Female' and @name='gender']")]
        public IWebElement RadioButton2F { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='0 - 5']")]
        public IWebElement RadioButton0to5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='5 - 15']")]
        public IWebElement RadioButton5to15 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='15 - 50']")]
        public IWebElement RadioButton15to50 { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Get values']")]
        public IWebElement GetValuesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".groupradiobutton")]
        public IWebElement SexAgeDisplay { get; set; }

    }
}