using System.Linq;
using System.Threading;
using _20TestsProjectFramework.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace _20TestsProjectFramework
{
    class UiTests
    {
        [TestFixture]
        class InputFieldsTests
        {
            [OneTimeSetUp]
            public void SetUp()
            {
                Actions.InitializeDriver();

                Driver.driver.Navigate().GoToUrl(Config.baseUrl);
                Navigate.NavigateToTestsDropdownAndDismissBanner();
                Navigate.NavigateToSimpleFormDemo();
            }

            [Test]
            public void InputFieldWorksTest()
            {
                string expected = "random";
                var firstForm = new BasicFirstFormDemo();

                firstForm.inputField.SendKeys(expected);
                firstForm.showButton.Click();

                Assert.That(expected, Is.EqualTo(firstForm.display.Text));
            }

            [Test]
            [TestCase(1, 3)]
            [TestCase(0, 356)]
            [TestCase(-1, 0)]
            [TestCase(-1, -78)]
            public void AdditionFromTwoInputFieldsTest(int a, int b)
            {
                var firstform = new BasicFirstFormDemo();
                int expected = a + b;


                firstform.inputField1.SendKeys(a.ToString());
                firstform.inputField2.SendKeys(b.ToString());


                firstform.getTotal.Click();

                Assert.That(expected.ToString(), Is.EqualTo(firstform.value.Text));

                firstform.inputField1.Clear();
                firstform.inputField2.Clear();
            }

            [OneTimeTearDown]
            public void TearDown()
            {
                Driver.driver.Quit();
            }
        }

        [TestFixture]
        class CheckBoxesTests
        {
            [OneTimeSetUp]
            public void SetUp()
            {
                Actions.InitializeDriver();
                Driver.driver.Navigate().GoToUrl(Config.baseUrl);
                Navigate.NavigateToTestsDropdownAndDismissBanner();
                Navigate.NavigateToCheckbox();
            }

            [Test]
            public void CheckboxTest()
            {
                var chb = new BasicCheckboxDemo();

                chb.checkbox.Click();

                Assert.IsTrue(chb.message.Displayed);
            }

            [Test]
            public void MultipleCheckboxTest()
            {
                var checkboxes = Driver.driver.FindElements(By.XPath("//input[@type='checkbox']"));

                foreach (var box in checkboxes.Skip(1))
                {
                    box.Click();
                }


                Thread.Sleep(5000);

                Assert.IsTrue(checkboxes[2].Selected);
            }

            [OneTimeTearDown]
            public void TearDown()
            {
                Driver.driver.Quit();
            }
        }
    }
}