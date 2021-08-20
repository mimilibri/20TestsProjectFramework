﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public IWebElement tableLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#treemenu > li > ul > li:nth-child(3) > ul > li:nth-child(1) > a")]
        public IWebElement tablePaginationLink { get; set; }
    }
}
