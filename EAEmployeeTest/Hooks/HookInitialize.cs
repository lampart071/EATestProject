using System;
using System.ComponentModel.Design;
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
            Console.WriteLine("BeforeTestRun");
            //InitializeSettings();
            //Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }

        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

        [AfterScenario]
        public static void TestStop()
        {
            DriverContext.Driver.Quit();
        }


    }
}
