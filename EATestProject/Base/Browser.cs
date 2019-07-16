using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
    public class Browser
    {
        private readonly DriverContext driverContext;

        public Browser(DriverContext driver)
        {
            driverContext = driver;
        }

        public BrowserType Type { get; set; }

        public void GotToUrl(string url)
        {
            driverContext.Driver.Url = url;
        }

    }

    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
}
