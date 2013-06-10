using System;
using System.Configuration;

namespace API.Configuration
{
    public abstract class ConfigurationFile
    {
        private readonly AppSettingsReader appSettingsReader = new AppSettingsReader();

        protected string ReadString(string key)
        {
            try
            {
                return (string)appSettingsReader.GetValue(key, typeof(string));
            }
            catch (Exception exception)
            {
                var message = string.Format("Could not read key {0} from configuration file", key);
                throw new ConfigurationErrorsException(message, exception);
            }
        }

        protected int ReadInt(string key)
        {
            try
            {
                var value = this.ReadString(key);
                return int.Parse(value);
            }
            catch (Exception exception)
            {
                var message = string.Format("Could not read an int from key {0} in the configuration file", key);
                throw new ConfigurationErrorsException(message, exception);
            }
        }

        protected Uri ReadUri(string key)
        {
            try
            {
                var value = this.ReadString(key);
                return new Uri(value);
            }
            catch (Exception exception)
            {
                var message = string.Format("Could not read a Uri from key {0} in the configuration file", key);
                throw new ConfigurationErrorsException(message, exception);
            }
        }
    }
}
