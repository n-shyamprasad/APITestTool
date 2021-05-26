using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Helper
{
    public sealed class APIConfiguration : ConfigurationSection
    {
        private static APIConfiguration objConfig = (APIConfiguration)ConfigurationManager.GetSection("API");

        public static APIConfiguration Config
        {
            get
            {
                return objConfig;
            }
        }

        [ConfigurationProperty("", IsRequired =true, IsDefaultCollection =true)]
        private APIURIElements Settings
        {
            get { return (APIURIElements)this[""]; }
            set { this[""] = value; }
        }
        public IEnumerable<APIURIElement> SettingsList
        {
            get { return this.Settings.Cast<APIURIElement>(); }
        }
    }

    public sealed class APIURIElements : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new APIURIElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((APIURIElement)element).APIID;
        }
    }

        public sealed class APIURIElement : ConfigurationElement
    {
        [ConfigurationProperty ("APIID", IsKey = true, IsRequired = true)]
        public string APIID
        {
            get { return (string) base["APIID"]; }
            set { base["APIID"] = value; }
        }

        [ConfigurationProperty("URL", IsRequired = true)]
        public string URL
        {
            get { return (string)base["URL"]; }
            set { base["URL"] = value; }
        }

        [ConfigurationProperty("ClientId", IsRequired = false)]
        public string ClientId
        {
            get { return (string)base["ClientId"]; }
            set { base["ClientId"] = value; }
        }

        [ConfigurationProperty("ClientSecret", IsRequired = false)]
        public string ClientSecret
        {
            get { return (string)base["ClientSecret"]; }
            set { base["ClientSecret"] = value; }
        }

        [ConfigurationProperty("PostInHeader", IsRequired = false)]
        public bool PostInHeader
        {
            get { return (bool)base["PostInHeader"]; }
            set { base["PostInHeader"] = value; }
        }
    }
}
