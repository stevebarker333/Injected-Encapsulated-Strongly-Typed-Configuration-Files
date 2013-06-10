using API.Configuration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using UI1.Configuration;

namespace UI1.DependencyInjection
{
    public static class Injector
    {
        private static readonly object InstanceLock = new object();

        private static IWindsorContainer instance;

        public static IWindsorContainer Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    return instance ?? (instance = GetInjector());
                }
            }
        }

        private static IWindsorContainer GetInjector()
        {
            var container = new WindsorContainer();

            container.Install(FromAssembly.This());

            RegisterInjector(container);
            RegisterConfiguration(container);

            return container;
        }

        private static void RegisterInjector(WindsorContainer container)
        {
            container.Register(
                Component.For<IWindsorContainer>()
                .Instance(container));
        }

        private static void RegisterConfiguration(WindsorContainer container)
        {
            container.Register(
                Component.For<IConfigurationFile, ICoreConfiguration>()
                .ImplementedBy(typeof(Configuration.ConfigurationFile))
                .LifeStyle.Singleton);
        }
    }
}
