using EAAutoFramework.Base;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class CreateEmployeePage : BasePage
    {
        private IWebElement txtName 
            => DriverContext.Driver.FindElement(By.CssSelector("#Name"));

        private IWebElement txtSalary 
            => DriverContext.Driver.FindElement(By.CssSelector("#Salary"));

        private IWebElement txtDurationWorked 
            => DriverContext.Driver.FindElement(By.CssSelector("#DurationWorked"));

        private IWebElement txtGrade 
            => DriverContext.Driver.FindElement(By.CssSelector("#Grade"));

        private IWebElement txtEmail
            => DriverContext.Driver.FindElement(By.CssSelector("#Email"));

        private IWebElement btnCreateEmployee 
            => DriverContext.Driver.FindElement(By.XPath("//input[@value='Create']"));


        internal void ClickCreateButton()
        {
            btnCreateEmployee.Submit();
        }

        internal void CreateEmployee(string name, string salary, string durationworked, string grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(salary);
            txtDurationWorked.SendKeys(durationworked);
            txtGrade.SendKeys(grade);
            txtEmail.SendKeys(email);
        }

    }
}
