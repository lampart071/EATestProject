using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        public EmployeeListPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private IWebElement lnkCreateNew
           => _parallelConfig.Driver.FindElement((By.LinkText("Create New")));

        private IWebElement lnkLogoff
           => _parallelConfig.Driver.FindElement((By.LinkText("Log off")));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage(_parallelConfig);
        }

        internal void ClickLogoff() => lnkLogoff.Click();
    }
}
