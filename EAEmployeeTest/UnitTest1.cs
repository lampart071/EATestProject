using System;
using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://localhost/ExecuteAutoEmployee/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("admin", "password");
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();
        }


    }
}
