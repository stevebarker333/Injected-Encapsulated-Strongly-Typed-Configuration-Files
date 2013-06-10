using API.Configuration;

namespace API
{
    using System;

    public class Widget
    {
        private readonly ICoreConfiguration configuration;

        public Widget(ICoreConfiguration configuration)
        {
            this.configuration = configuration;    
        }

        public void DoSomething()
        {
            Console.WriteLine(configuration.CoreString);
            Console.WriteLine(configuration.CoreInt);
            Console.WriteLine(configuration.CoreUri);
        }
    }
}
