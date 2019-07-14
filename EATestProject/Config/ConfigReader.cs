using EAAutoFramework.Base;
using System;
using System.IO;
using System.Xml.XPath;
using EAAutoFramework.ConfigElements;

namespace EAAutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            Settings.AUT = EATestConfiguration.EASettings.TestSettings["staging"].AUT;
            //Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = EATestConfiguration.EASettings.TestSettings["staging"].TestType;
            Settings.IsLog = EATestConfiguration.EASettings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = EATestConfiguration.EASettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = EATestConfiguration.EASettings.TestSettings["staging"].LogPath;
            Settings.AppConnectionString = EATestConfiguration.EASettings.TestSettings["staging"].ApplicationDb;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), EATestConfiguration.EASettings.TestSettings["staging"].Browser);
        }
    }
}
