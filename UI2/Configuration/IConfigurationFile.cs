using System;

namespace UI2.Configuration
{
    public interface IConfigurationFile
    {
        string UI2String { get; }
        int UI2Int { get; }
        Uri UI2Uri { get; }
    }
}
