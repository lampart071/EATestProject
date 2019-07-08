using EAAutoFramework.Base;
using System;
using System.IO;
using System.Xml.XPath;

namespace EAAutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem aut;
            XPathItem buildname;
            XPathItem browser;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem logPath;
            XPathItem appConnection;

            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            browser = navigator.SelectSingleNode("EAAutoFramework/RunSettings/Browser");
            testtype = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");
            appConnection = navigator.SelectSingleNode("EAAutoFramework/RunSettings/ApplicationDB");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), browser.Value.ToString());
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();            
            Settings.LogPath = logPath.Value.ToString();
            Settings.AppConnectionString = appConnection.Value.ToString();
        }
    }
}
