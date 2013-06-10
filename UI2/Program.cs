using System;
using UI2.Configuration;
using API;
using UI2.DependencyInjection;
using API.Configuration;

namespace UI2
{
    public static class Program
    {
        public static void Main()
        {
            var configurationFile = Injector.Instance.Resolve<IConfigurationFile>();

            Console.WriteLine(configurationFile.UI2String);
            Console.WriteLine(configurationFile.UI2Int);
            Console.WriteLine(configurationFile.UI2Uri);

            var widget = Injector.Instance.Resolve<IWidget>();
            widget.DoSomething();

            Console.ReadLine();
        }
    }
}
