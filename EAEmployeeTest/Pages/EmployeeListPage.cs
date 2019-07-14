using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        private IWebElement txtSearch
            => DriverContext.Driver.FindElement(By.Name("searchTerm"));
        
        private IWebElement lnkCreateNew
            => DriverContext.Driver.FindElement((By.LinkText("Create New")));
        
        private IWebElement tblEmployeeList 
            => DriverContext.Driver.FindElement((By.CssSelector(".table")));

        private IWebElement lnkLogoff
            => DriverContext.Driver.FindElement((By.LinkText("Log off")));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }

        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }

        internal void ClickLogoff()
        {
            lnkLogoff.Click();
        }

        public void ClickCreateButton()
        {
            throw new System.NotImplementedException();
        }
    }
}
