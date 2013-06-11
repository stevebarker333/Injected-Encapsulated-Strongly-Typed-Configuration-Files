using System;
using API.Configuration;

namespace UI2.Configuration
{
    public interface IConfigurationFile : ICoreConfiguration
    {
        string UI2String { get; }
        int UI2Int { get; }
        Uri UI2Uri { get; }
    }
}
