using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    internal class ExtendedSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        public ExtendedSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            _parallelConfig.CurrentPage = new HomePage(_parallelConfig);
        }

        [Given(@"I Delete employee '(.*)' before I start running test")]
        public void GivenIDeleteEmployeeBeforeIStartRunningTest(string employeeName)
        {
            string query = "delete from Employees Where Name = '" + employeeName + "'";
            Settings.ApplicationCon.ExecuteQuery(query);
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            _parallelConfig.CurrentPage.As<HomePage>().CheckIfLoginExists();
        }

        [Then(@"I click (.*) link")]
        public void ThenIClickLink(string linkName)
        {
            if (linkName == "login")
                _parallelConfig.CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
            else if (linkName == "employeeList")
                _parallelConfig.CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeList();
        }

        [Then(@"I click (.*) button")]
        public void ThenIClickButton(string buttonName)
        {
            if (buttonName == "login")
                CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
            else if (buttonName == "createnew")
                CurrentPage = CurrentPage.As<EmployeeListPage>().ClickCreateNew();
            else if (buttonName == "create")
                CurrentPage.As<CreateEmployeePage>().ClickCreateButton();
        }

        [Then(@"I click log off")]
        public void ThenIClickLogOff()
        {
            CurrentPage.As<EmployeeListPage>().ClickLogoff();
        }
        
    }
}