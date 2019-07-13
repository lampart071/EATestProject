using System.Configuration;

namespace EAAutoFramework.ConfigElements
{
    public class EAFrameworkElement : ConfigurationElement
    {
        //[ConfigurationProperty("name", IsRequired = true)]
        //public string Name { get { return (string)base["name"]; } }

        //[ConfigurationProperty("aut", IsRequired = true)]
        //public string AUT { get { return (string)base["aut"]; } }

        //[ConfigurationProperty("browser", IsRequired = true)]
        //public string Browser { get { return (string)base["browser"]; } }

        //[ConfigurationProperty("testType", IsRequired = true)]
        //public string TestType { get { return (string)base["testType"]; } }

        //[ConfigurationProperty("isLog", IsRequired = true)]
        //public string IsLog { get { return (string)base["isLog"]; } }

        //[ConfigurationProperty("logPath", IsRequired = true)]
        //public string LogPath { get { return (string)base["logPath"]; } }

        [ConfigurationProperty("name", DefaultValue = "NO_NAME", IsKey = true, IsRequired = false)]
        public string name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("userid", DefaultValue = "NO_USER", IsKey = false, IsRequired = false)]
        public string userid
        {
            get { return (string)base["userid"]; }
            set { base["userid"] = value; }
        }

    }
}
