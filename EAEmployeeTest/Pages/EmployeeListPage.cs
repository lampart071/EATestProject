using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        private IWebElement lnkCreateNew
            => DriverContext.Driver.FindElement((By.LinkText("Create New")));

        private IWebElement lnkLogoff
            => DriverContext.Driver.FindElement((By.LinkText("Log off")));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }

        internal void ClickLogoff() => lnkLogoff.Click();
    }
}
