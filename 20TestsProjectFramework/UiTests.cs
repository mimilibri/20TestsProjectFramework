using System.Linq;
using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

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
                Driver = Actions.InitializeDriver();
                
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
                Driver = Actions.InitializeDriver();

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
        }
    }
}