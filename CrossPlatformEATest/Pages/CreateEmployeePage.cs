using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class CreateEmployeePage : BasePage
    {
        public CreateEmployeePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private IWebElement txtName 
            => _parallelConfig.Driver.FindElement(By.CssSelector("#Name"));

        private IWebElement txtSalary 
            => _parallelConfig.Driver.FindElement(By.CssSelector("#Salary"));

        private IWebElement txtDurationWorked 
            => _parallelConfig.Driver.FindElement(By.CssSelector("#DurationWorked"));

        private IWebElement txtGrade 
            => _parallelConfig.Driver.FindElement(By.CssSelector("#Grade"));

        private IWebElement txtEmail
            => _parallelConfig.Driver.FindElement(By.CssSelector("#Email"));

        private IWebElement btnCreateEmployee 
            => _parallelConfig.Driver.FindElement(By.XPath("//input[@value='Create']"));


        internal void ClickCreateButton() => btnCreateEmployee.Submit();

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
