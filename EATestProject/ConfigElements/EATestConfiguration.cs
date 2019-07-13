using System.Configuration;

namespace EAAutoFramework.ConfigElements
{
    public class EATestConfiguration : ConfigurationSection
    {
        //private static EATestConfiguration _testConfig = (EATestConfiguration)ConfigurationManager.GetSection("EATestConfiguration");

        //public static EATestConfiguration EASettings { get { return _testConfig; } }

        //[ConfigurationProperty("testSettings")]
        //public EAFrameworkElementCollection TestSettings { get { return (EAFrameworkElementCollection)base["testSettings"]; } }

        [ConfigurationProperty("Servers")]
        public EAFrameworkElementCollection ServerElement
        {
            get { return ((EAFrameworkElementCollection)(base["Servers"])); }
            //set { base["Servers"] = value; }
        }

    } 
}
