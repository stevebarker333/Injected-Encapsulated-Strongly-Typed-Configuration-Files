using API.Configuration;

namespace API
{
    using System;

    public class Widget : IWidget
    {
        public ICoreConfiguration Configuration { get; set; }

        public void DoSomething()
        {
            Console.WriteLine(Configuration.CoreString);
            Console.WriteLine(Configuration.CoreInt);
            Console.WriteLine(Configuration.CoreUri);
        }
    }
}
