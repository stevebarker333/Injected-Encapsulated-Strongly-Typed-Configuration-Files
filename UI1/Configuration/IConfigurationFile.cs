using System;

namespace UI1.Configuration
{
    public interface IConfigurationFile
    {
        string UI1String { get; }
        int UI1Int { get; }
        Uri UI1Uri { get; }
    }
}
