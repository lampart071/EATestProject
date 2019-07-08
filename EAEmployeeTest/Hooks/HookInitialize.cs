using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using TechTalk.SpecFlow;

namespace EAEmployeeTest
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        [BeforeTestRun]
        public static void TestInitialize()

        {
            InitializeSettings();
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }

        [AfterScenario]
        public static void TestStop()
        {
            DriverContext.Driver.Quit();
        }


    }
}