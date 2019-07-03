//using System;
//using EAAutoFramework.Base;
//using EAAutoFramework.Helpers;
//using EAAutoFramework.Config;
//using EAEmployeeTest.Pages;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;

//namespace EAEmployeeTest
//{
//    [TestClass]
//    public class UnitTest1 : HookInitialize
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
//            ExcelHelpers.PopulateInCollection(fileName);

//            //LoginPage
//            CurrentPage = GetInstance<LoginPage>();
//            CurrentPage.As<LoginPage>().ClickLoginLink();
//            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
//            //CurrentPage.As<LoginPage>().Login("admin", "password");
//            //EmployeePage
//            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
//            CurrentPage.As<EmployeeListPage>().ClickCreateNew();
//            LogHelpers.CloseLog();
//        }

//        [TestMethod]
//        public void TableOperation()
//        {
//            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
//            ExcelHelpers.PopulateInCollection(fileName);

//            CurrentPage = GetInstance<LoginPage>();
//            CurrentPage.As<LoginPage>().ClickLoginLink();
//            CurrentPage.As<LoginPage>().CheckIfLoginExists();
//            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
//            //EmployeePage
//            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();

//            var table = CurrentPage.As<EmployeeListPage>().GetEmployeeList();

//            HtmlTableHelpers.ReadTable(table);
//            HtmlTableHelpers.PerformActionOnCell("6", "Name", "Ramesh", "Edit");
//            LogHelpers.CloseLog();
//        }
//    }
//}
