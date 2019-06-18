using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Extentions;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        //Objects for login page
        [FindsBy(How = How.LinkText, Using = "Login")]
        IWebElement lnkLogin { get; set; }
        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }
        [FindsBy(How = How.Id, Using = "UserName")]
        IWebElement txtUserName { get; set; }
        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement txtPassword { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        IWebElement btnLogin { get; set; }

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

        public void ClickLoginLink()
        {
            lnkLogin.Click();
        }

        public EmployeePage ClickEmployeeList()
        {            
            lnkEmployeeList.Click();
            return GetInstance<EmployeePage>();
        }

        internal void CheckIfLoginExists()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
