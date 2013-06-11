using System;
using UI1.Configuration;
using API;
using UI1.DependencyInjection;

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

            var widget = Injector.Instance.Resolve<IWidget>();
            widget.DoSomething();

            Console.ReadLine();
        }
    }
}
