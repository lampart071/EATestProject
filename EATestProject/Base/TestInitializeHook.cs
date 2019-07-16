using System;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace EAAutoFramework.Base
{
    public class TestInitializeHook : Steps
    {

        public readonly ParallelConfig _parallelConfig;

        public TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Settings.BrowserType);
            LogHelpers.Write("Initialized framework");

        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Firefox)
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    _parallelConfig.Driver = new InternetExplorerDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    cap.SetCapability(CapabilityType.BrowserName, "firefox");
                    cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                    //var binary = new FirefoxBinary(@"C:\Program Files\Mozilla Firefox\firefox.exe");
                    //var profile = new FirefoxProfile();
                    _parallelConfig.Driver = new FirefoxDriver();
                    //DriverContext.Driver = new FirefoxDriver(binary, profile);
                    //DriverContext.Browser = new Browser(DriverContext.Driver);                    
                    break;
                case BrowserType.Chrome:
                    cap.SetCapability(CapabilityType.BrowserName, "chrome");
                    _parallelConfig.Driver = new ChromeDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
            _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);

        }

        public virtual void NavigateSite()
        {
            //DriverContext.Browser.GotToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }

    }
}
