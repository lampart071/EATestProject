using System.Configuration;

namespace EAAutoFramework.ConfigElements
{
    //[ConfigurationCollection(typeof(EAFrameworkElement), AddItemName = "testSetting", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    [ConfigurationCollection(typeof(EAFrameworkElement))]
    public class EAFrameworkElementCollection : ConfigurationElementCollection
    {

        internal const string PropertyName = "Element";

        protected override ConfigurationElement CreateNewElement()
        {
            return new EAFrameworkElement();
        }

        protected override ConfigurationElement CreateNewElement() { return new Element(); }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as EAFrameworkElement).Name;
        }

        protected override object GetElementKey(ConfigurationElement element) { return ((Element)(element)).name; }

        public new EAFrameworkElement this[string type]
        {
            get
            {
                return (EAFrameworkElement)base.BaseGet(type);
            }
        }



        
        public override ConfigurationElementCollectionType CollectionType { get { return ConfigurationElementCollectionType.BasicMapAlternate; } }
        protected override string ElementName { get { return PropertyName; } }
        protected override bool IsElementName(string elementName) { return elementName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase); }
        public override bool IsReadOnly() { return false; }
        
        
        public Element this[int idx] { get { return (Element)BaseGet(idx); } }
    }
}   