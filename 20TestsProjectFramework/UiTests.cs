using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using _20TestsProjectFramework.ComponentHelper;
using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace _20TestsProjectFramework
{
    class UiTests
    {
        [TestFixture]
        [Parallelizable(ParallelScope.Fixtures)]
        class InputFieldsTests
        {
            public IWebDriver Driver { get; set; }

            [OneTimeSetUp]
            public void SetUp()
            {
                Driver = Action.InitializeDriver();

                Navigate.NavigateToTestsDropdownAndDismissBanner(Driver);
                Navigate.NavigateToSimpleFormDemo(Driver);
            }

            [Test]
            public void InputFieldWorksTest()
            {
                string expected = "random";
                ObjectRepository.firstform = new BasicFirstFormDemo(Driver);

                ObjectRepository.firstform.inputField.SendKeys(expected);
                ObjectRepository.firstform.showButton.Click();

                Assert.That(expected, Is.EqualTo(ObjectRepository.firstform.display.Text));
            }

            [Test]
            [TestCase(1, 3)]
            [TestCase(0, 356)]
            [TestCase(-1, 0)]
            [TestCase(-1, -78)]
            public void AdditionFromTwoInputFieldsTest(int a, int b)
            {
                ObjectRepository.firstform = new BasicFirstFormDemo(Driver);
                int expected = a + b;


                ObjectRepository.firstform.inputField1.SendKeys(a.ToString());
                ObjectRepository.firstform.inputField2.SendKeys(b.ToString());


                ObjectRepository.firstform.getTotal.Click();

                Assert.That(expected.ToString(), Is.EqualTo(ObjectRepository.firstform.value.Text));

                ObjectRepository.firstform.inputField1.Clear();
                ObjectRepository.firstform.inputField2.Clear();
            }

            [OneTimeTearDown]
            public void TearDown()
            {
                Driver.Quit();
            }
        }

        [TestFixture]
        [Parallelizable(ParallelScope.Fixtures)]
        class CheckBoxesTests
        {
            public IWebDriver Driver { get; set; }

            [OneTimeSetUp]
            public void SetUp()
            {
                Driver = Action.InitializeDriver();

                Navigate.NavigateToTestsDropdownAndDismissBanner(Driver);
                Navigate.NavigateToCheckbox(Driver);
            }

            [Test]
            public void CheckboxTest()
            {
                ObjectRepository.chb = new BasicCheckboxDemo(Driver);

                ObjectRepository.chb.checkbox.Click();

                Assert.IsTrue(ObjectRepository.chb.message.Displayed);
            }

            [Test]
            public void MultipleCheckboxTest()
            {
                var checkboxes = Driver.FindElements(By.XPath("//input[@type='checkbox']"));

                foreach (var box in checkboxes.Skip(1))
                {
                    box.Click();
                }

                Assert.IsTrue(checkboxes[2].Selected);
            }

            [OneTimeTearDown]
            public void TearDown()
            {
                Driver.Quit();
            }

            [TestFixture]
            [Parallelizable(ParallelScope.All)]
            class TableTests
            {
                [Test]
                public void CheckColumnValue()
                {
                    ObjectRepository.Driver = Action.InitializeDriver();
                    ObjectRepository.tpp = new TablePaginationPage(ObjectRepository.Driver);

                    Navigate.NavigateToPaginationTable(ObjectRepository.Driver);
                    Assert.That("Table cell", Is.EqualTo(TableHelper.GetColumnValue("//table", 1, 2)));
                    ObjectRepository.Driver.Quit();
                }
            }

            [TestFixture]
            [Parallelizable(ParallelScope.All)]
            class DropdownTests
            {
                public IWebDriver Driver { get; set; }


                [Test]
                public void SelectFromDropdown()
                {
                    Driver = Action.InitializeDriver();
                    Navigate.NavigateToDropdown(Driver);
                    var dropdownSelections = Driver.FindElements(By.XPath("//select[@id='select-demo']/option"));
                    dropdownSelections[3].Click();
                    Assert.IsTrue(ObjectRepository.bd.dropdownDisplay.Text.Contains("Tuesday"));
                    Driver.Quit();
                }
            }

            [TestFixture]
            [Parallelizable(ParallelScope.All)]
            class MultipleWindowsTest
            {
                public IWebDriver Driver { get; set; }

                [Test]
                public void PopUpTest()
                {
                    Driver = new ChromeDriver();
                    Driver.Navigate()
                        .GoToUrl(
                            "https://www.seleniumeasy.com/test/window-popup-modal-demo.html"); //TODO: WindowHelperClass and POM
                    Driver.FindElement(By.XPath("//a[text()='  Like us On Facebook ']")).Click();
                    ReadOnlyCollection<string> windows = Driver.WindowHandles;
                    Driver.SwitchTo().Window(windows[1]);
                    Driver.Manage().Window.Maximize();

                    var expectedeElement = Driver.FindElement(By.XPath("//div[@class='_4on8']/.."));

                    Assert.IsTrue(expectedeElement.Displayed);
                    Driver.Quit();
                }
            }

            [TestFixture]
            [Parallelizable(ParallelScope.All)]

            class MouseActionsTests
            {
                public IWebDriver Driver { get; set; }

                [Test]
                public void DragNDrop()
                {
                    Driver = new FirefoxDriver(); //drag and drop works only on this site in firefox browser
                    Driver.Navigate().GoToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
                    var act = new Actions(Driver);
                    Thread.Sleep(5000);
                    var draggable = Driver.FindElement(By.Id("draggable"));
                    var droppable = Driver.FindElement(By.Id("droptarget")); //TODO:POM


                    act.DragAndDrop(draggable, droppable).Build().Perform();

                    var sucessmessage = Driver.FindElement(By.XPath("//div[text()='You did great!']"));

                    Assert.IsTrue(sucessmessage.Displayed);
                    Driver.Quit();
                }
            }

            [TestFixture]
            [Parallelizable(ParallelScope.All)]

            class AutosuggestTests
            {
                public IWebDriver Driver { get; set; }

                [Test]
                public void Autosuggest()
                {
                    Driver = new ChromeDriver();
                    Driver.Navigate().GoToUrl("https://jqueryui.com/autocomplete/"); 
                    Driver.SwitchTo().Frame(Driver.FindElement(By.ClassName("demo-frame")));
                    Driver.FindElement(By.ClassName("ui-autocomplete-input")).SendKeys("a");
                    Thread.Sleep(1000);

                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

                    IList<IWebElement> elements =
                        wait.Until(CustomExpectedConditions.GetAllElements(By.XPath("//ul/child::li")));

                    Assert.That("Asp", Is.EqualTo(elements[2].Text));


                    Driver.Quit();
                }
            }
        }
    }
}