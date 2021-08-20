using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework.PageObjects
{
    class BasicDropdown
    {
        public BasicDropdown(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(1) > ul > li:nth-child(4) > a")]
        public IWebElement selectDropdownListLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='select-demo']")]
        public IWebElement tablePaginationLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "selected-value")]
        public IWebElement dropdownDisplay { get; set; }
    }
}

