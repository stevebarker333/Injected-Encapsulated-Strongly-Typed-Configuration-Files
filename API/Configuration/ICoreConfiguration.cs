using System;

namespace API.Configuration
{
    public interface ICoreConfiguration
    {
        string CoreString { get; }

        int CoreInt { get; }

        Uri CoreUri { get; }
    }
}
