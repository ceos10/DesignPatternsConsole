using DesignPatternsConsole.Logic;
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

                switch (parameter.ToUpper())
                {
                    case ("DECORATOR"):
                        var service1 = _serviceProvider.GetService<DecoratorPatthern>();
                        service1.RunExample();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
            }

            Console.WriteLine("Batch Done");
        }
    }
}
