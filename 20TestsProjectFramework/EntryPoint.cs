using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace _20TestsProjectFramework
{
    class EntryPoint
    {
        static void Main()
        {
           
        }

        [SetUp]
        public void SetUp()
        {
            var home = new HomePage();
            var testPage = new TestPage();
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
            Navigate.NavigateToTestsDropdownAndDismissBanner();
        }

        [Test]


        public void InputFieldWorks()
        {   //arrange
            string expected = "random";
            
            Navigate.NavigateToSimpleFormDemo();

            var inputField = Driver.driver.FindElement(By.ClassName("form-control"));
            var showButton = Driver.driver.FindElement(By.CssSelector("#get-input > button"));

            var display = Driver.driver.FindElement(By.Id("display"));
            //act
            inputField.SendKeys(expected);
            showButton.Click();
            //assert
            Assert.That(expected, Is.EqualTo(display.Text));




        }

        [TearDown]

        public void TearDown()
        {
            Driver.driver.Quit();
        }
    }
}
