using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20TestsProjectFramework.PageObjects;
using OpenQA.Selenium;

namespace _20TestsProjectFramework
{
    class ObjectRepository
    {
        public static IWebDriver Driver { get; set; }

        public static BasicCheckboxDemo chb;
        public static TestPage TestPage;
        public static BasicFirstFormDemo firstform;
        public static HomePage HomePage;
        public static BasicRadiobuttonDemo rbp;

    }
}
