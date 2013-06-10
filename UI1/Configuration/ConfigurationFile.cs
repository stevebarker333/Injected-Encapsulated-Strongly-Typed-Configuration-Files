using System;

namespace UI1.Configuration
{
    public class ConfigurationFile : API.Configuration.ConfigurationFile, IConfigurationFile, API.Configuration.ICoreConfiguration
    {
        public string UI1String
        {
            get
            {
                return this.ReadString("UI1String");
            }
        }

        public int UI1Int
        {
            get
            {
                return this.ReadInt("UI1Int");
            }
        }

        public Uri UI1Uri
        {
            get
            {
                return this.ReadUri("UI1Uri");
            }
        }

        public string CoreString
        {
            get
            {
                return this.ReadString("CoreString");
            }
        }

        public int CoreInt
        {
            get
            {
                return this.ReadInt("CoreInt");
            }
        }

        public Uri CoreUri
        {
            get
            {
                return this.ReadUri("CoreUri");
            }
        }
    }
}