using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class LoginPage : BasePage
    {
        private IWebElement txtUserName
            => DriverContext.Driver.FindElement(By.CssSelector("#UserName"));

        private IWebElement txtPassword
            => DriverContext.Driver.FindElement(By.CssSelector("#Password"));

        private IWebElement btnLogin
            => DriverContext.Driver.FindElement(By.CssSelector("input.btn"));


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        internal HomePage ClickLoginButton()
        {
            btnLogin.Click();
            return GetInstance<HomePage>();
        }
    }
}
