using System;
using System.Configuration;

namespace EAAutoFramework.ConfigElements
{
    //[ConfigurationCollection(typeof(EAFrameworkElement), AddItemName = "testSetting", CollectionType = ConfigurationElementCollectionType.BasicMap)]
    [ConfigurationCollection(typeof(EAFrameworkElement))]
    public class EAFrameworkElementCollection : ConfigurationElementCollection
    {

        //Settings from outer project
        internal const string PropertyName = "Element";
        public override ConfigurationElementCollectionType CollectionType { get { return ConfigurationElementCollectionType.BasicMapAlternate; } }
        protected override string ElementName { get { return PropertyName; } }
        protected override bool IsElementName(string elementName) { return elementName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase); }
        public override bool IsReadOnly() { return false; }


        //Similarities
        protected override ConfigurationElement CreateNewElement(){return new EAFrameworkElement();} //OK        
        protected override object GetElementKey(ConfigurationElement element) { return ((EAFrameworkElement)(element)).name; } //OK

        
        public new EAFrameworkElement this[string type]{get{return (EAFrameworkElement)base.BaseGet(type);}}//? To decide
        //public EAFrameworkElement this[int idx] { get { return (EAFrameworkElement)BaseGet(idx); } }//? To decide








    }
}   