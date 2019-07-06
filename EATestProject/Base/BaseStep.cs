using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAAutoFramework.Base
{
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Browser.GotToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }
    }
}
