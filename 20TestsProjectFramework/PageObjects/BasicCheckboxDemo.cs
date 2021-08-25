using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class BasicCheckboxDemo
    {
        public BasicCheckboxDemo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "isAgeSelected")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.Id, Using = "txtAge")]
        public IWebElement Message { get; set; }
    }
}