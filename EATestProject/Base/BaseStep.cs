using EAAutoFramework.Config;
using EAAutoFramework.Helpers;

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
