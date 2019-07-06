using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EAAutoFramework.Extensions;
using System;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
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
        }

        public HomePage ClickLoginButton()
        {
            btnLogin.Click();
            return GetInstance<HomePage>();
        }

        internal void CheckIfLoginExists()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
