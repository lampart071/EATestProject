using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        //Objects for login page
        [FindsBy(How = How.Name, Using = "searchTerm")]
        IWebElement txtSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create New")]
        IWebElement lnkCreateNew { get; set; }

        [FindsBy(How = How.ClassName, Using = "table")]
        IWebElement tblEmployeeList { get; set; }

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }

        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }

        public void ClickCreateButton()
        {
            throw new System.NotImplementedException();
        }
    }
}
