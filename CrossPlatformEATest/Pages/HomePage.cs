﻿using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        IWebElement lnkLogin 
            => _parallelConfig.Driver.FindElement(By.LinkText("Login"));
        
        IWebElement lnkEmployeeList
            => _parallelConfig.Driver.FindElement(By.LinkText("Employee List"));
       
        IWebElement lnkLoggedInUser
            => _parallelConfig.Driver.FindElement(By.XPath("//a[@title='Manage']"));

        IWebElement lnkLogoff
            => _parallelConfig.Driver.FindElement(By.LinkText("Log off"));
        

        internal void CheckIfLoginExists()
        {
            lnkLogin.AssertElementPresent();
        }

        internal LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return new LoginPage(_parallelConfig);
        }

        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }

        internal EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return new EmployeeListPage(_parallelConfig);
        }

        internal LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return new LoginPage(_parallelConfig);
        }
    }
}
