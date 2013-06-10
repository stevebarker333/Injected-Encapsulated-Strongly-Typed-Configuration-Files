using API.Configuration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using UI2.Configuration;
using API;

namespace UI2.DependencyInjection
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
            RegisterWidget(container);

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

        private static void RegisterWidget(WindsorContainer container)
        {
            container.Register(
                Component.For<IWidget>()
                .ImplementedBy(typeof(Widget))
                .LifeStyle.Singleton);
        }
    }
}
