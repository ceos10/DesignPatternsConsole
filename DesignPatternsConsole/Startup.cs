using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DesignPatternsConsole.Logic.Behavioral;
using DesignPatternsConsole.Logic.Creational;
using DesignPatternsConsole.Logic.Structural;

namespace DesignPatternsConsole
{
    internal static class Startup
    {
        internal static IServiceCollection ConfigureServices(string parameter)
        {
            var services = new ServiceCollection();

            var configuration = CreateConfiguration();
            services.AddConfigurationSettings(configuration);

            services.AddLogging(c =>
            {
                c.AddConfiguration(configuration.GetSection("Logging"));
                c.AddConsole();
            });

            services.AddHttpClient();

            switch (parameter)
            {
                case "DECORATOR":
                    services.AddSingleton<DecoratorPattern>();
                    break;
                case "PROXY":
                    services.AddSingleton<ProxyPattern>();
                    break;
                case "BRIDGE":
                    services.AddSingleton<BridgePattern>();
                    break;
                case "COMPOSITE":
                    services.AddSingleton<CompositePattern>();
                    break;
                case "FLYWEIGHT":
                    services.AddSingleton<FlyweightPattern>();
                    break;
                case "ADAPTER":
                    services.AddSingleton<AdapterPattern>();
                    break;
                case "FACADE":
                    services.AddSingleton<FacadePattern>();
                    break;
                case "PROTOTYPE":
                    services.AddSingleton<PrototypePattern>();
                    break;
                case "FACTORYMETHOD":
                    services.AddSingleton<FactoryMethodPattern>();
                    break;
                case "SINGLETON":
                    services.AddSingleton<SingletonPattern>();
                    break;
                case "ABSTRACTFACTORY":
                    services.AddSingleton<AbstractFactoryPattern>();
                    break;
                case "BUILDER":
                    services.AddSingleton<BuilderPattern>();
                    break;
                case "STRATEGY":
                    services.AddSingleton<StrategyPattern>();
                    break;
                case "STATE":
                    services.AddSingleton<StatePattern>();
                    break;
                case "TEMPLATEMETHOD":
                    services.AddSingleton<TemplateMethodPattern>();
                    break;
                case "CHANGEOFRESPONSIBILITY":
                    services.AddSingleton<ChainOfResponsibilityPattern>();
                    break;
                case "COMMAND":
                    services.AddSingleton<CommandPattern>();
                    break;
                case "ITERATOR":
                    services.AddSingleton<IteratorPattern>();
                    break;
                case "MEDIATOR":
                    services.AddSingleton<MediatorPattern>();
                    break;
                case "OBSERVER":
                    services.AddSingleton<ObserverPattern>();
                    break;
                case "VISITOR":
                    services.AddSingleton<VisitorPattern>();
                    break;
                case "INTERPRETER":
                    services.AddSingleton<InterpreterPattern>();
                    break;
                case "MEMENTO":
                    services.AddSingleton<MementoPattern>();
                    break;
                default:
                    services.AddSingleton<DecoratorPattern>();
                    break;
            }

            return services;
        }

        private static IConfigurationRoot CreateConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddEnvironmentVariables();
            return builder.Build();
        }

        private static void AddConfigurationSettings(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var appSettings = new AppSettings();
            configuration.Bind("appSettings", appSettings);
            services.AddSingleton(appSettings);
        }
    }
}
