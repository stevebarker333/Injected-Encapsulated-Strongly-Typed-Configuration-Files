using System;
using API.Configuration;

namespace UI1.Configuration
{
    public interface IConfigurationFile : ICoreConfiguration
    {
        string UI1String { get; }
        int UI1Int { get; }
        Uri UI1Uri { get; }
    }
}
