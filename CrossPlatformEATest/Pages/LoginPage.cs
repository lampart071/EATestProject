using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        private IWebElement txtUserName
            => _parallelConfig.Driver.FindElement(By.CssSelector("#UserName"));

        private IWebElement txtPassword
            => _parallelConfig.Driver.FindElement(By.CssSelector("#Password"));

        private IWebElement btnLogin
            => _parallelConfig.Driver.FindElement(By.CssSelector("input.btn"));


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        internal HomePage ClickLoginButton()
        {
            btnLogin.Click();
            return new HomePage(_parallelConfig);
        }
    }
}
