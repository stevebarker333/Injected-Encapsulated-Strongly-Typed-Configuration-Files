using System;

namespace UI2.Configuration
{
    public class ConfigurationFile : API.Configuration.ConfigurationFile, IConfigurationFile, API.Configuration.ICoreConfiguration
    {
        public string UI2String
        {
            get
            {
                return this.ReadString("UI2String");
            }
        }

        public int UI2Int
        {
            get
            {
                return this.ReadInt("UI2Int");
            }
        }

        public Uri UI2Uri
        {
            get
            {
                return this.ReadUri("UI2Uri");
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