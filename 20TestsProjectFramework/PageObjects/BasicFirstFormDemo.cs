using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _20TestsProjectFramework
{
    class BasicFirstFormDemo
    {
        public BasicFirstFormDemo()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.Id,Using= "user-message")]
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
