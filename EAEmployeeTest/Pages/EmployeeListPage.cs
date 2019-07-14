using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "searchTerm")]
        IWebElement txtSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create New")]
        IWebElement lnkCreateNew { get; set; }

        [FindsBy(How = How.ClassName, Using = "table")]
        IWebElement tblEmployeeList { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log off")]
        IWebElement lnkLogoff { get; set; }

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
