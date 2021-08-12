using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework
{
    class TestPage
    {
        public TestPage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.CssSelector,Using = "#treemenu > li > ul > li:nth-child(1) > a")]
        public IWebElement DropdownInputForms { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(1) > ul > li:nth-child(1) > a")]
        public IWebElement SimpleFormLink { get; set; }

    }
}
