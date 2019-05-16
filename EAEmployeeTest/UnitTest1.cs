using System;
using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAAutoFramework.Config;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        public void OpenBrowser(BrowserType browserType = BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            ConfigReader.SetFrameworkSettings();

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Opened the browser !!!");

            DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
            LogHelpers.Write("Navigated to the page !!!");
            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            //CurrentPage.As<LoginPage>().Login("admin", "password");
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();
            LogHelpers.CloseLog();
        }

        [TestMethod]
        public void TableOperation()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Opened the browser !!!");

            DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
            LogHelpers.Write("Navigated to the page !!!");

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();

            var table = CurrentPage.As<EmployeePage>().GetEmployeeList();

            HtmlTableHelpers.ReadTable(table);
            HtmlTableHelpers.PerformActionOnCell("6", "Name", "Ramesh", "Edit");
            LogHelpers.CloseLog();
        }
    }
}
