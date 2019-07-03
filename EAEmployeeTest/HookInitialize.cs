using EAAutoFramework.Base;

namespace EAEmployeeTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
            NavigateSite();
        }
    }
}
