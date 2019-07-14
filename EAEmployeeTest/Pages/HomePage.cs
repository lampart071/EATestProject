using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {
        IWebElement lnkLogin 
            => DriverContext.Driver.FindElement(By.LinkText("Login"));
        
        IWebElement lnkEmployeeList
            => DriverContext.Driver.FindElement(By.LinkText("Employee List"));
       
        IWebElement lnkLoggedInUser
            => DriverContext.Driver.FindElement(By.XPath("//a[@title='Manage']"));

        IWebElement lnkLogoff
            => DriverContext.Driver.FindElement(By.LinkText("Log off"));
        

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

        internal EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();
        }

        internal LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return GetInstance<LoginPage>();
        }
    }
}
