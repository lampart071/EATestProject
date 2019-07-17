using System;
using EAAutoFramework.Base;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public LoginSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            Console.WriteLine(_parallelConfig.CurrentPage.As<HomePage>().GetLoggedInUser().Contains("admin")
                ? "Success Login"
                : "Unsuccessful Login");
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ClickLogOff();
        }

    }
}