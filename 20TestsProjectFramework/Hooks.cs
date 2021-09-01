using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;

namespace _20TestsProjectFramework
{
    [Binding]
    public sealed class Hooks
    {
        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _test;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(@"C:\TestReports\TestResults.html");
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _extentReports.Flush();
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (featureContext != null)
            {
                _featureContext = featureContext;
                _test = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title,
                    featureContext.FeatureInfo.Description);
            }
        }

        [BeforeScenario()]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            if (scenarioContext != null)
            {
                _scenarioContext = scenarioContext;
                _test.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title,
                    scenarioContext.ScenarioInfo.Description);
            }
        }

        [AfterStep]
        public static void AfterStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    _test.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    break;
                case ScenarioBlock.When:
                    _test.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                    break;
                case ScenarioBlock.Then:
                    _test.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                    break;
                default:
                    break;
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
            ObjectRepository.Driver.Quit();
        }
    }
}