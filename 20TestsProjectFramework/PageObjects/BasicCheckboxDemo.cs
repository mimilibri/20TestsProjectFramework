using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class BasicCheckboxDemo
    {
        public BasicCheckboxDemo()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "isAgeSelected")]
        public IWebElement checkbox { get; set; }

        [FindsBy(How = How.Id, Using = "txtAge")]
        public IWebElement message { get; set; }
        //[FindsBy(How = How.XPath,Using = "//input[@type='checkbox']")] public IWebElement checkboxes { get; set; }
    }
}