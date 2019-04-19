using System;
using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://localhost:64429/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            Login();

        }

        public void Login()
        {
            //_driver.FindElement(By.LinkText("Login")).Click();

            ////UserName
            //_driver.FindElement((By.Id("UserName"))).SendKeys("admin");
            //_driver.FindElement((By.Id("Password"))).SendKeys("password");

            ////click Login
            //_driver.FindElement(By.CssSelector("input.btn")).Submit();

            LoginPage page = new LoginPage();
            page.lnkLogin.Click();
            page.txtUserName.SendKeys("admin");
            page.txtPassword.SendKeys("password");
            page.btnLogin.Submit();

            //EmployeePage empPage = new EmployeePage();
         }
    }
}
