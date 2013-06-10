using System;
using UI1.Configuration;
using API;
using UI1.DependencyInjection;
using API.Configuration;

namespace UI1
{
    public static class Program
    {
        public static void Main()
        {
            var configurationFile = Injector.Instance.Resolve<IConfigurationFile>();

            Console.WriteLine(configurationFile.UI1String);
            Console.WriteLine(configurationFile.UI1Int);
            Console.WriteLine(configurationFile.UI1Uri);

            var widget = new Widget(Injector.Instance.Resolve<ICoreConfiguration>());
            widget.DoSomething();

            Console.ReadLine();
        }
    }
}
