

using System.Threading;
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
                // var home = new HomePage();
                // var testPage = new TestPage();
                Driver.driver.Navigate().GoToUrl(Config.baseUrl);
                Navigate.NavigateToTestsDropdownAndDismissBanner();
                Navigate.NavigateToSimpleFormDemo();

            }

            [Test]


            public void InputFieldWorksTest()
            {   //arrange
                string expected = "random";

                Thread.Sleep(5000);

                var inputField = Driver.driver.FindElement(By.Id("user-message"));
                var showButton = Driver.driver.FindElement(By.CssSelector("#get-input > button"));

                var display = Driver.driver.FindElement(By.Id("display"));
                //act
                inputField.SendKeys(expected);

                showButton.Click();

                //assert
                Assert.That(expected, Is.EqualTo(display.Text));
                inputField.Clear();




            }

            [Test]
            [TestCase(1, 3)]
            [TestCase(0, 356)]
            [TestCase(-1, 0)]
            [TestCase(-1, -78)]

            public void AdditionFromTwoInputFieldsTest(int a, int b)
            {
                int expected = a + b;
                var inputField1 = Driver.driver.FindElement(By.Id("sum1"));
                var inputField2 = Driver.driver.FindElement(By.Id("sum2"));
                var value = Driver.driver.FindElement(By.Id("displayvalue"));
                var getTotal = Driver.driver.FindElement(By.CssSelector("#gettotal > button"));

                inputField1.SendKeys(a.ToString());
                inputField2.SendKeys(b.ToString());

                //Thread.Sleep(10000);

                getTotal.Click();

                Assert.That(expected.ToString(), Is.EqualTo(value.Text));

                inputField1.Clear();
                inputField2.Clear();





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
            [Test]

            public void CheckboxTest()
            {
                
                Actions.InitializeDriver();
                Driver.driver.Navigate().GoToUrl(Config.baseUrl);
                Navigate.NavigateToTestsDropdownAndDismissBanner();
                Navigate.NavigateToCheckbox();



                var checkbox = Driver.driver.FindElement(By.Id("isAgeSelected"));
                var message = Driver.driver.FindElement(By.Id("txtAge"));

                checkbox.Click();

                Thread.Sleep(3000);



                Assert.IsTrue(message.Displayed);

                Driver.driver.Quit();


            }
        }



    }
}
