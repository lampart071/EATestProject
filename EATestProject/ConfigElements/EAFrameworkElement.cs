using System.Configuration;

namespace EAAutoFramework.ConfigElements
{
    public class EAFrameworkElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUT => (string)base["aut"];

        [ConfigurationProperty("browser", IsRequired = true)]
        public string Browser => (string)base["browser"];

        [ConfigurationProperty("testType", IsRequired = true)]
        public string TestType => (string)base["testType"];

        [ConfigurationProperty("isLog", IsRequired = true)]
        public string IsLog => (string)base["isLog"];

        [ConfigurationProperty("logPath", IsRequired = true)]
        public string LogPath => (string)base["logPath"];

        [ConfigurationProperty("appDb", IsRequired = true)]
        public string ApplicationDb => (string)base["appDb"];
    }
}
