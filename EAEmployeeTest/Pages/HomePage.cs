using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Manage']")]
        IWebElement lnkLoggedInUser { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log off")]
        IWebElement lnkLogoff { get; set; }


        internal void CheckIfLoginExists()
        {
            lnkLogin.AssertElementPresent();
        }

        internal LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage>();
        }

        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }

        public EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();
        }

        public LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return GetInstance<LoginPage>();
        }
    }
}
