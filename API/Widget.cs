using System;
using API.Configuration;

namespace API
{
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
