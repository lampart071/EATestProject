using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class EmployeePage : BasePage
    {
        //Initilaize page
        public EmployeePage(IWebDriver driver) :
            base(driver)
        {

        }

        //Objects for login page
        [FindsBy(How = How.Name, Using = "searchTerm")]
        public IWebElement lnkLogin { get; set; }
    }
}
