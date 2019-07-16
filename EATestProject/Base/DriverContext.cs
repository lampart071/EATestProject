using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
    public class DriverContext
    {

        private IWebDriver _driver;

        public IWebDriver Driver
        {
            get => _driver;
            set => _driver = value;
        }


        public static Browser Browser { get; set; }

    }
}
