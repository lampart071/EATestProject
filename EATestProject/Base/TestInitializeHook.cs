using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace EAAutoFramework.Base
{
    public abstract class TestInitializeHook : Base
    {

        public static void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Settings.BrowserType);
            LogHelpers.Write("Initialized framework");

        }

        private static void OpenBrowser(BrowserType browserType = BrowserType.Firefox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    //var binary = new FirefoxBinary(@"C:\Program Files\Mozilla Firefox\firefox.exe");
                    //var profile = new FirefoxProfile();
                    DriverContext.Driver = new FirefoxDriver();
                    //DriverContext.Driver = new FirefoxDriver(binary, profile);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GotToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }

    }
}
