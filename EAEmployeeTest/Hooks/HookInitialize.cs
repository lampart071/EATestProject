using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using TechTalk.SpecFlow;

namespace EAEmployeeTest
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static KlovReporter klov;

        [BeforeTestRun]
        public static void TestInitialize()
        {
            InitializeSettings();
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);

            // Initialize report
            var htmlReporter = new ExtentHtmlReporter(@"C:\DEVLOGS\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            // Attach report to reporter
            extent = new ExtentReports();

            // Need to install MongoDB 3.2 first, set and run. 
            // In case db issue try set ' mongod --storageEngine=mmapv1 --dbpath "C:\DEVLOGS" '
            klov = new KlovReporter();
            klov.InitMongoDbConnection("localhost", 27017);
            // Need to run klov ' java -jar klov-... ', settings for klov in application.properties
            klov.KlovUrl = "http://localhost:5689";
            klov.ProjectName = "EA Test";
            klov.ReportName = "Test Run" + DateTime.Now.ToString();
            extent.AttachReporter(htmlReporter, klov);
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            // Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void Initialize()
        {
            // Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public void AfterEachStep()
        {
            var stepName = ScenarioContext.Current.StepContext.StepInfo.Text;
            var featureName = FeatureContext.Current.FeatureInfo.Title;
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text)
                        .Fail(ScenarioContext.Current.TestError.Message);
            }

        }

        [AfterScenario]
        public static void TestStop()
        {
            DriverContext.Driver.Quit();
            extent.Flush();
        }

    }
}