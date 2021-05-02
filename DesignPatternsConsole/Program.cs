using DesignPatternsConsole.Logic;
using DesignPatternsConsole.Logic.Behavioral;
using DesignPatternsConsole.Logic.Creational;
using DesignPatternsConsole.Logic.Structural;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DesignPatternsConsole
{
    internal class Program
    {
        private static IServiceProvider _serviceProvider;

        private static AppSettings _appSettings;
        protected static AppSettings AppSettings
        {
            get { return _appSettings ??= _serviceProvider.GetService<AppSettings>(); }
        }

        private static ILogger<Program> _logger;

        protected static ILogger<Program> Logger
        {
            get { return _logger ??= _serviceProvider.GetService<ILogger<Program>>(); }
        }

        private static async Task Main(string[] args)
        {
            try
            {
                var parameter = args.Length < 1 ? "DECORATOR" : args[0];

                var services = Startup.ConfigureServices(parameter);
                _serviceProvider = services.BuildServiceProvider();

                IPattern service = (parameter.ToUpper()) switch
                {
                    "DECORATOR" => _serviceProvider.GetService<DecoratorPattern>(),
                    "PROXY" => _serviceProvider.GetService<ProxyPattern>(),
                    "BRIDGE" => _serviceProvider.GetService<BridgePattern>(),
                    "COMPOSITE" => _serviceProvider.GetService<CompositePattern>(),
                    "FLYWEIGHT" => _serviceProvider.GetService<FlyweightPattern>(),
                    "ADAPTER" => _serviceProvider.GetService<AdapterPattern>(),
                    "FACADE" => _serviceProvider.GetService<FacadePattern>(),
                    "PROTOTYPE" => _serviceProvider.GetService<PrototypePattern>(),
                    "FACTORYMETHOD" => _serviceProvider.GetService<FactoryMethodPattern>(),
                    "SINGLETON" => _serviceProvider.GetService<SingletonPattern>(),
                    "ABSTRACTFACTORY" => _serviceProvider.GetService<AbstractFactoryPattern>(),
                    "BUILDER" => _serviceProvider.GetService<BuilderPattern>(),
                    "STRATEGY" => _serviceProvider.GetService<StrategyPattern>(),
                    "STATE" => _serviceProvider.GetService<StatePattern>(),
                    "TEMPLATEMETHOD" => _serviceProvider.GetService<TemplateMethodPattern>(),
                    "CHANGEOFRESPONSIBILITY" => _serviceProvider.GetService<ChainOfResponsibilityPattern>(),
                    "COMMAND" => _serviceProvider.GetService<CommandPattern>(),
                    "ITERATOR" => _serviceProvider.GetService<IteratorPattern>(),
                    "MEDIATOR" => _serviceProvider.GetService<MediatorPattern>(),
                    "OBSERVER" => _serviceProvider.GetService<ObserverPattern>(),
                    "VISITOR" => _serviceProvider.GetService<VisitorPattern>(),
                    "INTERPRETER" => _serviceProvider.GetService<InterpreterPattern>(),
                    "MEMENTO" => _serviceProvider.GetService<MementoPattern>(),
                    _ => _serviceProvider.GetService<DecoratorPattern>(),
                };

                service.RunExample();
            }
            catch (Exception ex)
            {
            }

            Console.WriteLine("Batch Done");
        }
    }
}